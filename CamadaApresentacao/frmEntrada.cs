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

namespace CamadaApresentacao
{
    public partial class frmEntrada : Form
    {
        public int idfuncionario;
        private static frmEntrada _Instance;
        private bool Novo;
        private DataTable dtDetalhe;
        private decimal totalPago = 0;
        public static frmEntrada GetInstancia()
        {
            if (_Instance == null)
            {
                _Instance = new frmEntrada();

            }
            return _Instance;
        }

        public frmEntrada()
        {
            InitializeComponent();

            this.txtIdFornecedor.Enabled = false;
            this.txtFornecedor.Enabled = false;
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
            this.txtIdFornecedor.Text = string.Empty;
            this.txtFornecedor.Text = string.Empty;
            this.txtId.Text = string.Empty;
            this.txtSerie.Text = string.Empty;
            this.txtProduto.Text = string.Empty; //
            this.txtIdProduto.Text = string.Empty;
            this.txtPrecoCompra.Text = string.Empty;
            this.txtPrecoVenda.Text = string.Empty;
            this.txtImposto.Text = string.Empty;
            this.txtEstoqueInicial.Text = string.Empty;

            this.cbCorrelativo.Text = string.Empty;
            this.lblTotal.Text = "0.0";

            this.CriarTabela();
        }

        //habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txtIdFornecedor.ReadOnly = !valor;
            this.txtFornecedor.ReadOnly = !valor;
            this.txtId.ReadOnly = !valor;
            this.txtSerie.ReadOnly = !valor;
            this.txtPrecoCompra.ReadOnly = !valor;
            this.txtPrecoVenda.ReadOnly = !valor;
            this.txtImposto.ReadOnly = !valor;
            this.txtEstoqueInicial.ReadOnly = !valor;
            this.cbCorrelativo.Enabled = valor;

            this.dtDataValidade.Enabled = valor;
            this.dtDataPedido.Enabled = valor;
            this.dtData.Enabled = valor;
            this.cbComprovante.Enabled = valor;
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
            this.dataLista.DataSource = NEntrada.Mostrar();
            this.ocultarColunas();

            //associa e converte em string
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        //BUSCAR pela data
        private void BuscarData()
        {
            this.dataLista.DataSource = NEntrada.BuscarData(this.dtInicial.Value.ToString("yyyy/MM/dd"), this.dtFinal.Value.ToString("yyyy/MM/dd"));

            this.ocultarColunas();

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);

        }


        private void MostrarDetalheEntrada()
        {
            this.DataListaDetalhes.DataSource = NEntrada.Mostrar(this.txtId.Text);



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmEntrada_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();

            this.CriarTabela();
            this.cbComprovante.SelectedIndex = 0;
        }

