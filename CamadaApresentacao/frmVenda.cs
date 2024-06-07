using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaNegocio;
using Microsoft.Reporting.WinForms;
using QuestPDF.Infrastructure;
using static System.Runtime.InteropServices.JavaScript.JSType;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using CamadaDados;
using static QuestPDF.Helpers.Colors;
namespace CamadaApresentacao
{
    public partial class frmVenda : Form
    {
        public int idfuncionario;
        private static frmVenda _Instance;
        private bool Novo;
        private DataTable dtDetalhe;
        private decimal Pagamento = 0;

        public static frmVenda GetInstancia()
        {
            if (_Instance == null)
            {
                _Instance = new frmVenda();

            }
            return _Instance;
        }

        public frmVenda()
        {
            InitializeComponent();
            this.txtIdCliente.Enabled = false;
            this.txtCliente.Enabled = false;
            this.txtIdProduto.Enabled = false;
            this.txtProduto.Enabled = false;
        }


        private void MensagemOK(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Cómercio", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //mostra a mensagem de erro
        private void MensagemErro(string mensagem)
        {
            MessageBox.Show(mensagem, "Sistema Cómercio", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



        //limpar campo

        private void Limpar()
        {
            this.txtIdCliente.Text = string.Empty;
            this.txtCliente.Text = string.Empty;
            this.txtId.Text = string.Empty;
            this.txtSerie.Text = string.Empty;
            this.txtDesconto.Text = string.Empty;
            this.txtPrecoCompra.Text = string.Empty;
            this.txtPrecoVenda.Text = string.Empty;
            this.txtImposto.Text = string.Empty;
            this.txtQuantidade.Text = string.Empty;
            this.txtEstoqueAtual.Text = string.Empty;

            this.txtProduto.Text = string.Empty;
            this.txtIdProduto.Text = string.Empty;

            this.txtCorrelativo.Text = string.Empty;
            this.lblTotal.Text = "0.0";

            this.CriarTabela();
        }

        //habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txtIdCliente.ReadOnly = !valor;
            this.txtCliente.ReadOnly = !valor;
            this.txtId.ReadOnly = !valor;
            this.txtSerie.ReadOnly = !valor;
            this.txtPrecoCompra.ReadOnly = !valor;
            this.txtPrecoVenda.ReadOnly = !valor;
            this.txtImposto.ReadOnly = !valor;
            this.txtQuantidade.ReadOnly = !valor;

            this.txtDesconto.ReadOnly = !valor;
            this.txtEstoqueAtual.ReadOnly = !valor;

            this.dtDataPedido.Enabled = valor;
            this.dtData.Enabled = valor;
            this.cbComprovante.Enabled = valor;
            this.txtCorrelativo.Enabled = valor;
            this.btnProduto.Enabled = valor;
            this.btnFornecedor.Enabled = valor;

            this.btnLimpar.Enabled = valor;
            this.btnCarregar.Enabled = valor;
        }

        //habilitar o botão
        private void botoes()
        {
            if (this.Novo == true)
            {
                this.Habilitar(true);
                this.btnNovo.Enabled = false;
                this.btnFornecedor.Enabled = true;
                this.btnSalvar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnProduto.Enabled = true;
                this.btnBuscar.Enabled = false;
            }
            else
            {
                this.Habilitar(false);
                this.btnNovo.Enabled = true;
                this.btnFornecedor.Enabled = false;
                this.btnSalvar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnProduto.Enabled = false;
                this.btnBuscar.Enabled = true;
            }

        }

        // oculta as colunas
        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;



        }

        //mostrar no data grid
        private void Mostrar()
        {
            this.dataLista.DataSource = NVenda.Mostrar();
            this.ocultarColunas();

            //associa e converte em string
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        //BUSCAR pela data
        private void BuscarData()
        {
            this.dataLista.DataSource = NVenda.BuscarData(this.dtInicial.Value.ToString("yyyy/MM/dd"), this.dtFinal.Value.ToString("yyyy/MM/dd"));

            this.ocultarColunas();

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);

        }


        private void MostrarDetalheEntrada()
        {
            this.DataListaDetalhes.DataSource = NVenda.MostrarDetalhes(this.txtId.Text);



        }


        public void setCliente(string idcliente, string nome)
        {
            this.txtIdCliente.Text = idcliente;
            this.txtCliente.Text = nome;
        }

        public void setProduto(string idproduto, string nome, decimal preco_compra, decimal preco_venda, int estoque, DateTime data_vencimento)    //mudança
        {
            this.txtIdProduto.Text = idproduto;
            this.txtProduto.Text = nome;
            this.txtPrecoCompra.Text = Convert.ToString(preco_compra);
            this.txtPrecoVenda.Text = Convert.ToString(preco_venda);
            this.txtEstoqueAtual.Text = Convert.ToString(estoque);
            this.dtDataPedido.Text = Convert.ToString(data_vencimento);
        }

        private void frmVenda_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();

            this.CriarTabela();
            this.cbComprovante.SelectedIndex = 0;
            this.txtParcelas.Text = "1";
            this.txtParcelas.Enabled = false;
        }

