using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
    public class NEntrada
    {
        public static string Inserir(int idfuncionario, int idfornecedor, DateTime data, string tipo_comprovante, string serie, string correlativo, decimal imposto, string estado, DataTable dtDetalhes)
        {
            DEntrada Obj = new DEntrada();
            Obj.IdFuncionario = idfuncionario;
            Obj.IdFornecedor = idfornecedor;
            Obj.Data = data;
            Obj.TipoComprovante = tipo_comprovante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Imposto = imposto;
            Obj.Estado = estado;    
            
            List<DDetalhe_Entrada> detalhes = new List<DDetalhe_Entrada>();

            foreach(DataRow row in dtDetalhes.Rows)
            {
                DDetalhe_Entrada detalhe = new DDetalhe_Entrada();
                detalhe.IdProduto = Convert.ToInt32(row["idproduto"].ToString());
                detalhe.PrecoCompra = Convert.ToDecimal(row["preco_compra"].ToString());
                detalhe.PrecoVenda = Convert.ToDecimal(row["preco_venda"].ToString());
                detalhe.EstoqueInicial = Convert.ToInt32(row["estoque_inicial"].ToString());
                detalhe.EstoqueAtual = Convert.ToInt32(row["estoque_inicial"].ToString());//
                detalhe.DataProducao = Convert.ToDateTime(row["data_producao"].ToString());
                detalhe.DataVencimento = Convert.ToDateTime(row["data_vencimento"].ToString());
                detalhes.Add(detalhe);
            }
            return Obj.Inserir(Obj, detalhes);
        }

        // Excluir
        public static string Anular(int id)
        {
            DEntrada Obj = new CamadaDados.DEntrada();
            Obj.IdEntrada = id;
            return Obj.Anular(Obj);

        }
        //mostrar texto
        public static DataTable Mostrar()
        {
            
            return new DEntrada().Mostrar();
        }

        //Buscar pela data
        public static DataTable BuscarData(string textobuscar, string textobuscar2 )
        {
            DEntrada Obj = new DEntrada();
            

            return Obj.BuscarData(textobuscar,textobuscar2);
        }

        public static DataTable MostrarDivida(string textobuscar)
        {
            DEntrada Obj = new DEntrada();


            return Obj.MostrarDivida(textobuscar);
        }

        public static string EditarConta(int id, string correlativo)
        {
            DEntrada Obj = new CamadaDados.DEntrada();
            Obj.IdEntrada = id;
            Obj.Correlativo = correlativo; 
            return Obj.EditarConta(Obj);
        }

        public static DataTable Mostrar(string textobuscar)
        {
            DEntrada Obj = new DEntrada();


            return Obj.MostrarDetalhes(textobuscar);
        }
    }
}
