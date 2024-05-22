using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
    public class NProduto
    {
        // Inserir
        public static string Inserir(string codigo, string nome, string descricao, byte[] imagem, int idcategoria, int idapresentacao)
        {
            DProduto Obj = new CamadaDados.DProduto();
            Obj.Codigo = codigo;
            Obj.Nome = nome;
            Obj.Descricao = descricao;
            Obj.Imagem = imagem;
            Obj.IdCategoria = idcategoria;
            Obj.IdApresentacao= idapresentacao;
            return Obj.Inserir(Obj);
        }
        // Editar
        public static string Editar(int id,string codigo, string nome, string descricao, byte[] imagem, int idcategoria, int idapresentacao)
        {
            DProduto Obj = new CamadaDados.DProduto();
            Obj.Id = id;
            Obj.Codigo = codigo; //alterado
            Obj.Nome = nome;
            Obj.Descricao = descricao;
            Obj.Imagem = imagem;
            Obj.IdCategoria = idcategoria;
            Obj.IdApresentacao = idapresentacao;
            return Obj.Editar(Obj);
        }
        // Excluir
        public static string Excluir(int id)
        {
            DProduto Obj = new CamadaDados.DProduto();
            Obj.Id = id;
            return Obj.Excluir(Obj);

        }
        //mostrar texto
        public static DataTable Mostrar()
        {
            return new DProduto().Mostrar();
        }

        //Buscar nome
        public static DataTable BuscarNome(string textobuscar)
        {
            DProduto Obj = new DProduto();
            Obj.TextoBuscar = textobuscar;

            return Obj.BuscarNome(Obj);
        }
    }
}
