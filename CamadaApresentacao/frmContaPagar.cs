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
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;

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
            string empresa;
            string produto;
            string data;
            decimal valor;
            decimal total = 0;
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
                        .Text("Faeterj - Relatório de Contas a Pagar")
                        .FontSize(40);
                    page.Content()
                    .Column(X => {
                        X.Item()
                            .Text("--------------------------------------------\n");

                        //imprime cada entrada separado
                        foreach (DataGridViewRow row in dataLista.Rows)
                        {

                            empresa = Convert.ToString(row.Cells["Empresa"].Value);
                            produto = Convert.ToString(row.Cells["Produto"].Value);
                            data = Convert.ToString(row.Cells["data"].Value);
                            valor = Convert.ToDecimal(row.Cells["Total"].Value);



                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {

                                X.Item()
                          .Text("Nome da empresa: " + empresa);
                                X.Item()
                                .Text("produto Comprado: " + produto);

                                X.Item()
                                .Text("data: " + data);

                                X.Item()
                                .Text("Total devido: R$ " + valor);

                                X.Item()
                                .Text("--------------------------------------------\n");

                                total += valor;
                                entradas += 1;
                            }
                        }
                        X.Item()
                       .Text("Numero de entradas = " + entradas);
                        X.Item()
                        .Text("Total: R$ " + total);

                    }
                    );


                });



            })
                .GeneratePdf(filePath: "C:\\Users\\rafae\\OneDrive\\Área de Trabalho/arquivoRelatorioContasaPagar.pdf");

            MessageBox.Show("Relatório Gerado com Sucesso!");



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
    }
}
