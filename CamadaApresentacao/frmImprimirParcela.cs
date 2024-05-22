using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

namespace CamadaApresentacao
{
    public partial class frmImprimirParcela : Form
    {
        public string im1, im2, im3, im4;
        public frmImprimirParcela()
        {
            InitializeComponent();
        }
        public void setImprimirParcela(string nome, string data, string comprovante, string total)
        {
            this.labelNome.Text = nome;
            this.labelData.Text = data;
            this.labelTipoComprovante.Text = comprovante;
            this.labelTotal.Text = total;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void frmImprimirParcela_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirPDF()
        {
            QuestPDF.Settings.License = LicenseType.Community;
            // SaveFileDialog save = new SaveFileDialog();
            // string path = save.FileName;
            // save.Filter = "C:\\Users\\rafae\\OneDrive\\Área de Trabalho/Text File.pdf";
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);

                    page.Header()
                        .Text("Faeterj - Relatório Parcelas a pagar")
                        .FontSize(40);
                    page.Content()
                    .Column(X => {
                        X.Item()
                            .Text("--------------------------------------------\n");

                        X.Item()
                            .Text(Convert.ToString(Label1.Text) + " " + Convert.ToString(labelNome.Text));

                        X.Item()
                            .Text(Convert.ToString(label2.Text) + " " + Convert.ToString(labelData.Text));
                        X.Item()
                        .Text(Convert.ToString(label3.Text) + " " + Convert.ToString(labelTipoComprovante.Text));
                        

                        X.Item()
                           .Text("--------------------------------------------\n");

                        X.Item()
                          .Text(Convert.ToString(label4.Text) + " " + Convert.ToString(labelTotal.Text));
                    }
                    );


                });



            })
                .GeneratePdf(filePath: "C:\\Users\\rafae\\OneDrive\\Área de Trabalho/arquivoParcela.pdf");


        }


        private void button1_Click(object sender, EventArgs e)
        {
            /* SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File|*.doc";
            if (save.ShowDialog() == DialogResult.OK)
            {



                string path = save.FileName;
                BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create));
                bw.Write("      Sistema Faeterj - Venda\n");
                bw.Write("--------------------------------------------\n");


                bw.Write(Convert.ToString(Label1.Text));
                bw.Write(Convert.ToString(labelNome.Text));
                bw.Write("\n");

                bw.Write(Convert.ToString(label2.Text));
                bw.Write(Convert.ToString(labelData.Text));
                bw.Write("\n");

                bw.Write(Convert.ToString(label3.Text));
                bw.Write(Convert.ToString(labelTipoComprovante.Text));
                bw.Write("\n");
               
                bw.Write("--------------------------------------------\n");
               
                bw.Write(Convert.ToString(label4.Text));
                bw.Write(Convert.ToString(labelTotal.Text));
                bw.Write("\n");



                bw.Dispose();


            }*/

            ImprimirPDF();
            MessageBox.Show("Salvo com sucesso");
        }
    }
}
