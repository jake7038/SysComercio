using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuestPDF.Fluent;
using QuestPDF.Helpers;
using QuestPDF.Infrastructure;
using QuestPDF.Previewer;

namespace CamadaApresentacao
{
    public partial class frmImprimirAPagar : Form
    {
        public string im1, im2, im3, im4;
        public frmImprimirAPagar()
        {
            InitializeComponent();
        }

        public void setImprimirAPagar(string empresa, string produto, string data, string total)
        {
            this.labelNome.Text = empresa;
            this.labelData.Text = data;
            this.labelTipoComprovante.Text = produto;
            this.labelTotal.Text = total;
        }
        private void frmImprimirAPagar_Load(object sender, EventArgs e)
        {

        }

        private void ImprimirPDF()
        {
            QuestPDF.Settings.License = LicenseType.Community;
           
            Document.Create(container =>
            {
                container.Page(page =>
                {
                    page.Size(PageSizes.A4);
                    page.Margin(2, Unit.Centimetre);
                    page.PageColor(Colors.White);

                    page.Header()
                        .Text("Faeterj - Relatório de contas")
                        .FontSize(40);
                    page.Content()
                    .Column(X => {
                        X.Item()
                            .Text("--------------------------------------------\n");

                        X.Item()
                            .Text(Convert.ToString(Label1.Text) + " " + Convert.ToString(labelNome.Text));

                        X.Item()
                            .Text(Convert.ToString(label2.Text) + " " + Convert.ToString(labelTipoComprovante.Text));
                        X.Item()
                        .Text(Convert.ToString(label3.Text) + " " + Convert.ToString(labelData.Text));


                        X.Item()
                           .Text("--------------------------------------------\n");

                        X.Item()
                          .Text(Convert.ToString(label4.Text) + " " + Convert.ToString(labelTotal.Text));
                    }
                    );


                });



            })
                .GeneratePdf(filePath: "C:\\Users\\rafae\\OneDrive\\Área de Trabalho/arquivoAPagar.pdf");


        }


        private void button1_Click(object sender, EventArgs e)
        {
            ImprimirPDF();
            MessageBox.Show("Salvo com sucesso");
        }
    }
}
