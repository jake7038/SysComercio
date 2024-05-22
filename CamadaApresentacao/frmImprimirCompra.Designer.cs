namespace CamadaApresentacao
{
    partial class frmImprimirCompra
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
            saveFileDialog1 = new SaveFileDialog();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            labelTotal = new Label();
            label4 = new Label();
            lbFornecedor = new Label();
            button1 = new Button();
            Label1 = new Label();
            lbFuncionario = new Label();
            label3 = new Label();
            lbData = new Label();
            label9 = new Label();
            lbCompovante = new Label();
            label11 = new Label();
            lbPagamento = new Label();
            label13 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(203, 604);
            label7.Name = "label7";
            label7.Size = new Size(501, 37);
            label7.TabIndex = 23;
            label7.Text = "--------------------------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(203, 126);
            label6.Name = "label6";
            label6.Size = new Size(501, 37);
            label6.TabIndex = 22;
            label6.Text = "--------------------------------------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(297, 69);
            label5.Name = "label5";
            label5.Size = new Size(315, 37);
            label5.TabIndex = 21;
            label5.Text = "Sistema Faeterj - Compra";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(449, 655);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(74, 37);
            labelTotal.TabIndex = 18;
            labelTotal.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(203, 655);
            label4.Name = "label4";
            label4.Size = new Size(87, 37);
            label4.TabIndex = 17;
            label4.Text = "Total :";
            // 
            // lbFornecedor
            // 
            lbFornecedor.AutoSize = true;
            lbFornecedor.Location = new Point(449, 187);
            lbFornecedor.Name = "lbFornecedor";
            lbFornecedor.Size = new Size(112, 37);
            lbFornecedor.TabIndex = 14;
            lbFornecedor.Text = "Antonio";
            // 
            // button1
            // 
            button1.Location = new Point(336, 835);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 13;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(203, 187);
            Label1.Name = "Label1";
            Label1.Size = new Size(164, 37);
            Label1.TabIndex = 12;
            Label1.Text = "Fornecedor :";
            // 
            // lbFuncionario
            // 
            lbFuncionario.AutoSize = true;
            lbFuncionario.Location = new Point(449, 267);
            lbFuncionario.Name = "lbFuncionario";
            lbFuncionario.Size = new Size(112, 37);
            lbFuncionario.TabIndex = 25;
            lbFuncionario.Text = "Antonio";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 267);
            label3.Name = "label3";
            label3.Size = new Size(162, 37);
            label3.TabIndex = 24;
            label3.Text = "Funcionario:";
            // 
            // lbData
            // 
            lbData.AutoSize = true;
            lbData.Location = new Point(449, 344);
            lbData.Name = "lbData";
            lbData.Size = new Size(112, 37);
            lbData.TabIndex = 27;
            lbData.Text = "Antonio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(203, 344);
            label9.Name = "label9";
            label9.Size = new Size(79, 37);
            label9.TabIndex = 26;
            label9.Text = "Data:";
            // 
            // lbCompovante
            // 
            lbCompovante.AutoSize = true;
            lbCompovante.Location = new Point(449, 427);
            lbCompovante.Name = "lbCompovante";
            lbCompovante.Size = new Size(112, 37);
            lbCompovante.TabIndex = 29;
            lbCompovante.Text = "Antonio";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(203, 427);
            label11.Name = "label11";
            label11.Size = new Size(185, 37);
            label11.TabIndex = 28;
            label11.Text = "Comprovante:";
            label11.Click += label11_Click;
            // 
            // lbPagamento
            // 
            lbPagamento.AutoSize = true;
            lbPagamento.Location = new Point(449, 502);
            lbPagamento.Name = "lbPagamento";
            lbPagamento.Size = new Size(112, 37);
            lbPagamento.TabIndex = 31;
            lbPagamento.Text = "Antonio";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(203, 502);
            label13.Name = "label13";
            label13.Size = new Size(158, 37);
            label13.TabIndex = 30;
            label13.Text = "Pagamento:";
            label13.TextAlign = ContentAlignment.TopCenter;
            // 
            // frmImprimirCompra
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(990, 1154);
            Controls.Add(lbPagamento);
            Controls.Add(label13);
            Controls.Add(lbCompovante);
            Controls.Add(label11);
            Controls.Add(lbData);
            Controls.Add(label9);
            Controls.Add(lbFuncionario);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(labelTotal);
            Controls.Add(label4);
            Controls.Add(lbFornecedor);
            Controls.Add(button1);
            Controls.Add(Label1);
            Name = "frmImprimirCompra";
            Text = "frmImprimirCompra";
            Load += frmImprimirCompra_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label labelTotal;
        private Label label4;
        private Label lbFornecedor;
        private Button button1;
        private Label Label1;
        private Label lbFuncionario;
        private Label label3;
        private Label lbData;
        private Label label9;
        private Label lbCompovante;
        private Label label11;
        private Label lbPagamento;
        private Label label13;
    }
}