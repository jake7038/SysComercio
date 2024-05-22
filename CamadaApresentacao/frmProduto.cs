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
    public partial class frmProduto : Form
    {
        private bool eNovo = false;
        private bool eEditar = false;
        private static frmProduto _Instancia;

        //evitar abrir vários
        public static frmProduto GetInstancia()
        {
            if (_Instancia == null)
            {
                _Instancia = new frmProduto();

            }
            return _Instancia;
        }

        public void SetCategoria(string idCategoria, string Nome)
        {
            this.txtIdCategoria.Text = idCategoria;
            this.txtCategoria.Text = Nome;

        }

        public frmProduto()
        {
            InitializeComponent();
            this.ToolTip1.SetToolTip(this.txtNome, "Insira o nome do produto");
            this.ToolTip1.SetToolTip(this.pxImagem, "Insira uma imagem para o produto");
            this.ToolTip1.SetToolTip(this.cbApresentacao, "selecione a Apresentação do produto");
            this.ToolTip1.SetToolTip(this.txtCategoria, "selecione uma Categoria");
            this.txtIdCategoria.Enabled = false;
            this.txtCategoria.Enabled = false;
            this.pxImagem.Image = global::CamadaApresentacao.Properties.Resources.prodim;
            this.ComboApresentacao();
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
            this.txtNome.Text = string.Empty;
            this.txtId.Text = string.Empty;
            this.txtDescricao.Text = string.Empty;
            this.txtCodigo.Text = string.Empty;
            this.txtIdCategoria.Text = string.Empty;
            this.txtCategoria.Text = string.Empty;


        }

        //habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txtNome.ReadOnly = !valor;
            this.txtDescricao.ReadOnly = !valor;
            this.txtId.ReadOnly = !valor;
            this.txtCodigo.ReadOnly = !valor;
            this.cbApresentacao.Enabled = valor;
            this.btnBuscar.Enabled = valor;
            this.btnLimpar.Enabled = valor;
            this.btnCarregar.Enabled = valor;
        }

        //habilitar o botão
        private void botoes()
        {
            if (this.eNovo == true || this.eEditar == true)
            {
                this.Habilitar(true);
                this.btnNovo.Enabled = false;
                this.btnEditar.Enabled = false;
                this.btnSalvar.Enabled = true;
                this.btnCancelar.Enabled = true;
                this.btnCategoria.Enabled = true;

            }
            else
            {
                this.Habilitar(false);
                this.btnNovo.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnSalvar.Enabled = false;
                this.btnCancelar.Enabled = false;
                this.btnCategoria.Enabled = false;
            }

        }

        // oculta as colunas
        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[1].Visible = false;
            this.dataLista.Columns[6].Visible = false;

            this.dataLista.Columns[5].Visible = false;
            this.dataLista.Columns[8].Visible = false;


        }

        //mostrar no data grid
        private void Mostrar()
        {
            this.dataLista.DataSource = NProduto.Mostrar();
            this.ocultarColunas();
            //associa e converte em string
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        //BUSCAR nome
        private void BuscarNome()
        {
            this.dataLista.DataSource = NProduto.BuscarNome(this.txtBuscar.Text);

            this.ocultarColunas();

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);

        }
        //combo box mostrar
        private void ComboApresentacao()
        {
            cbApresentacao.DataSource = NApresentacao.Mostrar();
            cbApresentacao.ValueMember = "IdApresentacao"; // valor associado geralmente a chave
            cbApresentacao.DisplayMember = "nome"; //valor que sera apresentado

        }

        //fim dos metodos




        private void button2_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtNome.Focus(); //modificado
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.txtNome.Text == string.Empty || this.txtIdCategoria.Text == string.Empty || this.txtCodigo.Text == string.Empty)
                {
                    MensagemErro("Prencha todos os campos");
                    errorIcone.SetError(txtNome, "insira o nome");
                    errorIcone.SetError(txtIdCategoria, "insira o nome");
                    errorIcone.SetError(txtCodigo, "insira o nome");
                }
                else
                {
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(); // utiliza V tipo memory stream
                    this.pxImagem.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] imagem = ms.GetBuffer();
                    if (this.eNovo)
                    {
                        resp = NProduto.Inserir(this.txtCodigo.Text, this.txtNome.Text.Trim().ToUpper(), this.txtDescricao.Text.Trim(), imagem, Convert.ToInt32(this.txtIdCategoria.Text), Convert.ToInt32(this.cbApresentacao.SelectedValue));
                    }
                    else
                    {
                        resp = NProduto.Editar(Convert.ToInt32(this.txtId.Text), this.txtCodigo.Text, this.txtNome.Text.Trim().ToUpper(), this.txtDescricao.Text.Trim(), imagem, Convert.ToInt32(this.txtIdCategoria.Text), Convert.ToInt32(this.cbApresentacao.SelectedValue));
                    }
                    if (resp.Equals("Certo"))
                    {
                        if (this.eNovo)
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
                    this.eNovo = false;
                    this.eEditar = false;
                    this.botoes();
                    this.Limpar();
                    this.Mostrar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace); //mensagem de detalhamento do erro
            }
        }

        private void frmProduto_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            this.Habilitar(false);
            this.botoes();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            DialogResult result = dialog.ShowDialog();
            if (result == DialogResult.OK) //se ele selecionar um arquivo
            {
                this.pxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
                this.pxImagem.Image = Image.FromFile(dialog.FileName);

            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.pxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            this.pxImagem.Image = global::CamadaApresentacao.Properties.Resources.prodim;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (this.txtId.Text.Equals(""))
            {
                this.MensagemErro("selecione um registro");
            }
            else
            {
                this.eEditar = true;
                this.botoes();
                this.Habilitar(true);

            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.eNovo = false;
            this.eEditar = false;
            this.botoes();
            this.Habilitar(false);
            this.Limpar();
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

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtId.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idproduto"].Value);
            this.txtCodigo.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["codigo"].Value);
            this.txtNome.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["nome"].Value);
            this.txtDescricao.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["descricao"].Value);


            byte[] imagenBuffer = (byte[])this.dataLista.CurrentRow.Cells["imagem"].Value;
            System.IO.MemoryStream ms = new System.IO.MemoryStream(imagenBuffer); // utiliza V tipo memory stream
            this.pxImagem.Image = Image.FromStream(ms);
            this.pxImagem.SizeMode = PictureBoxSizeMode.StretchImage;

            this.txtIdCategoria.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idcategoria"].Value);
            this.txtCategoria.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["Categoria"].Value);
            this.cbApresentacao.SelectedValue = Convert.ToString(this.dataLista.CurrentRow.Cells["idapresentacao"].Value);


            this.TabControl1.SelectedIndex = 1;
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
                Opcao = MessageBox.Show("Apagar registro", "Sistema Comércio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (Opcao == DialogResult.OK)
                {
                    string Codigo;
                    string Resp = "";

                    foreach (DataGridViewRow row in dataLista.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            Codigo = Convert.ToString(row.Cells[1].Value);
                            Resp = NProduto.Excluir(Convert.ToInt32(Codigo));
                            if (Resp.Equals("Certo"))
                            {
                                this.MensagemOK("Registro excluido");

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

        private void btnCategoria_Click(object sender, EventArgs e)
        {
            frmBuscarCategoria form = new frmBuscarCategoria();
            form.ShowDialog();
        }

        private void frmProduto_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Instancia = null;
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