        private void frmEntrada_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instance = null;
        }
        public void setFornecedor(string idfornecedor, string num_documento)
        {
            this.txtIdFornecedor.Text = idfornecedor;
            this.txtFornecedor.Text = num_documento;
        }

        public void setProduto(string idproduto, string nome)
        {
            this.txtIdProduto.Text = idproduto;
            this.txtProduto.Text = nome;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmVerProdutoEntrada frm = new frmVerProdutoEntrada();

            frm.Show();
        }

        private void btnFornecedor_Click(object sender, EventArgs e)
        {
            frmVerFornecedorEntrada frm = new frmVerFornecedorEntrada();

            frm.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarData();
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult Opcao;
                Opcao = MessageBox.Show("Anular registro", "Sistema Comércio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NEntrada.Anular(Convert.ToInt32(Codigo));
                            if (Resp.Equals("Certo"))
                            {
                                this.MensagemOK("Registro anulado");

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

        //segundo datatable
        private void CriarTabela()
        {
            this.dtDetalhe = new DataTable("Detalhe");
            this.dtDetalhe.Columns.Add("idproduto", System.Type.GetType("System.Int32"));
            this.dtDetalhe.Columns.Add("produto", System.Type.GetType("System.String"));
            this.dtDetalhe.Columns.Add("preco_compra", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("preco_venda", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("estoque_inicial", System.Type.GetType("System.Int32"));
            this.dtDetalhe.Columns.Add("estoque_atual", System.Type.GetType("System.Int32"));
            this.dtDetalhe.Columns.Add("data_producao", System.Type.GetType("System.DateTime"));
            this.dtDetalhe.Columns.Add("data_vencimento", System.Type.GetType("System.DateTime"));
            this.dtDetalhe.Columns.Add("subtotal", System.Type.GetType("System.Decimal"));
            this.dtDetalhe.Columns.Add("imposto", System.Type.GetType("System.Decimal"));

            this.DataListaDetalhes.DataSource = this.dtDetalhe;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Novo = true;

            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtSerie.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Novo = false;

            this.botoes();
            this.Habilitar(false);
            this.Limpar();
            totalPago = 0; //
            this.TotalPagar.Text = Convert.ToString(totalPago); //
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.txtIdFornecedor.Text == string.Empty || this.txtIdProduto.Text == string.Empty || this.txtSerie.Text == string.Empty)
                {
                    MensagemErro("Prencha todos os campos");
                    errorIcone.SetError(txtIdProduto, "insira o Produto");
                    errorIcone.SetError(txtIdFornecedor, "insira o Produto");
                    errorIcone.SetError(txtSerie, "insira a série");
                }
                else
                {

                    if (this.Novo)
                    {
                        resp = NEntrada.Inserir(1, Convert.ToInt32(this.txtIdFornecedor.Text), dtData.Value, cbComprovante.Text, txtSerie.Text, cbCorrelativo.Text, Convert.ToDecimal(txtImposto.Text), "EMITIDO", dtDetalhe);
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

            totalPago = 0; //
            this.TotalPagar.Text = Convert.ToString(totalPago); //
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {

            try
            {
                string resp = "";
                if (this.txtIdProduto.Text == string.Empty || this.txtProduto.Text == string.Empty || this.txtEstoqueInicial.Text == string.Empty)
                {
                    MensagemErro("Prencha todos os campos");
                    errorIcone.SetError(txtIdProduto, "insira o Produto");
                    errorIcone.SetError(txtProduto, "insira o Produto");
                    errorIcone.SetError(txtEstoqueInicial, "insira o estoque");
                }
                else
                {
                    bool salvar = true;
                    foreach (DataRow row in dtDetalhe.Rows)
                    {
                        if (Convert.ToInt32(row["idproduto"]) == Convert.ToInt32(this.txtIdProduto.Text))
                        {
                            salvar = false;
                            this.MensagemErro("O produto já esta adicionado");
                        }
                    }

                    if (salvar)
                    {
                        decimal subTotal = Convert.ToDecimal((this.txtEstoqueInicial.Text)) * Convert.ToDecimal((this.txtPrecoCompra.Text));
                        totalPago = totalPago + subTotal;
                        this.TotalPagar.Text = totalPago.ToString("#0.00#");

                        DataRow row = this.dtDetalhe.NewRow();
                        row["idproduto"] = Convert.ToInt32(this.txtIdProduto.Text);
                        row["produto"] = this.txtProduto.Text;
                        row["preco_compra"] = Convert.ToDecimal(this.txtPrecoCompra.Text);
                        row["preco_venda"] = Convert.ToDecimal(this.txtPrecoVenda.Text);
                        row["estoque_inicial"] = Convert.ToInt32(this.txtEstoqueInicial.Text); //
                        row["data_producao"] = this.dtDataPedido.Value;
                        row["data_vencimento"] = this.dtDataValidade.Value;
                        row["subtotal"] = subTotal;
                        row["imposto"] = Convert.ToDecimal(this.txtImposto.Text);
                        this.dtDetalhe.Rows.Add(row);
                        //criar função para limpar so o detalhe do produto

                    }

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



                this.totalPago = this.totalPago - Convert.ToDecimal(row["subtotal"].ToString());
                this.TotalPagar.Text = totalPago.ToString("#0.00#");
                this.dtDetalhe.Rows.Remove(row);

            }
            catch
            {
                MensagemErro("Selecione uma linha");
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

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["identrada"].Value);
            this.txtFornecedor.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["fornecedor"].Value);
            this.dtData.Value = Convert.ToDateTime(this.dataLista.CurrentRow.Cells["data"].Value);
            this.cbComprovante.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["tipo_comprovante"].Value);
            this.txtSerie.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["serie"].Value);
            this.cbCorrelativo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["correlativo"].Value);
            this.txtImposto.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["imposto"].Value);
            this.TotalPagar.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Total"].Value);


            this.MostrarDetalheEntrada();
            this.TabControl1.SelectedIndex = 1;

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmContaPagar frm = new frmContaPagar();
            frm.Show();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmImprimirCompra frmim = new frmImprimirCompra();

            foreach (DataGridViewRow row in dataLista.Rows)
            {

                string funcionario;
                string fornecedor;
                string data;
                string tipo_comprovante;
                string correlativo;
                string total;
                

                frmim.im1 = Convert.ToString(this.dataLista.CurrentRow.Cells["Funcionario"].Value);
                frmim.im2 = Convert.ToString(this.dataLista.CurrentRow.Cells["Fornecedor"].Value);
                frmim.im3 = Convert.ToString(this.dataLista.CurrentRow.Cells["data"].Value);
                frmim.im4 = Convert.ToString(this.dataLista.CurrentRow.Cells["tipo_comprovante"].Value);
                frmim.im5 = Convert.ToString(this.dataLista.CurrentRow.Cells["correlativo"].Value);
                frmim.im6 = Convert.ToString(this.dataLista.CurrentRow.Cells["Total"].Value);
                frmim.setImprimirCompra(frmim.im1, frmim.im2, frmim.im3, frmim.im4 , frmim.im5, frmim.im6);


            }


            frmim.Show();
        }
    }
}
