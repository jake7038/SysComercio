namespace CamadaApresentacao
{
    partial class frmImprimirParcela
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
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            labelData = new Label();
            label2 = new Label();
            labelTotal = new Label();
            label4 = new Label();
            labelTipoComprovante = new Label();
            label3 = new Label();
            labelNome = new Label();
            button1 = new Button();
            Label1 = new Label();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(184, 525);
            label7.Name = "label7";
            label7.Size = new Size(501, 37);
            label7.TabIndex = 23;
            label7.Text = "--------------------------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(143, 126);
            label6.Name = "label6";
            label6.Size = new Size(501, 37);
            label6.TabIndex = 22;
            label6.Text = "--------------------------------------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(237, 69);
            label5.Name = "label5";
            label5.Size = new Size(315, 37);
            label5.TabIndex = 21;
            label5.Text = "Sistema Faeterj - Parcelas";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(468, 439);
            labelData.Name = "labelData";
            labelData.Size = new Size(73, 37);
            labelData.TabIndex = 20;
            labelData.Text = "Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(184, 319);
            label2.Name = "label2";
            label2.Size = new Size(233, 37);
            label2.TabIndex = 19;
            label2.Text = "Data Vencimento :";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(457, 576);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(74, 37);
            labelTotal.TabIndex = 18;
            labelTotal.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(184, 576);
            label4.Name = "label4";
            label4.Size = new Size(212, 37);
            label4.TabIndex = 17;
            label4.Text = "Valor da Parcela:";
            label4.Click += label4_Click;
            // 
            // labelTipoComprovante
            // 
            labelTipoComprovante.AutoSize = true;
            labelTipoComprovante.Location = new Point(457, 319);
            labelTipoComprovante.Name = "labelTipoComprovante";
            labelTipoComprovante.Size = new Size(179, 37);
            labelTipoComprovante.TabIndex = 16;
            labelTipoComprovante.Text = "Comprovante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(184, 439);
            label3.Name = "label3";
            label3.Size = new Size(259, 37);
            label3.TabIndex = 15;
            label3.Text = "Numero de Parcelas:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(445, 202);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(112, 37);
            labelNome.TabIndex = 14;
            labelNome.Text = "Antonio";
            // 
            // button1
            // 
            button1.Location = new Point(317, 805);
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
            Label1.Location = new Point(184, 202);
            Label1.Name = "Label1";
            Label1.Size = new Size(103, 37);
            Label1.TabIndex = 12;
            Label1.Text = "Nome :";
            // 
            // frmImprimirParcela
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 1097);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(labelData);
            Controls.Add(label2);
            Controls.Add(labelTotal);
            Controls.Add(label4);
            Controls.Add(labelTipoComprovante);
            Controls.Add(label3);
            Controls.Add(labelNome);
            Controls.Add(button1);
            Controls.Add(Label1);
            Name = "frmImprimirParcela";
            Text = "frmImprimirParcela";
            Load += frmImprimirParcela_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label6;
        private Label label5;
        private Label labelData;
        private Label label2;
        private Label labelTotal;
        private Label label4;
        private Label labelTipoComprovante;
        private Label label3;
        private Label labelNome;
        private Button button1;
        private Label Label1;
    }
}