using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
    public class NFornecedor
    {
        // Inserir
        public static string Inserir(string empresa, string setor_comercial, string telefone, string num_documento, string email, string endereco)
        {
            DFornecedor Obj = new CamadaDados.DFornecedor();
            Obj.Empresa = empresa;
            Obj.Setor_Comercial = setor_comercial;
            Obj.Telefone = telefone;
            Obj.Num_Documento = num_documento;
            Obj.Email = email;
            Obj.Endereco = endereco;   

           
            return Obj.Inserir(Obj);
        }
        // Editar
        public static string Editar(int id, string empresa, string setor_comercial, string telefone, string num_documento, string email, string endereco)
        {
            DFornecedor Obj = new CamadaDados.DFornecedor();
            Obj.Id = id;
            Obj.Empresa = empresa;
            Obj.Setor_Comercial = setor_comercial;
            Obj.Telefone = telefone;
            Obj.Num_Documento = num_documento;
            Obj.Email = email;
            Obj.Endereco = endereco;
            return Obj.Editar(Obj);
        }
        // Excluir
        public static string Excluir(int id)
        {
            DFornecedor Obj = new CamadaDados.DFornecedor();
            Obj.Id = id;
            return Obj.Excluir(Obj);

        }
        //mostrar texto
        public static DataTable Mostrar()
        {
            return new DFornecedor().Mostrar();
        }

        //Buscar nome empresa
        public static DataTable BuscarNome(string textobuscar)
        {
            DFornecedor Obj = new DFornecedor();
            Obj.TextoBuscar = textobuscar;

            return Obj.BuscarNome(Obj);
        }
        //Buscar nome empresa
        public static DataTable BuscarDocumento(string textobuscar)
        {
            DFornecedor Obj = new DFornecedor();
            Obj.TextoBuscar = textobuscar;

            return Obj.BuscarDocumento(Obj);
        }

    }
}
