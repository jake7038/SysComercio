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
    public partial class frmImprimirCompra : Form
    {
        public string im1, im2, im3, im4, im5, im6;
        
        public frmImprimirCompra()
        {
            InitializeComponent();
            
        }
        public void setImprimirCompra(string funcionario, string fornecedor, string data, string comprovante, string correlativo, string total)
        {
            this.lbFornecedor.Text = fornecedor;
            this.lbData.Text = data;
            this.lbCompovante.Text = comprovante;
            this.lbFuncionario.Text = funcionario;
            this.lbPagamento.Text = correlativo;
            this.labelTotal.Text = total;

            if (lbPagamento.Text == "PAGO")
            {
                lbPagamento.Text = "Credito";
            }
        }
        private void frmImprimirCompra_Load(object sender, EventArgs e)
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
                        .Text("Faeterj - Relatório Compra")
                        .FontSize(40);
                    page.Content()
                    .Column(X => {
                        X.Item()
                            .Text("--------------------------------------------\n");

                        X.Item()
                            .Text(Convert.ToString(Label1.Text)+ " " + Convert.ToString(lbFornecedor.Text)) ;
                       
                        X.Item()
                            .Text(Convert.ToString(label3.Text) + " " + Convert.ToString(lbFuncionario.Text));
                       
                        X.Item()
                            .Text(Convert.ToString(label9.Text) + " " + Convert.ToString(lbData.Text));

                        X.Item()
                           .Text(Convert.ToString(label11.Text) + " " + Convert.ToString(lbCompovante.Text));

                        X.Item()
                           .Text(Convert.ToString(label13.Text) + " " + Convert.ToString(lbPagamento.Text));

                        X.Item()
                           .Text("--------------------------------------------\n");

                        X.Item()
                          .Text(Convert.ToString(label4.Text) + " " + Convert.ToString(labelTotal.Text));
                    } 
                    );  

                
                });
            
                
                
                })
                .GeneratePdf(filePath: "C:\\Users\\rafae\\OneDrive\\Área de Trabalho/arquivoCompra.pdf");
      
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //codigo comentado foi a primeira tentativa utilizando Binary writer, foi deixado de lado
            //por não conseguir produzir um pdf
            
            /* SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text File|*.txt";
            if (save.ShowDialog() == DialogResult.OK)
            {



                string path = save.FileName;
                BinaryWriter bw = new BinaryWriter(File.Open(path, FileMode.Create),Encoding.Default);
                bw.Write("      Sistema Faeterj - Venda\n");
                bw.Write("--------------------------------------------\n");

                bw.Write(Convert.ToString(Label1.Text));
                bw.Write(Convert.ToString(lbFornecedor.Text));
                bw.Write("\n");

                bw.Write(Convert.ToString(label3.Text));
                bw.Write(Convert.ToString(lbFuncionario.Text));
                bw.Write("\n");

                bw.Write(Convert.ToString(label9.Text));
                bw.Write(Convert.ToString(lbData.Text));
                bw.Write("\n");

                bw.Write(Convert.ToString(label11.Text));
                bw.Write(Convert.ToString(lbCompovante.Text));
                bw.Write("\n");

                bw.Write(Convert.ToString(label13.Text));
                bw.Write(Convert.ToString(lbPagamento.Text));
                bw.Write("\n");

                bw.Write("--------------------------------------------\n");

                bw.Write(Convert.ToString(label4.Text));
                bw.Write(Convert.ToString(labelTotal.Text));
                bw.Write("\n");

                bw.Dispose();
            }
             */
            //chamando a função para criar o pdf
            ImprimirPDF();
            MessageBox.Show("Salvo com sucesso");
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}