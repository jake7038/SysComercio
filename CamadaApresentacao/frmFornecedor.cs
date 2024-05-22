using CamadaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamadaApresentacao
{

    public partial class frmFornecedor : Form
    {

        private bool eNovo = false;
        private bool eEditar = false;
        public frmFornecedor()
        {
            InitializeComponent();
            this.ToolTip1.SetToolTip(this.txtEmpresa, "Insira o nome da empresa");
        }

        //mostra a mensagem de confirmar
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
            this.txtEmpresa.Text = string.Empty;
            this.txtEmail.Text = string.Empty;
            this.txtEndereco.Text = string.Empty;
            this.txtNumDoc.Text = string.Empty;
            this.txtTelefone.Text = string.Empty;
        }

        //habilitar os text box
        private void Habilitar(bool valor)
        {
            this.txtEmpresa.ReadOnly = !valor;
            this.txtEmail.ReadOnly = !valor;
            this.txtEndereco.ReadOnly = !valor;
            this.txtNumDoc.ReadOnly = !valor;
            this.txtTelefone.ReadOnly = !valor;
            this.cbSetorComercial.Enabled = valor;
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

            }
            else
            {
                this.Habilitar(false);
                this.btnNovo.Enabled = true;
                this.btnEditar.Enabled = true;
                this.btnSalvar.Enabled = false;
                this.btnCancelar.Enabled = false;
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
            this.dataLista.DataSource = NFornecedor.Mostrar();
            this.ocultarColunas();
            //associa e converte em string
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        //BUSCAR nome empresa
        private void BuscarNome()
        {
            this.dataLista.DataSource = NFornecedor.BuscarNome(this.txtBuscar.Text);
            this.ocultarColunas();

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        private void BuscarDocumento()
        {
            this.dataLista.DataSource = NFornecedor.BuscarNome(this.txtBuscar.Text);
            this.ocultarColunas();

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        //fim dos metodos

        private void frmFornecedor_Load(object sender, EventArgs e)
        {
            this.Top = 0;
            this.Left = 0;
            this.Mostrar();
            //habilitar os campos de texto
            this.Habilitar(false);

            this.botoes();
            this.txtId.Enabled = false;
            this.cbSetorComercial.SelectedIndex = 1;
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.eNovo = true;
            this.eEditar = false;
            this.botoes();
            this.Limpar();
            this.Habilitar(true);
            this.txtEmpresa.Focus();
            this.txtId.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                string resp = "";
                if (this.txtEmpresa.Text == string.Empty)
                {
                    MensagemErro("Prencha todos os campos");
                    errorIcone.SetError(txtEmpresa, "insira o nome");
                }
                else
                {
                    if (this.eNovo)
                    {
                        resp = NFornecedor.Inserir(this.txtEmpresa.Text.Trim().ToUpper(), this.cbSetorComercial.Text, this.txtTelefone.Text.Trim().ToUpper(), this.txtNumDoc.Text, this.txtEmail.Text, this.txtEndereco.Text);
                    }
                    else
                    {
                        resp = NFornecedor.Editar(Convert.ToInt32(this.txtId.Text),
                            this.txtEmpresa.Text.Trim().ToUpper(), this.cbSetorComercial.Text, this.txtTelefone.Text.Trim().ToUpper(), this.txtNumDoc.Text, this.txtEmail.Text, this.txtEndereco.Text);
                    }
                    if (resp.Equals("Certo"))
                    {
                        if (this.eNovo)
                        {
                            this.MensagemOK("Registro foi salvo");
                        }
                        else
                        {
                            this.MensagemOK("Regisro foi editado");
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

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            this.txtId.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["idfornecedor"].Value);
            this.txtEmpresa.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["empresa"].Value);
            this.txtNumDoc.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["num_documento"].Value);
            this.cbSetorComercial.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["setor_comercial"].Value);
            this.txtTelefone.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["telefone"].Value);
            this.txtEmail.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["email"].Value);
            this.txtEndereco.Text = Convert.ToString(this.dataLista.CurrentRow.Cells["endereco"].Value);
            this.TabControl1.SelectedIndex = 1;
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

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataLista.Columns["Deletar"].Index)
            {
                //marcar uma celula de gridview para deletar
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
                            Resp = NFornecedor.Excluir(Convert.ToInt32(Codigo));
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarDocumento();
        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }
    }
}
