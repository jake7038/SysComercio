namespace CamadaApresentacao
{
    partial class frmImprimirVenda
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
            Label1 = new Label();
            button1 = new Button();
            labelNome = new Label();
            labelTipoComprovante = new Label();
            label3 = new Label();
            labelTotal = new Label();
            label4 = new Label();
            labelData = new Label();
            label2 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            SuspendLayout();
            // 
            // Label1
            // 
            Label1.AutoSize = true;
            Label1.Location = new Point(200, 233);
            Label1.Name = "Label1";
            Label1.Size = new Size(103, 37);
            Label1.TabIndex = 0;
            Label1.Text = "Nome :";
            // 
            // button1
            // 
            button1.Location = new Point(333, 836);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 1;
            button1.Text = "Imprimir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(446, 233);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(112, 37);
            labelNome.TabIndex = 2;
            labelNome.Text = "Antonio";
            // 
            // labelTipoComprovante
            // 
            labelTipoComprovante.AutoSize = true;
            labelTipoComprovante.Location = new Point(446, 470);
            labelTipoComprovante.Name = "labelTipoComprovante";
            labelTipoComprovante.Size = new Size(179, 37);
            labelTipoComprovante.TabIndex = 4;
            labelTipoComprovante.Text = "Comprovante";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(200, 470);
            label3.Name = "label3";
            label3.Size = new Size(192, 37);
            label3.TabIndex = 3;
            label3.Text = "Comprovante :";
            // 
            // labelTotal
            // 
            labelTotal.AutoSize = true;
            labelTotal.Location = new Point(446, 607);
            labelTotal.Name = "labelTotal";
            labelTotal.Size = new Size(74, 37);
            labelTotal.TabIndex = 6;
            labelTotal.Text = "Total";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(200, 607);
            label4.Name = "label4";
            label4.Size = new Size(87, 37);
            label4.TabIndex = 5;
            label4.Text = "Total :";
            // 
            // labelData
            // 
            labelData.AutoSize = true;
            labelData.Location = new Point(446, 350);
            labelData.Name = "labelData";
            labelData.Size = new Size(73, 37);
            labelData.TabIndex = 8;
            labelData.Text = "Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(200, 350);
            label2.Name = "label2";
            label2.Size = new Size(86, 37);
            label2.TabIndex = 7;
            label2.Text = "Data :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(294, 70);
            label5.Name = "label5";
            label5.Size = new Size(294, 37);
            label5.TabIndex = 9;
            label5.Text = "Sistema Faeterj - Venda";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 127);
            label6.Name = "label6";
            label6.Size = new Size(501, 37);
            label6.TabIndex = 10;
            label6.Text = "--------------------------------------------";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(200, 556);
            label7.Name = "label7";
            label7.Size = new Size(501, 37);
            label7.TabIndex = 11;
            label7.Text = "--------------------------------------------";
            // 
            // frmImprimirVenda
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 1021);
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
            Name = "frmImprimirVenda";
            Text = "frmImprimirVenda";
            Load += frmImprimirVenda_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SaveFileDialog saveFileDialog1;
        private Label Label1;
        private Button button1;
        private Label labelNome;
        private Label labelTipoComprovante;
        private Label label3;
        private Label labelTotal;
        private Label label4;
        private Label labelData;
        private Label label2;
        private Label label5;
        private Label label6;
        private Label label7;
    }
}