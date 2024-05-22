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
    public partial class frmContaPagar : Form
    {
        public frmContaPagar()
        {
            InitializeComponent();
            Mostrar();

        }
        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            //this.dataLista.Columns[1].Visible = false;

        }
        private void Mostrar()
        {
            this.dataLista.DataSource = NEntrada.MostrarDivida(txtNome.Text);
            this.ocultarColunas();

            //associa e converte em string
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }



        private void frmParcelas_Load(object sender, EventArgs e)
        {
            Mostrar();


        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmContaPagar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Mostrar();
        }

        private void dataLista_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DialogResult Opcao;
            Opcao = MessageBox.Show("Alterar para pago?", "Sistema Comércio", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcao == DialogResult.OK)
            {
                NEntrada.EditarConta(Convert.ToInt32(this.dataLista.CurrentRow.Cells["identrada"].Value), Convert.ToString(this.dataLista.CurrentRow.Cells["Estado"].Value));
            }
            Mostrar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmImprimirAPagar frmim = new frmImprimirAPagar();

            foreach (DataGridViewRow row in dataLista.Rows)
            {

             


               
                frmim.im1 = Convert.ToString(this.dataLista.CurrentRow.Cells["Empresa"].Value);
                frmim.im2 = Convert.ToString(this.dataLista.CurrentRow.Cells["Produto"].Value);
                frmim.im3 = Convert.ToString(this.dataLista.CurrentRow.Cells["data"].Value);
                frmim.im4 = Convert.ToString(this.dataLista.CurrentRow.Cells["Total"].Value);


                frmim.setImprimirAPagar(frmim.im1, frmim.im2, frmim.im3, frmim.im4);


            }


            frmim.Show();
        }
    }
}
