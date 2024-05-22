using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace CamadaDados
{
    public class DDetalhe_Entrada
    {
        private int _IdDetalhe_Entrada;
        private int _IdProduto;
        private int _IdEntrada;
        private decimal _PrecoCompra;
        private decimal _PrecoVenda;
        private int _EstoqueInicial;
        private int _EstoqueAtual;
        private DateTime _DataProducao;
        private DateTime _DataVencimento;
        private string _TextoBuscar;
        private string _TextoBuscar2;

        public int IdDetalhe_Entrada { get => _IdDetalhe_Entrada; set => _IdDetalhe_Entrada = value; }
        public int IdProduto { get => _IdProduto; set => _IdProduto = value; }
        public int IdEntrada { get => _IdEntrada; set => _IdEntrada = value; }
        public decimal PrecoCompra { get => _PrecoCompra; set => _PrecoCompra = value; }
        public decimal PrecoVenda { get => _PrecoVenda; set => _PrecoVenda = value; }
        public int EstoqueInicial { get => _EstoqueInicial; set => _EstoqueInicial = value; }
        public int EstoqueAtual { get => _EstoqueAtual; set => _EstoqueAtual = value; }
        public DateTime DataProducao { get => _DataProducao; set => _DataProducao = value; }
        public DateTime DataVencimento { get => _DataVencimento; set => _DataVencimento = value; }
        public string TextoBuscar { get => _TextoBuscar; set => _TextoBuscar = value; }
        public string TextoBuscar2 { get => _TextoBuscar2; set => _TextoBuscar2 = value; }



        public DDetalhe_Entrada()
        {

        }

        public DDetalhe_Entrada(int iddetalhe_entrada, int idproduto, int identrada, decimal precocompra, decimal precovenda
            , int estoqueinicial, int estoqueatual, DateTime dataproducao, DateTime datavencimento, string textobuscar, string textobuscar2)
        {
            this.IdDetalhe_Entrada = iddetalhe_entrada;
            this.IdProduto = idproduto;
            this.IdEntrada = identrada;
            this.PrecoCompra = precocompra;
            this.PrecoVenda = precovenda;
            this.EstoqueInicial = estoqueinicial;
            this.EstoqueAtual = estoqueatual;
            this.DataProducao = dataproducao;
            this.DataVencimento = datavencimento;   
            this.TextoBuscar = textobuscar;
            this.TextoBuscar2 = textobuscar2;        

        }

        public string Inserir(DDetalhe_Entrada Detalhe_Entrada, ref SqlConnection SqlCon, ref SqlTransaction SqlTra )
        {
            string resp = "";
           
            try
            {
               
                SqlCommand SqlCmd = new SqlCommand();
                SqlCmd.Connection = SqlCon;//
                SqlCmd.Transaction = SqlTra;
                SqlCmd.CommandText = "sp_inserir_detalhe_entrada";
                SqlCmd.CommandType = CommandType.StoredProcedure;

                SqlParameter ParId = new SqlParameter();
                ParId.ParameterName = "@iddetalhe_entrada";
                ParId.SqlDbType = SqlDbType.Int;
                ParId.Direction = ParameterDirection.Output;
                SqlCmd.Parameters.Add(ParId);



                SqlParameter ParIdEntrada = new SqlParameter();
                ParIdEntrada.ParameterName = "@identrada";
                ParIdEntrada.SqlDbType = SqlDbType.Int; 
                
                ParIdEntrada.Value = Detalhe_Entrada.IdEntrada;
                SqlCmd.Parameters.Add(ParIdEntrada);



                SqlParameter ParIdProduto = new SqlParameter();
                ParIdProduto.ParameterName = "@idproduto";
                ParIdProduto.SqlDbType = SqlDbType.Int;
                ParIdProduto.Value = Detalhe_Entrada.IdProduto;
                SqlCmd.Parameters.Add(ParIdProduto);


                SqlParameter ParPrecoCompra = new SqlParameter();
                ParPrecoCompra.ParameterName = "@preco_compra";
                ParPrecoCompra.SqlDbType = SqlDbType.Money;
                ParPrecoCompra.Size = 40;
                ParPrecoCompra.Value = Detalhe_Entrada.PrecoCompra;
                SqlCmd.Parameters.Add(ParPrecoCompra);

                SqlParameter ParPrecoVenda = new SqlParameter();
                ParPrecoVenda.ParameterName = "@preco_venda";
                ParPrecoVenda.SqlDbType = SqlDbType.Money;
                ParPrecoVenda.Size = 40;
                ParPrecoVenda.Value = Detalhe_Entrada.PrecoVenda;
                SqlCmd.Parameters.Add(ParPrecoVenda);

                SqlParameter ParEstoqueInicial = new SqlParameter();
                ParEstoqueInicial.ParameterName = "@estoque_inicial";
                ParEstoqueInicial.SqlDbType = SqlDbType.Int;
                ParEstoqueInicial.Value = Detalhe_Entrada.EstoqueInicial;
                SqlCmd.Parameters.Add(ParEstoqueInicial);

                SqlParameter ParEstoqueAtual= new SqlParameter();
                ParEstoqueAtual.ParameterName = "@estoque_atual";
                ParEstoqueAtual.SqlDbType = SqlDbType.Int;
                ParEstoqueAtual.Value = Detalhe_Entrada.EstoqueAtual;
                SqlCmd.Parameters.Add(ParEstoqueAtual);

                SqlParameter ParDataProducao = new SqlParameter();
                ParDataProducao.ParameterName = "@data_producao";
                ParDataProducao.SqlDbType = SqlDbType.Date;
                ParDataProducao.Value = Detalhe_Entrada.DataProducao;
                SqlCmd.Parameters.Add(ParDataProducao);

                SqlParameter ParDataVencimento = new SqlParameter();
                ParDataVencimento.ParameterName = "@data_vencimento";
                ParDataVencimento.SqlDbType = SqlDbType.Date;
                ParDataVencimento.Value = Detalhe_Entrada.DataVencimento;
                SqlCmd.Parameters.Add(ParDataVencimento);


                resp = SqlCmd.ExecuteNonQuery() == 1 ? "Certo" : "Registro não foi salvo";

            }
            catch (Exception ex)
            {
                resp = ex.Message;
            }
            
            return resp;
        }



    }
}
