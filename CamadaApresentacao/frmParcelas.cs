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
using QuestPDF.Infrastructure;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;
using CamadaDados;

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
            

            string cliente;
            string parcelamentos;
            string data_limite;
            string parcela;
            decimal total =0;
            int entradas=0;
            QuestPDF.Settings.License = LicenseType.Community;

            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);

                    page.Header()
                        .Text("Faeterj - Relatório de parcelamenot dos clientes: ")
                        .FontSize(40);
                    page.Content()
                    .Column(X => {
                        X.Item()
                            .Text("--------------------------------------------\n");

                        //imprime cada cliente separado
                        foreach (DataGridViewRow row in dataLista.Rows)
                        {

                            cliente = Convert.ToString(row.Cells["Cliente"].Value);
                            parcelamentos = Convert.ToString(row.Cells["parcelamentos"].Value);
                            data_limite = Convert.ToString(row.Cells["data_limite"].Value);
                            parcela = Convert.ToString(row.Cells["Parcelas"].Value);
                           




                            if (Convert.ToBoolean(row.Cells[0].Value))
                            {


                                X.Item()
                          .Text("Nome do Cliente: " + cliente);
                                X.Item()
                                .Text("Numero de parcelas: " + parcelamentos);

                                X.Item()
                                .Text("Data de vencimento: " + data_limite);

                                X.Item()
                                .Text("Valor de cada parcela: R$ " + parcela);

                                X.Item()
                                .Text("Valor Total: R$ " + (Convert.ToDecimal(parcela) * Convert.ToDecimal(parcelamentos)));

                                X.Item()
                                .Text("--------------------------------------------\n");

                                total += ( (Convert.ToDecimal(row.Cells[5].Value)) * (Convert.ToDecimal(row.Cells[3].Value)));
                                entradas += 1;
                               
                            }

                        }



                        X.Item()
                       .Text("Total de clientes que parcelaram: " + entradas);
                        X.Item()
                        .Text("Total de todas as parcelas: R$ " + total);

                    }
                    );


                });



            })
                .GeneratePdf(filePath: "C:\\Users\\rafae\\OneDrive\\Área de Trabalho/arquivoRelatorioParcelas.pdf");

            MessageBox.Show("Relatório Gerado com Sucesso!");



           
        }
    }
}