        private void frmVenda_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmBuscarCliente frm = new frmBuscarCliente();
            frm.Show();

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Novo = true;

            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtSerie.Focus();
            this.txtImposto.Text = "0";
            this.txtDesconto.Text = "0";
        }

        private void btnProduto_Click(object sender, EventArgs e)
        {
            frmBuscarProdutoV frm = new frmBuscarProdutoV();
            frm.Show();
        }

        private void CriarTabela()
        {
            this.dtDetalhe = new DataTable("Detalhe");
            this.dtDetalhe.Columns.Add("iddetalhe_entrada", System.Type.GetType("System.Int32"));
            this.dtDetalhe.Columns.Add("produto", System.Type.GetType("System.String"));
            this.dtDetalhe.Columns.Add("quantidade", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("preco_venda", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("desconto", System.Type.GetType("System.Decimal"));

            this.dtDetalhe.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("imposto", System.Type.GetType("System.Decimal"));

            this.DataListaDetalhes.DataSource = this.dtDetalhe;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Novo = false;

            this.botoes();
            this.Habilitar(false);
            this.Limpar();
            Pagamento = 0;
            this.TotalPagar.Text = Convert.ToString(Pagamento);
            this.txtParcelas.Text = "1";
            this.txtParcelas.Enabled = false;

        }

        private void chkDeletar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDeletar.Checked)
            {
                this.dataLista.Columns[0].Visible = true;


            }
            else
            {
                this.dataLista.Columns[0].Visible = false;
            }
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                //marcar uma celula de gridview
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Deletar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("deletar registro", "Sistema Comércio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NVenda.Anular(Convert.ToInt32(Codigo));
                            if (Resp.Equals("Certo"))
                            {
                                this.MensagemOK("Registro deletado");

                            }
                            else
                            {
                                this.MensagemErro(Resp);
                            }
                        }
                    }
                    this.Mostrar();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idvenda"].Value);
            this.txtCliente.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["cliente"].Value);
            this.dtData.Value = Convert.ToDateTime(this.dataLista.CurrentRow.Cells["data"].Value);
            this.cbComprovante.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["tipo_comprovante"].Value);
            this.txtSerie.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["serie"].Value);
            this.txtCorrelativo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["correlativo"].Value);
            this.txtImposto.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["imposto"].Value);
            this.TotalPagar.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Total"].Value);


            this.MostrarDetalheEntrada();
            this.TabControl1.SelectedIndex = 1;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.txtIdCliente.Text == string.Empty || this.txtIdProduto.Text == string.Empty || this.txtSerie.Text == string.Empty)
                {
                    MensagemErro("Prencha todos os campos");
                    errorIcone.SetError(txtIdProduto, "insira o cliente");
                    errorIcone.SetError(txtIdCliente, "insira o cliente");
                    errorIcone.SetError(txtSerie, "insira a série");
                }
                else
                {

                    if (this.Novo)
                    {
                        resp = NVenda.Inserir(Convert.ToInt32(this.txtIdCliente.Text), 1, dtData.Value, cbComprovante.Text, txtSerie.Text, txtCorrelativo.Text, Convert.ToDecimal(txtImposto.Text), Convert.ToInt32(txtParcelas.Text), dtDetalhe);
                        // MessageBox.Show("Chegou");
                    }

                    if (resp.Equals("Certo"))
                    {
                        if (this.Novo)
                        {
                            this.MensagemOK("Registro foi salvo");
                        }
                        else
                        {
                            this.MensagemOK("Registro foi editado");
                        }
                    }
                    else
                    {
                        this.MensagemErro(resp);
                    }
                    this.Novo = false;

                    this.botoes();
                    this.Limpar();
                    this.Mostrar();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace); //mensagem de detalhamento do erro
            }


            Pagamento = 0; //
            this.TotalPagar.Text = Convert.ToString(Pagamento); //
            this.txtParcelas.Text = "1";
            this.txtParcelas.Enabled = false;

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {

            try
            {
                string resp = "";
                if (this.txtIdProduto.Text == string.Empty || this.txtProduto.Text == string.Empty || this.txtQuantidade.Text == string.Empty)
                {
                    MensagemErro("Prencha todos os campos");
                    errorIcone.SetError(txtIdProduto, "insira o Produto");
                    errorIcone.SetError(txtProduto, "insira o Produto");
                    errorIcone.SetError(txtQuantidade, "insira a quantidade");
                }
                else
                {
                    bool salvar = true;
                    foreach (DataRow row in dtDetalhe.Rows)
                    {
                        if (Convert.ToInt32(row["iddetalhe_entrada"]) == Convert.ToInt32(this.txtIdProduto.Text))
                        {
                            salvar = false;
                            this.MensagemErro("O produto já esta adicionado");
                        }
                    }

                    if (salvar && Convert.ToInt32(txtQuantidade.Text) <= Convert.ToInt32(txtEstoqueAtual.Text))
                    {
                        decimal subTotal = Convert.ToDecimal((this.txtQuantidade.Text)) * Convert.ToDecimal(this.txtPrecoVenda.Text) - Convert.ToDecimal(this.txtDesconto.Text);
                        Pagamento = Pagamento + subTotal;
                        this.TotalPagar.Text = Pagamento.ToString("#0.00#");

                        DataRow row = this.dtDetalhe.NewRow();
                        row["iddetalhe_entrada"] = Convert.ToInt32(this.txtIdProduto.Text);
                        row["produto"] = this.txtProduto.Text;
                        row["quantidade"] = Convert.ToInt32(this.txtQuantidade.Text);
                        row["preco_venda"] = Convert.ToDecimal(this.txtPrecoVenda.Text);
                        row["desconto"] = Convert.ToDecimal(this.txtDesconto.Text); //

                        row["subtotal"] = subTotal;
                        row["imposto"] = Convert.ToDecimal(this.txtImposto.Text);
                        this.dtDetalhe.Rows.Add(row);
                        //criar função para limpar so o detalhe do produto

                    }
                    else
                    {
                        MensagemErro("A quantidade pedida ultrapassa o estoque do produto");
                    }

                }
                if (txtCorrelativo.SelectedIndex == 2)
                {
                    this.txtParcelas.Enabled = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace); //mensagem de detalhamento do erro
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            try
            {
                int indiceLinha = this.DataListaDetalhes.CurrentCell.RowIndex;
                DataRow row = this.dtDetalhe.Rows[indiceLinha];



                this.Pagamento = this.Pagamento - Convert.ToDecimal(row["subtotal"].ToString());
                this.TotalPagar.Text = Pagamento.ToString("#0.00#");
                this.dtDetalhe.Rows.Remove(row);

            }
            catch
            {
                MensagemErro("Selecione uma linha");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmParcelas frm = new frmParcelas();
            frm.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {


            string nome;
            string data;
            string comprovante;
            decimal total=0;
            decimal totalvenda;
            int entradas = 0;

            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);

                    page.Header()
                        .Text("Faeterj - Relatório de vendas:" )
                        .FontSize(40);
                    page.Content()
                    .Column(X => {
                        X.Item()
                            .Text("--------------------------------------------\n");

                        //imprime cada cliente separado
                        foreach (DataGridViewRow row in dataLista.Rows)
                        {
                            nome = Convert.ToString(row.Cells["Cliente"].Value);
                            data = Convert.ToString(row.Cells["data"].Value);
                            comprovante = Convert.ToString(row.Cells["tipo_comprovante"].Value);
                            totalvenda = Convert.ToDecimal(row.Cells["total"].Value);



                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                               
                                X.Item()
                          .Text("Nome do Cliente: " + nome);
                                X.Item()
                                .Text("Data da Venda: " + data);

                                X.Item()
                                .Text("Tipo Comprovante" + comprovante);

                                X.Item()
                                .Text("Total dessa venda: R$ " + totalvenda);

                                X.Item()
                                .Text("--------------------------------------------\n");

                                total += totalvenda;
                                entradas += 1;
                            }
                        }
                        X.Item()
                       .Text("Numero de vendas selecionadas = " + entradas);
                        X.Item()
                        .Text("Total: R$ " + total);

                    }
                    );


                });



            })
                .GeneratePdf(filePath: "C:\\Users\\rafae\\OneDrive\\Área de Trabalho/arquivoRelatorioVendas.pdf");

            MessageBox.Show("Relatório Gerado com Sucesso!");


           
        }

        private void button2_Click(object sender, EventArgs e)
        {



            decimal total =0;
            int entradas =0;
            DateTime data;
            string cliente;
            string comprovante;
            string correlativo;
            string nomeproduto;
            int quantidade;
            string valorunico;
            //pega a data da coluna marcada
            data = Convert.ToDateTime(this.dataLista.CurrentRow.Cells["data"].Value);
            
            QuestPDF.Settings.License = LicenseType.Community;
        
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);

                    page.Header()
                        .Text("Faeterj - Relatório do dia: "  + data.ToString("dd/MM/yyyy"))
                        .FontSize(40);
                    page.Content()
                    .Column(X => {
                        X.Item()
                            .Text("--------------------------------------------\n");

                        //imprime cada cliente separado
                        foreach (DataGridViewRow row in dataLista.Rows)
                        {
                            cliente = Convert.ToString(row.Cells["Cliente"].Value);
                            comprovante = Convert.ToString(row.Cells["tipo_comprovante"].Value);
                            correlativo = Convert.ToString(row.Cells["correlativo"].Value);
                            valorunico = Convert.ToString(row.Cells["Total"].Value);
                            nomeproduto = Convert.ToString(row.Cells["nome_produto"].Value);
                            quantidade = Convert.ToInt32(row.Cells["quantidade"].Value);



                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {
                               

                                X.Item()
                          .Text("Nome do Cliente: " + cliente);
                                X.Item()
                                .Text("Comprovante: " + comprovante);

                                X.Item()
                               .Text("Produto: " + nomeproduto + "  " + "Quantidade: " + quantidade) ;

                                X.Item()
                                .Text("Forma de pagamento: " + correlativo);

                                X.Item()
                                .Text("Total dessa venda: " + valorunico);

                                X.Item()
                                .Text("--------------------------------------------\n");
                                

                                total += Convert.ToDecimal(row.Cells[9].Value);
                                entradas += 1;
                            }

                        }


                        
                        X.Item()
                       .Text("Total de vendas do dia: " + entradas);
                        X.Item()
                        .Text("Total: R$ " + total) ;

                    }
                    );


                });



            })
                .GeneratePdf(filePath: "C:\\Users\\rafae\\OneDrive\\Área de Trabalho/arquivoRelatoriodiário.pdf");

            MessageBox.Show("Relatório Gerado com Sucesso!");


        }
    }
}
