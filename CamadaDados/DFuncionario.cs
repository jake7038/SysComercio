using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados

{
    public class DFuncionario
    {
        private int _Id;
        private string _Nome;
        private string _Sobrenome;
        private string _Sexo;
        private string _Num_Documento;
        private string _Endereco;
        private string _Telefone;
        private string _Email;
        private string _Acesso;
        private string _Usuario;
        private string _Senha;
        private string _TextoBuscar;

        public int Id { get => _Id; set => _Id = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Sobrenome { get => _Sobrenome; set => _Sobrenome = value; }
        public string Sexo { get => _Sexo; set => _Sexo = value; }
        public string Num_Documento { get => _Num_Documento; set => _Num_Documento = value; }
        public string Endereco { get => _Endereco; set => _Endereco = value; }
        public string Telefone { get => _Telefone; set => _Telefone = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string Acesso { get => _Acesso; set => _Acesso = value; }
        public string Usuario { get => _Usuario; set => _Usuario = value; }
        public string Senha { get => _Senha; set => _Senha = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }

       public DFuncionario()
        {

        }

       public DFuncionario(int id, string nome, string sobrenome, string sexo, string num_documento, string endereco, string telefone, string email, string acesso, string usuario, string senha, string textobuscar)
        {
            this.Id = id;
            this.Nome = nome;
            this.Sobrenome = sobrenome;
            this.Sexo = sexo;
            this.Num_Documento = num_documento;
            this.Endereco = endereco;
            this.Telefone = telefone;
            this.Email = email;
            this.Acesso = acesso;
            this.Usuario = usuario;
            this.Senha = senha;
            this.TextoBuscar = textobuscar;
        }

        public string Inserir(DFuncionario funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);



                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = funcionario.Nome;
                SqlCmd.Parameters.Add(ParNome);

            
               
                SqlParameter ParSobrenome = new SqlParameter();
                ParSobrenome.ParameterName = "@sobrenome";
                ParSobrenome.SqlDbType = SqlDbType.VarChar;
                ParSobrenome.Size = 50;
                ParSobrenome.Value = funcionario.Sobrenome;
                SqlCmd.Parameters.Add(ParSobrenome);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = funcionario.Sexo;
                SqlCmd.Parameters.Add(ParSexo);
               
                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@num_documento";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 50;
                ParNum_Documento.Value = funcionario.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);




                SqlParameter ParEndereco = new SqlParameter();
                ParEndereco.ParameterName = "@endereco";
                ParEndereco.SqlDbType = SqlDbType.VarChar;
                ParEndereco.Size = 50;
                ParEndereco.Value = funcionario.Endereco;
                SqlCmd.Parameters.Add(ParEndereco);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 50;
                ParTelefone.Value = funcionario.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = funcionario.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParAcesso = new SqlParameter();
                ParAcesso.ParameterName = "@acesso";
                ParAcesso.SqlDbType = SqlDbType.VarChar;
                ParAcesso.Size = 50;
                ParAcesso.Value = funcionario.Acesso;
                SqlCmd.Parameters.Add(ParAcesso);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = funcionario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);
               
                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 50;
                ParSenha.Value = funcionario.Senha;
                SqlCmd.Parameters.Add(ParSenha);


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

        public string Editar(DFuncionario funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = funcionario.Id; //alterado e concertado
                SqlCmd.Parameters.Add(ParId);




                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = funcionario.Nome;
                SqlCmd.Parameters.Add(ParNome);



                SqlParameter ParSobrenome = new SqlParameter();
                ParSobrenome.ParameterName = "@sobrenome";
                ParSobrenome.SqlDbType = SqlDbType.VarChar;
                ParSobrenome.Size = 50;
                ParSobrenome.Value = funcionario.Sobrenome;
                SqlCmd.Parameters.Add(ParSobrenome);

                SqlParameter ParSexo = new SqlParameter();
                ParSexo.ParameterName = "@sexo";
                ParSexo.SqlDbType = SqlDbType.VarChar;
                ParSexo.Size = 1;
                ParSexo.Value = funcionario.Sexo;
                SqlCmd.Parameters.Add(ParSexo);

                SqlParameter ParNum_Documento = new SqlParameter();
                ParNum_Documento.ParameterName = "@num_documento";
                ParNum_Documento.SqlDbType = SqlDbType.VarChar;
                ParNum_Documento.Size = 50;
                ParNum_Documento.Value = funcionario.Num_Documento;
                SqlCmd.Parameters.Add(ParNum_Documento);




                SqlParameter ParEndereco = new SqlParameter();
                ParEndereco.ParameterName = "@endereco";
                ParEndereco.SqlDbType = SqlDbType.VarChar;
                ParEndereco.Size = 50;
                ParEndereco.Value = funcionario.Endereco;
                SqlCmd.Parameters.Add(ParEndereco);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 50;
                ParTelefone.Value = funcionario.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = funcionario.Email;
                SqlCmd.Parameters.Add(ParEmail);

                SqlParameter ParAcesso = new SqlParameter();
                ParAcesso.ParameterName = "@acesso";
                ParAcesso.SqlDbType = SqlDbType.VarChar;
                ParAcesso.Size = 50;
                ParAcesso.Value = funcionario.Acesso;
                SqlCmd.Parameters.Add(ParAcesso);

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = funcionario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 50;
                ParSenha.Value = funcionario.Senha;
                SqlCmd.Parameters.Add(ParSenha);

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

        public string Excluir(DFuncionario funcionario)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = funcionario.Id;
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
            DataTable DtResultado = new DataTable("funcionario");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_funcionario";
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
        //buscar nome 
        public DataTable BuscarNome(DFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("funcionario"); //alterado
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_funcionario";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Funcionario.TextoBuscar;
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

        //procedimento do login
        public DataTable Login(DFuncionario Funcionario)
        {
            DataTable DtResultado = new DataTable("funcionario"); //alterado
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "splogin";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParUsuario = new SqlParameter();
                ParUsuario.ParameterName = "@usuario";
                ParUsuario.SqlDbType = SqlDbType.VarChar;
                ParUsuario.Size = 50;
                ParUsuario.Value = Funcionario.Usuario;
                SqlCmd.Parameters.Add(ParUsuario);

                SqlParameter ParSenha = new SqlParameter();
                ParSenha.ParameterName = "@senha";
                ParSenha.SqlDbType = SqlDbType.VarChar;
                ParSenha.Size = 50;
                ParSenha.Value = Funcionario.Senha;
                SqlCmd.Parameters.Add(ParSenha);



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
