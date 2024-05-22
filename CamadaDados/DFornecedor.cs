using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DFornecedor
    {
        private int _Id;
        private string _Empresa;
        private string _Setor_Comercial;
        private string _telefone;
        private string _Num_Documento;
        private string _Email;
        private string _Endereco;
        private string _TextoBuscar;

        public int Id { get => _Id; set => _Id = value; }
        public string Empresa { get => _Empresa; set => _Empresa = value; }
        public string Setor_Comercial { get => _Setor_Comercial; set => _Setor_Comercial = value; }
        public string Telefone { get => _telefone; set => _telefone = value; }
        public string Num_Documento { get => _Num_Documento; set => _Num_Documento = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Endereco { get => _Endereco; set => _Endereco = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

        public DFornecedor()
        {

        }

        public DFornecedor(int id, string empresa, string setor_comercial, string telefone, string num_documento, string email, string endereco, string textobuscar)
        {
            this.Id = id;
            this.Empresa = empresa;
            this.Setor_Comercial=setor_comercial;
            this.Telefone = telefone;
            this.Num_Documento = num_documento;
            this.Email = email;
            this.Endereco = endereco;
            this.TextoBuscar = textobuscar;
        }
        // inserir
        public string Inserir(DFornecedor fornecedor)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_fornecedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);

               

                SqlParameter ParEmpresa = new SqlParameter();
                ParEmpresa.ParameterName = "@empresa";
                ParEmpresa.SqlDbType = SqlDbType.VarChar;
                ParEmpresa.Size = 50;
                ParEmpresa.Value = fornecedor.Empresa;
                SqlCmd.Parameters.Add(ParEmpresa);

                SqlParameter ParSetor_Comercial = new SqlParameter();
                ParSetor_Comercial.ParameterName = "@setor_comercial";
                ParSetor_Comercial.SqlDbType = SqlDbType.VarChar;
                ParSetor_Comercial.Size = 50;
                ParSetor_Comercial.Value = fornecedor.Setor_Comercial;
                SqlCmd.Parameters.Add(ParSetor_Comercial);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 50;
                ParTelefone.Value = fornecedor.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@num_documento";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 50;
                ParNum_Documento.Value = fornecedor.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = fornecedor.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 50;
                parEndereco.Value = fornecedor.Endereco;
                SqlCmd.Parameters.Add(parEndereco);

               


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
        //editar

        public string Editar(DFornecedor fornecedor)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_fornecedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = fornecedor.Id; //alterado e concertado
                SqlCmd.Parameters.Add(ParId);



                SqlParameter ParEmpresa = new SqlParameter();
                ParEmpresa.ParameterName = "@empresa";
                ParEmpresa.SqlDbType = SqlDbType.VarChar;
                ParEmpresa.Size = 50;
                ParEmpresa.Value = fornecedor.Empresa;
                SqlCmd.Parameters.Add(ParEmpresa);

                SqlParameter ParSetor_Comercial = new SqlParameter();
                ParSetor_Comercial.ParameterName = "@setor_comercial";
                ParSetor_Comercial.SqlDbType = SqlDbType.VarChar;
                ParSetor_Comercial.Size = 50;
                ParSetor_Comercial.Value = fornecedor.Setor_Comercial;
                SqlCmd.Parameters.Add(ParSetor_Comercial);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 50;
                ParTelefone.Value = fornecedor.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@num_documento";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 50;
                ParNum_Documento.Value = fornecedor.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = fornecedor.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter parEndereco = new SqlParameter();
                parEndereco.ParameterName = "@endereco";
                parEndereco.SqlDbType = SqlDbType.VarChar;
                parEndereco.Size = 50;
                parEndereco.Value = fornecedor.Endereco;
                SqlCmd.Parameters.Add(parEndereco);

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
            return resp; //
        }

        public string Excluir(DFornecedor Fornecedor)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_fornecedor";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = Fornecedor.Id;
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

        public DataTable Mostrar()
        {
            DataTable DtResultado = new DataTable("fornecedor");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_fornecedor";
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
        //buscar nome empresa
        public DataTable BuscarNome(DFornecedor Fornecedor)
        {
            DataTable DtResultado = new DataTable("fornecedor"); //alterado
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_fornecedor_empresa";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Fornecedor.TextoBuscar;
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

        //buscar documento da empresa
        public DataTable BuscarDocumento(DFornecedor Fornecedor)
        {
            DataTable DtResultado = new DataTable("fornecedor"); //alterado
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_fornecedor_documento";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Fornecedor.TextoBuscar;
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
