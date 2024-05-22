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
using CamadaNegocio;

namespace CamadaApresentacao
{
    public partial class frmVerProdutoEntrada : Form
    {
        public frmVerProdutoEntrada()
        {
            InitializeComponent();
        }

        private void ocultarColunas()
        {
            //this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[0].Visible = false;
            this.dataLista.Columns[5].Visible = false;

            this.dataLista.Columns[4].Visible = false;
            this.dataLista.Columns[7].Visible = false;


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



        private void frmVerProdutoEntrada_Load(object sender, EventArgs e)
        {
            this.Mostrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.BuscarNome();
        }

        private void dataLista_DoubleClick(object sender, EventArgs e)
        {
            frmEntrada form = frmEntrada.GetInstancia();
            string par1, par2;
            par1 = Convert.ToString(this.dataLista.CurrentRow.Cells["idproduto"].Value);
            par2 = Convert.ToString(this.dataLista.CurrentRow.Cells["nome"].Value);
            form.setProduto(par1, par2);
            this.Hide();
        }
    }
}
