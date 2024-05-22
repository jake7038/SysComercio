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
    public partial class frmBuscarCliente : Form
    {
        public frmBuscarCliente()
        {
            InitializeComponent();
        }

        // oculta as colunas
        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            //this.dataLista.Columns[1].Visible = false;

        }

        //mostrar no data grid
        private void Mostrar()
        {
            this.dataLista.DataSource = NCliente.Mostrar();
            this.ocultarColunas();
            //associa e converte em string
            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        //BUSCAR nome empresa
        private void BuscarNome()
        {
            this.dataLista.DataSource = NCliente.BuscarNome(this.txtBuscar.Text);
            this.ocultarColunas();

            lblTotal.Text = "Total de Registros: " + Convert.ToString(dataLista.Rows.Count);
        }

        private void frmBuscarCliente_Load(object sender, EventArgs e)
        {
           
            this.Mostrar();
            
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void dataLista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            frmVenda form = frmVenda.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(dataLista.CurrentRow.Cells["idcliente"].Value);
            par2 = Convert.ToString(dataLista.CurrentRow.Cells["nome"].Value);
            //MessageBox.Show("teste"); ele esta entrando
            form.setCliente(par1, par2);
            this.Hide(); //oculta a janela
        }
    }
}
