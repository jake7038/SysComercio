using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CamadaDados;

namespace CamadaNegocio
{
    public class NVenda
    {

        public static string Inserir(int idcliente, int idfuncionario, DateTime data, string tipo_comprovante, string serie, string correlativo, decimal imposto, int parcela, DataTable dtDetalhes)
        {
            DVenda Obj = new DVenda();
            Obj.IdFuncionario = idfuncionario;
            Obj.IdCliente = idcliente;
            Obj.Data = data;
            Obj.Tipo_Comprovante = tipo_comprovante;
            Obj.Serie = serie;
            Obj.Correlativo = correlativo;
            Obj.Imposto = imposto;
            Obj.Parcela = parcela;
           

            List<DDetalhe_Venda> detalhes = new List<DDetalhe_Venda>(); //29

            foreach (DataRow row in dtDetalhes.Rows)
            {
                DDetalhe_Venda detalhe = new DDetalhe_Venda();
                
                detalhe.IdDetalhe_Entrada = Convert.ToInt32(row["iddetalhe_entrada"].ToString());
                detalhe.Quantidade = Convert.ToInt32(row["quantidade"].ToString());
                detalhe.Preco_Venda = Convert.ToDecimal(row["preco_venda"].ToString());
                detalhe.Desconto = Convert.ToDecimal(row["desconto"].ToString());//
                
                detalhes.Add(detalhe);
            }
            return Obj.Inserir(Obj, detalhes);
        }

        // Excluir
        public static string Anular(int id)
        {
            DVenda Obj = new DVenda();
            Obj.IdVenda = id;
            return Obj.Excluir(Obj);

        }
        //mostrar texto
        public static DataTable Mostrar()
        {

            return new DVenda().Mostrar();
        }

        //Buscar pela data
        public static DataTable BuscarData(string textobuscar, string textobuscar2)
        {
            DVenda Obj = new DVenda();


            return Obj.BuscarData(textobuscar, textobuscar2);
        }

        public static DataTable MostrarParcela(string textobuscar)
        {
            DVenda Obj = new DVenda();


            return Obj.MostrarParcela(textobuscar);
        }

        public static DataTable MostrarDetalhes(string textobuscar)
        {
            DVenda Obj = new DVenda();


            return Obj.MostrarDetalhes(textobuscar);
        }

        public static DataTable MostrarProduto_Venda_Nome(string textobuscar)
        {
            DVenda Obj = new DVenda();


            return Obj.MostrarProduto_Venda_Nome(textobuscar);
        }

        public static DataTable MostrarProduto_Venda_codigo(string textobuscar)
        {
            DVenda Obj = new DVenda();


            return Obj.MostrarProduto_Venda_Codigo(textobuscar);
        }
    }
}
