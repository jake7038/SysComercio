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
    public partial class frmParcelas : Form
    {
        public frmParcelas()
        {
            InitializeComponent();

        }
        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            //this.dataLista.Columns[1].Visible = false;

        }
        private void Mostrar()
        {
            this.dataLista.DataSource = NVenda.MostrarParcela(txtNome.Text);
            this.ocultarColunas();

            //associa e converte em string
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }



        private void frmParcelas_Load(object sender, EventArgs e)
        {
            Mostrar();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataLista.DataSource = NVenda.MostrarParcela(txtNome.Text);
            this.ocultarColunas();
            //associa e converte em string
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
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
            if (e.ColumnIndex == dataLista.Columns["Selecionar"].Index)
            {
                //marcar uma celula de gridview
                DataGridViewCheckBoxCell ChkDeletar = (DataGridViewCheckBoxCell)dataLista.Rows[e.RowIndex].Cells["Selecionar"];
                ChkDeletar.Value = !Convert.ToBoolean(ChkDeletar.Value);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmImprimirParcela frmim = new frmImprimirParcela();

            foreach (DataGridViewRow row in dataLista.Rows)
            {

                string cliente;
                string parcelamentos;
                string data_limite;
                string parcela;


                // frmim.setimprimirvenda(par1, par2, par3, par4);

                frmim.im1 = Convert.ToString(this.dataLista.CurrentRow.Cells["Cliente"].Value);
                frmim.im2 = Convert.ToString(this.dataLista.CurrentRow.Cells["parcelamentos"].Value);
                frmim.im3 = Convert.ToString(this.dataLista.CurrentRow.Cells["data_limite"].Value);
                frmim.im4 = Convert.ToString(this.dataLista.CurrentRow.Cells["Parcelas"].Value);


                frmim.setImprimirParcela(frmim.im1, frmim.im2, frmim.im3, frmim.im4);


            }


            frmim.Show();
        }
    }
}
