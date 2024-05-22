using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DVenda
    {
        private int _IdVenda;
        private int _IdCliente;
        private int _IdFuncionario;
        private DateTime _Data;
        private string _Tipo_Comprovante;
        private string _Serie;
        private string _Correlativo;
        private decimal _Imposto;
        private int _Parcela;

        public int IdVenda { get => _IdVenda; set => _IdVenda = value; }
        public int IdCliente { get => _IdCliente; set => _IdCliente = value; }
        public int IdFuncionario { get => _IdFuncionario; set => _IdFuncionario = value; }
        public DateTime Data { get => _Data; set => _Data = value; }
        public string Tipo_Comprovante { get => _Tipo_Comprovante; set => _Tipo_Comprovante = value; }
        public string Serie { get => _Serie; set => _Serie = value; }
        public string Correlativo { get => _Correlativo; set => _Correlativo = value; }
        public decimal Imposto { get => _Imposto; set => _Imposto = value; }
        public int Parcela { get => _Parcela; set => _Parcela = value; }

        public DVenda()
        {

        }
        public DVenda(int idvenda, int idcliente,int idfuncionario,DateTime data,string tipo_comprovante, string serie, decimal imposto, int parcela)
        {
            this.IdVenda = idvenda;
            this.IdCliente = idcliente;
            this.IdFuncionario= idfuncionario;
            this.Data = data;
            this.Tipo_Comprovante= tipo_comprovante;
            this.Serie = serie;
            this.Imposto = imposto;
            this.Parcela = parcela;
        }

        public string DiminuirEstoque(int iddetalhe_entrada, int quantidade)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdiminuir_estoque";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_entrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = iddetalhe_entrada;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParQuantidade = new SqlParameter();
                ParQuantidade.ParameterName = "@quantidade";
                ParQuantidade.SqlDbType = SqlDbType.Int;
                ParQuantidade.Value = quantidade;
                SqlCmd.Parameters.Add(ParQuantidade);



                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Certo" : "Registro não foi salvo";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }

        public string Inserir(DVenda Venda, List<DDetalhe_Venda> Detalhe)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();

                SqlTransaction SqlTra = SqlCon.BeginTransaction(); //forma diferente de iniciar

                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "spinserir_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idvenda";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

                SqlParameter ParIdCliente = new SqlParameter();
                ParIdCliente.ParameterName = "@idcliente";
                ParIdCliente.SqlDbType = SqlDbType.Int;
                ParIdCliente.Value = Venda.IdCliente;
                SqlCmd.Parameters.Add(ParIdCliente);



                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@idfuncionario";
                ParIdFuncionario.SqlDbType = SqlDbType.Int;
                ParIdFuncionario.Value = Venda.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);



               

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = Venda.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParTipoComprovante = new SqlParameter();
                ParTipoComprovante.ParameterName = "@tipo_comprovante";
                ParTipoComprovante.SqlDbType = SqlDbType.VarChar;
                ParTipoComprovante.Size = 50;
                ParTipoComprovante.Value = Venda.Tipo_Comprovante;
                SqlCmd.Parameters.Add(ParTipoComprovante);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@serie";
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 4;
                ParSerie.Value = Venda.Serie;
                SqlCmd.Parameters.Add(ParSerie);

                SqlParameter ParCorrelativo = new SqlParameter();
                ParCorrelativo.ParameterName = "@correlativo";
                ParCorrelativo.SqlDbType = SqlDbType.VarChar;
                ParCorrelativo.Size = 7;
                ParCorrelativo.Value = Venda.Correlativo;
                SqlCmd.Parameters.Add(ParCorrelativo);

                SqlParameter ParImposto = new SqlParameter();
                ParImposto.ParameterName = "@imposto";
                ParImposto.SqlDbType = SqlDbType.Decimal;
                ParImposto.Precision = 4;
                ParImposto.Scale = 2;
                ParImposto.Value = Venda.Imposto;
                SqlCmd.Parameters.Add(ParImposto);

                SqlParameter ParParcela = new SqlParameter();
                ParParcela.ParameterName = "@numero_parcela";
                ParParcela.SqlDbType = SqlDbType.Int;
                ParParcela.Value = Venda.Parcela;
                SqlCmd.Parameters.Add(ParParcela);


                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Certo" : "Registro não foi salvo";

                //verificar se registrou no DDetalhe venda
                if (resp.Equals("Certo"))
                {
                    this.IdVenda = Convert.ToInt32(SqlCmd.Parameters["@idvenda"].Value);
                    //Entrando no DDetalhe entrada e chamando o inserir de la por aqui
                    //relacionando os id
                    foreach (DDetalhe_Venda det in Detalhe)
                    {
                        det.IdVenda = IdVenda;

                        resp = det.Inserir(det, ref SqlCon, ref SqlTra);

                        if (!resp.Equals("Certo"))
                        {
                            break;
                        }
                        else
                        {
                            resp = DiminuirEstoque(det.IdDetalhe_Entrada, det.Quantidade);
                            if (!resp.Equals("Certo"))
                            {
                                break;
                            }
                        }

                    }

                }
                if (resp.Equals("Certo"))
                {
                    SqlTra.Commit(); //salvar em commit é necessario
                }
                else
                {
                    SqlTra.Rollback(); //cancela tudo
                }
            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }

        public string Excluir(DVenda Venda)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@idvenda";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Venda.IdVenda;
                SqlCmd.Parameters.Add(ParId);




                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Certo" : "Certo";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            finally
            {
                if (SqlCon.State == ConnectionState.Open) SqlCon.Close();
            }
            return resp;
        }
        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("venda"); 
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);

            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }
        //buscar pela data
        public DataTable BuscarData(string textobuscar, string textobuscar2)
        {
            DataTable DtResultado = new DataTable("venda"); //alterado
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_venda_data";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = textobuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlParameter ParTextoBuscar2 = new SqlParameter();
                ParTextoBuscar2.ParameterName = "@textobuscar2";
                ParTextoBuscar2.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar2.Size = 50;
                ParTextoBuscar2.Value = textobuscar2;
                SqlCmd.Parameters.Add(ParTextoBuscar2);
                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable MostrarDetalhes(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("detalhe_venda"); 
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalhe_venda";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable MostrarParcela(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("parcelas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_parcela";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }



        public DataTable MostrarProduto_Venda_Nome(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("produto"); //alterado
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscarproduto_venda_nome";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

        public DataTable MostrarProduto_Venda_Codigo(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("produto"); //alterado
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscarproduto_venda_codigo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = TextoBuscar;
                SqlCmd.Parameters.Add(ParTextoBuscar);

                SqlDataAdapter sqlDat = new SqlDataAdapter(SqlCmd);
                sqlDat.Fill(DtResultado);
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }




    }
}
