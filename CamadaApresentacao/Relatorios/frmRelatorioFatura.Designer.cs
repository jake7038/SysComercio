namespace CamadaApresentacao
{
    partial class frmRelatorioFatura
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            SuspendLayout();
            // 
            // reportViewer1
            // 
            reportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            reportViewer1.AutoValidate = AutoValidate.Disable;
            reportViewer1.LocalReport.EnableExternalImages = true;
            reportViewer1.Location = new Point(50, 50);
            reportViewer1.Name = "ReportViewer";
            reportViewer1.ServerReport.BearerToken = "CamadaApresentacao";
            reportViewer1.ServerReport.DisplayName = "Venda";
            reportViewer1.ServerReport.HistoryId = "C:\\Users\\rafae\\OneDrive\\Área de Trabalho\\SysComercio completo 2 - Copia\\SysComercio\\CamadaApresentacao\\dsPrincipal.xsd";
            reportViewer1.ServerReport.ReportPath = "C:\\Users\\rafae\\OneDrive\\Área de Trabalho\\SysComercio completo 2 - Copia\\SysComercio\\CamadaApresentacao\\dsPrincipal.xsd";
            reportViewer1.Size = new Size(1326, 566);
            reportViewer1.TabIndex = 0;
            reportViewer1.Load += reportViewer1_Load;
            // 
            // frmRelatorioFatura
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1687, 909);
            Controls.Add(reportViewer1);
            Name = "frmRelatorioFatura";
            Text = "frmRelatorioFatura";
            Load += frmRelatorioFatura_Load;
            ResumeLayout(false);
        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}