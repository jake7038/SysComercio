using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DCliente
    {
        private int _Id;
        private string _Nome;
        private string _Cpf_Cnpj;
        private string _Logradouro;
        private string _Numero;
        private string _Complemento;
        private string _Bairro;
        private string _Cidade;
        private string _Estado;
        private string _Cep;
        private string _Telefone;
        private string _Email;

        private string _TextoBuscar;

        public int Id { get => _Id; set => _Id = value; }
        public string Nome { get => _Nome; set => _Nome = value; }
        public string Cpf_Cnpj { get => _Cpf_Cnpj; set => _Cpf_Cnpj = value; }
        public string Logradouro { get => _Logradouro; set => _Logradouro = value; }
        public string Numero { get => _Numero; set => _Numero = value; }
        public string Complemento { get => _Complemento; set => _Complemento = value; }
        public string Bairro { get => _Bairro; set => _Bairro = value; }
        public string Cidade { get => _Cidade; set => _Cidade = value; }
        public string Estado { get => _Estado; set => _Estado = value; }
        public string Cep { get => _Cep; set => _Cep = value; }
        public string Telefone { get => _Telefone; set => _Telefone = value; }
        public string Email { get => _Email; set => _Email = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }


        public DCliente()
        {

        }

        public DCliente(int id, string nome, string cpf_cnpj, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep, string telefone,string email, string textobuscar)
        {
            this.Id = id;
            this.Nome = nome;
            this.Cpf_Cnpj= cpf_cnpj;
            this.Logradouro= logradouro;
            this.Numero= numero;
            this.Complemento= complemento;
            this.Bairro= bairro;
            this.Cidade= cidade;
            this.Estado= estado;
            this.Cep= cep;
            this.Telefone= telefone;
            this.Email= email;
            this.TextoBuscar    = textobuscar;



        }

        public string Inserir(DCliente cliente)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spinserir_cliente";
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
                ParNome.Value = cliente.Nome;
                SqlCmd.Parameters.Add(ParNome);


                SqlParameter ParCpf_Cnpj = new SqlParameter();
                ParCpf_Cnpj.ParameterName = "@cpf_cnpj";
                ParCpf_Cnpj.SqlDbType = SqlDbType.VarChar;
                ParCpf_Cnpj.Size = 50;
                ParCpf_Cnpj.Value = cliente.Cpf_Cnpj;
                SqlCmd.Parameters.Add(ParCpf_Cnpj);

                SqlParameter ParLogradouro = new SqlParameter();
                ParLogradouro.ParameterName = "@logradouro";
                ParLogradouro.SqlDbType = SqlDbType.VarChar;
                ParLogradouro.Size = 50;
                ParLogradouro.Value = cliente.Logradouro;
                SqlCmd.Parameters.Add(ParLogradouro);

                SqlParameter ParNumero = new SqlParameter();
                ParNumero.ParameterName = "@numero";
                ParNumero.SqlDbType = SqlDbType.VarChar;
                ParNumero.Size = 50;
                ParNumero.Value = cliente.Numero;
                SqlCmd.Parameters.Add(ParNumero);

                SqlParameter ParComplemento = new SqlParameter();
                ParComplemento.ParameterName = "@complemento";
                ParComplemento.SqlDbType = SqlDbType.VarChar;
                ParComplemento.Size = 50;
                ParComplemento.Value = cliente.Complemento;
                SqlCmd.Parameters.Add(ParComplemento);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = cliente.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 50;
                ParCidade.Value = cliente.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 50;
                ParEstado.Value = cliente.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParCep = new SqlParameter();
                ParCep.ParameterName = "@cep";
                ParCep.SqlDbType = SqlDbType.VarChar;
                ParCep.Size = 50;
                ParCep.Value = cliente.Cep;
                SqlCmd.Parameters.Add(ParCep);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 50;
                ParTelefone.Value = cliente.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);


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

        public string Editar(DCliente cliente)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "speditar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = cliente.Id; //alterado e concertado
                SqlCmd.Parameters.Add(ParId);




                SqlParameter ParNome = new SqlParameter();
                ParNome.ParameterName = "@nome";
                ParNome.SqlDbType = SqlDbType.VarChar;
                ParNome.Size = 50;
                ParNome.Value = cliente.Nome;
                SqlCmd.Parameters.Add(ParNome);


                SqlParameter ParCpf_Cnpj = new SqlParameter();
                ParCpf_Cnpj.ParameterName = "@cpf_cnpj";
                ParCpf_Cnpj.SqlDbType = SqlDbType.VarChar;
                ParCpf_Cnpj.Size = 50;
                ParCpf_Cnpj.Value = cliente.Cpf_Cnpj;
                SqlCmd.Parameters.Add(ParCpf_Cnpj);

                SqlParameter ParLogradouro = new SqlParameter();
                ParLogradouro.ParameterName = "@logradouro";
                ParLogradouro.SqlDbType = SqlDbType.VarChar;
                ParLogradouro.Size = 50;
                ParLogradouro.Value = cliente.Logradouro;
                SqlCmd.Parameters.Add(ParLogradouro);

                SqlParameter ParNumero = new SqlParameter();
                ParNumero.ParameterName = "@numero";
                ParNumero.SqlDbType = SqlDbType.VarChar;
                ParNumero.Size = 50;
                ParNumero.Value = cliente.Numero;
                SqlCmd.Parameters.Add(ParNumero);

                SqlParameter ParComplemento = new SqlParameter();
                ParComplemento.ParameterName = "@complemento";
                ParComplemento.SqlDbType = SqlDbType.VarChar;
                ParComplemento.Size = 50;
                ParComplemento.Value = cliente.Complemento;
                SqlCmd.Parameters.Add(ParComplemento);

                SqlParameter ParBairro = new SqlParameter();
                ParBairro.ParameterName = "@bairro";
                ParBairro.SqlDbType = SqlDbType.VarChar;
                ParBairro.Size = 50;
                ParBairro.Value = cliente.Bairro;
                SqlCmd.Parameters.Add(ParBairro);

                SqlParameter ParCidade = new SqlParameter();
                ParCidade.ParameterName = "@cidade";
                ParCidade.SqlDbType = SqlDbType.VarChar;
                ParCidade.Size = 50;
                ParCidade.Value = cliente.Cidade;
                SqlCmd.Parameters.Add(ParCidade);

                SqlParameter ParEstado = new SqlParameter();
                ParEstado.ParameterName = "@estado";
                ParEstado.SqlDbType = SqlDbType.VarChar;
                ParEstado.Size = 50;
                ParEstado.Value = cliente.Estado;
                SqlCmd.Parameters.Add(ParEstado);

                SqlParameter ParCep = new SqlParameter();
                ParCep.ParameterName = "@cep";
                ParCep.SqlDbType = SqlDbType.VarChar;
                ParCep.Size = 50;
                ParCep.Value = cliente.Cep;
                SqlCmd.Parameters.Add(ParCep);

                SqlParameter ParTelefone = new SqlParameter();
                ParTelefone.ParameterName = "@telefone";
                ParTelefone.SqlDbType = SqlDbType.VarChar;
                ParTelefone.Size = 50;
                ParTelefone.Value = cliente.Telefone;
                SqlCmd.Parameters.Add(ParTelefone);

                SqlParameter ParEmail = new SqlParameter();
                ParEmail.ParameterName = "@email";
                ParEmail.SqlDbType = SqlDbType.VarChar;
                ParEmail.Size = 50;
                ParEmail.Value = cliente.Email;
                SqlCmd.Parameters.Add(ParEmail);

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

        public string Excluir(DCliente cliente)
        {
            string resp = "";
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCon.Open();
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spdeletar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@id";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Value = cliente.Id;
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
            DataTable DtResultado = new DataTable("cliente");
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spmostrar_cliente";
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
        public DataTable BuscarNome(DCliente Cliente)
        {
            DataTable DtResultado = new DataTable("cliente"); //alterado
            SqlConnection SqlCon = new SqlConnection();
            try
            {
                SqlCon.ConnectionString = Conexao.Cn;
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;
                SqlCmd.CommandText = "spbuscar_cliente";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParTextoBuscar = new SqlParameter();
                ParTextoBuscar.ParameterName = "@textobuscar";
                ParTextoBuscar.SqlDbType = SqlDbType.VarChar;
                ParTextoBuscar.Size = 50;
                ParTextoBuscar.Value = Cliente.TextoBuscar;
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
