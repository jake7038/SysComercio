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
    public partial class frmVerFornecedorEntrada : Form
    {
        public frmVerFornecedorEntrada()
        {
            InitializeComponent();
        }

        private void ocultarColunas()
        {
            this.dataLista.Columns[0].Visible = false;
            
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

        private void frmVerFornecedorEntrada_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarDocumento();
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            frmEntrada form = frmEntrada.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataLista.CurrentRow.Cells["idfornecedor"].Value);
            par2 = Convert.ToString(this.dataLista.CurrentRow.Cells["empresa"].Value);
            form.setFornecedor(par1, par2);
            this.Hide();
        }
    }
}
