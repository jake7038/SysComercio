using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
    public class NCliente
    {
        public static string Inserir(string nome, string cpf_cnpj, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep, string telefone, string email)
        {
            DCliente Obj = new CamadaDados.DCliente();
            Obj.Nome = nome; 
            Obj.Cpf_Cnpj = cpf_cnpj; 
            Obj.Logradouro = logradouro; 
            Obj.Numero = numero;
            Obj.Complemento = complemento; 
            Obj.Bairro = bairro; 
            Obj.Cidade = cidade;
            Obj.Estado = estado; 
            Obj.Cep = cep; 
            Obj.Telefone = telefone; 
            Obj.Email = email;  


            return Obj.Inserir(Obj);
        }
        //inicio editar
        public static string Editar(int id, string nome, string cpf_cnpj, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string cep, string telefone, string email)
        {
            DCliente Obj = new CamadaDados.DCliente();
            Obj.Id = id;
            Obj.Nome = nome;
            Obj.Cpf_Cnpj = cpf_cnpj;
            Obj.Logradouro = logradouro;
            Obj.Numero = numero;
            Obj.Complemento = complemento;
            Obj.Bairro = bairro;
            Obj.Cidade = cidade;
            Obj.Estado = estado;
            Obj.Cep = cep;
            Obj.Telefone = telefone;
            Obj.Email = email;
            return Obj.Editar(Obj);
        }

        public static string Excluir(int id)
        {
            DCliente Obj = new CamadaDados.DCliente();
            Obj.Id = id;
            return Obj.Excluir(Obj);

        }

        //mostrar texto
        public static DataTable Mostrar()
        {
            return new DCliente().Mostrar();
        }

        //Buscar nome 
        public static DataTable BuscarNome(string textobuscar)
        {
            DCliente Obj = new DCliente();
            Obj.TextoBuscar = textobuscar;

            return Obj.BuscarNome(Obj);
        }


    }
}
