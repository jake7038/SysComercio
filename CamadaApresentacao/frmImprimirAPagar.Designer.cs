namespace CamadaApresentacao
{
    partial class frmImprimirAPagar
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
            label7.Location = new Point(128, 561);
            label7.Name = "label7";
            label7.Size = new Size(501, 37);
            label7.TabIndex = 35;
            label7.Text = "--------------------------------------------";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(128, 150);
            label6.Name = "label6";
            label6.Size = new Size(501, 37);
            label6.TabIndex = 34;
            label6.Text = "--------------------------------------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 93);
            label5.Name = "label5";
            label5.Size = new Size(311, 37);
            label5.TabIndex = 33;
            label5.Text = "Sistema Faeterj - A Pagar";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(442, 463);
            labelData.Name = "labelData";
            labelData.Size = new Size(73, 37);
            labelData.TabIndex = 32;
            labelData.Text = "Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(169, 343);
            label2.Name = "label2";
            label2.Size = new Size(126, 37);
            label2.TabIndex = 31;
            label2.Text = "Produto :";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(430, 612);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(74, 37);
            labelTotal.TabIndex = 30;
            labelTotal.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(140, 612);
            label4.Name = "label4";
            label4.Size = new Size(155, 37);
            label4.TabIndex = 29;
            label4.Text = "Valor Total :";
            // 
            // labelTipoComprovante
            // 
            labelTipoComprovante.AutoSize = true;
            labelTipoComprovante.Location = new Point(442, 343);
            labelTipoComprovante.Name = "labelTipoComprovante";
            labelTipoComprovante.Size = new Size(179, 37);
            labelTipoComprovante.TabIndex = 28;
            labelTipoComprovante.Text = "Comprovante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(169, 463);
            label3.Name = "label3";
            label3.Size = new Size(86, 37);
            label3.TabIndex = 27;
            label3.Text = "Data :";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(442, 226);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(112, 37);
            labelNome.TabIndex = 26;
            labelNome.Text = "Antonio";
            // 
            // button1
            // 
            button1.Location = new Point(302, 829);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 25;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(169, 226);
            Label1.Name = "Label1";
            Label1.Size = new Size(131, 37);
            Label1.TabIndex = 24;
            Label1.Text = "Empresa :";
            // 
            // frmImprimirAPagar
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(798, 975);
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
            Name = "frmImprimirAPagar";
            Text = "frmImprimirAPagar";
            Load += frmImprimirAPagar_Load;
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