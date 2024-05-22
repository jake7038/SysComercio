using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamadaApresentacao.dsPrincipalTableAdapters;

namespace CamadaApresentacao
{
    public partial class frmRelatorioFatura : Form
    {
        private int _idvenda;

        public frmRelatorioFatura()
        {
            InitializeComponent();
            var dt =


            reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.rptComprovanteVenda.rdlc";
            reportViewer1.RefreshReport();
        }

        public int Idvenda { get => _idvenda; set => _idvenda = value; }

        private void frmRelatorioFatura_Load(object sender, EventArgs e)
        {

            //this.sprelatorio_faturaTableAdapter.Fill(this.dsPrincipal.sprelatorio_fatura, Idvenda);
            
            
            
            reportViewer1.LocalReport.ReportEmbeddedResource = "CamadaApresentacao.Relatorios.rptComprovanteVenda.rdlc";
            reportViewer1.RefreshReport();
           // this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
