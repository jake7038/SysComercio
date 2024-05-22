using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Runtime.ConstrainedExecution;

namespace CamadaDados
{
    public class DEntrada
    {
        private int _IdEntrada;
        private int _IdFuncionario;
        private int _IdFornecedor;
        private DateTime _Data;
        private string _TipoComprovante;
        private string _Serie;
        private string _Correlativo;
        private decimal _Imposto;
        private string _Estado;
      //  private string _TextoBuscar;
      //  private string _TextoBuscar2;

        public int IdEntrada { get => _IdEntrada; set => _IdEntrada = value; }
        public int IdFuncionario { get => _IdFuncionario; set => _IdFuncionario = value; }
        public int IdFornecedor { get => _IdFornecedor; set => _IdFornecedor = value; }
        public DateTime Data { get => _Data; set => _Data = value; }
        public string TipoComprovante { get => _TipoComprovante; set => _TipoComprovante = value; }
        public string Serie { get => _Serie; set => _Serie = value; }
        public string Correlativo { get => _Correlativo; set => _Correlativo = value; }
       
        public string Estado { get => _Estado; set => _Estado = value; }
      //  public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }
      //  public string TextoBuscar2 { get => _TextoBuscar2; set => _TextoBuscar2 = value; }
        public decimal Imposto { get => _Imposto; set => _Imposto = value; }

        public DEntrada()
        {

        }

        public DEntrada(int identrada, int idfuncionario, int idfornecedor, DateTime data, string tipocomprovante, string correlativo, decimal imposto, string estado)
        {
            this.IdEntrada = identrada;
            this.IdFuncionario = idfuncionario;
            this.IdFornecedor = idfornecedor;
            this.Data = data;
            this.TipoComprovante = tipocomprovante;
            this.Correlativo = correlativo;
            this.Imposto = imposto;
            this.Estado = estado;
            
        }


        public string Inserir(DEntrada Entrada, List <DDetalhe_Entrada> Detalhe)
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
                SqlCmd.Transaction= SqlTra;
                SqlCmd.CommandText = "spinserir_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@identrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);



                SqlParameter ParIdFuncionario = new SqlParameter();
                ParIdFuncionario.ParameterName = "@idfuncionario";
                ParIdFuncionario.SqlDbType = SqlDbType.Int;
                ParIdFuncionario.Value = Entrada.IdFuncionario;
                SqlCmd.Parameters.Add(ParIdFuncionario);



                SqlParameter ParIdFornecedor = new SqlParameter();
                ParIdFornecedor.ParameterName = "@idfornecedor";
                ParIdFornecedor.SqlDbType = SqlDbType.Int;
                ParIdFornecedor.Value = Entrada.IdFornecedor;
                SqlCmd.Parameters.Add(ParIdFornecedor);

                SqlParameter ParData = new SqlParameter();
                ParData.ParameterName = "@data";
                ParData.SqlDbType = SqlDbType.Date;
                ParData.Value = Entrada.Data;
                SqlCmd.Parameters.Add(ParData);

                SqlParameter ParTipoComprovante = new SqlParameter();
                ParTipoComprovante.ParameterName = "@tipo_comprovante";
                ParTipoComprovante.SqlDbType = SqlDbType.VarChar;
                ParTipoComprovante.Size = 50;
                ParTipoComprovante.Value = Entrada.TipoComprovante;
                SqlCmd.Parameters.Add(ParTipoComprovante);

                SqlParameter ParSerie = new SqlParameter();
                ParSerie.ParameterName = "@serie";
                ParSerie.SqlDbType = SqlDbType.VarChar;
                ParSerie.Size = 4;
                ParSerie.Value = Entrada.Serie;
                SqlCmd.Parameters.Add(ParSerie);

                SqlParameter ParCorrelativo = new SqlParameter();
                ParCorrelativo.ParameterName = "@correlativo";
                ParCorrelativo.SqlDbType = SqlDbType.VarChar;
                ParCorrelativo.Size = 7;
                ParCorrelativo.Value = Entrada.Correlativo;
                SqlCmd.Parameters.Add(ParCorrelativo);

                SqlParameter ParImposto = new SqlParameter();
                ParImposto.ParameterName = "@imposto";
                ParImposto.SqlDbType = SqlDbType.Decimal;
                ParImposto.Precision = 4;
                ParImposto.Scale = 2;
                ParImposto.Value = Entrada.Imposto;
                SqlCmd.Parameters.Add(ParImposto);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 7;
                ParEstado.Value = Entrada.Estado;
                SqlCmd.Parameters.Add(ParEstado);


                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Certo" : "Registro não foi salvo";

                //verificar se registrou no DDetalhe entrada
                if (resp.Equals("Certo"))
                {
                    this.IdEntrada=Convert.ToInt32(SqlCmd.Parameters["@identrada"].Value);
                    //Entrando no DDetalhe entrada e chamando o inserir de la por aqui
                    //relacionando os id
                    foreach (DDetalhe_Entrada det in Detalhe)
                    {
                        det.IdEntrada = IdEntrada;

                        resp = det.Inserir(det, ref SqlCon, ref SqlTra);

                        if (!resp.Equals("Certo")) { 
                        break;
                        }
                        
                    }

                }
                if (resp.Equals("Certo"))
                {
                    SqlTra.Commit(); //salvar em commit é necessario
                }
                else
                {
                    SqlTra.Rollback(); //cancela
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

        public string Anular(DEntrada entrada)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spanular_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@identrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = entrada.IdEntrada;
                SqlCmd.Parameters.Add(ParId);




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


        public string EditarConta(DEntrada Entrada)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_devendo";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter parId = new SqlParameter();
                parId.ParameterName = "@id";
                parId.SqlDbType = SqlDbType.Int;
                parId.Value = Entrada.IdEntrada;
                SqlCmd.Parameters.Add(parId);

               

                SqlParameter ParCorrelativo = new SqlParameter();
                ParCorrelativo.ParameterName = "@correlativo";
                ParCorrelativo.SqlDbType = SqlDbType.VarChar;
                ParCorrelativo.Size = 50;
                ParCorrelativo.Value = Entrada.Correlativo;
                SqlCmd.Parameters.Add(ParCorrelativo);

               

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

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("detalhe_entrada"); //alterado 24/03
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_entrada";
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
            DataTable DtResultado = new DataTable("entrada"); //alterado
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_entrada_data";
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

        public DataTable MostrarDivida(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("parcelas");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_a_pagar";
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





        public DataTable MostrarDetalhes(string TextoBuscar)
        {
            DataTable DtResultado = new DataTable("entrada"); //alterado
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_detalhes_entrada";
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
