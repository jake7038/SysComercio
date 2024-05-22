namespace CamadaApresentacao
{
    partial class frmVerProdutoEntrada
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
            label1 = new Label();
            dataLista = new DataGridView();
            lblTotal = new Label();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataLista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(11, 24);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 12;
            label1.Text = "Produtos";
            // 
            // dataLista
            // 
            dataLista.AllowUserToAddRows = false;
            dataLista.AllowUserToDeleteRows = false;
            dataLista.AllowUserToOrderColumns = true;
            dataLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLista.Location = new Point(11, 119);
            dataLista.Margin = new Padding(1, 1, 1, 1);
            dataLista.MultiSelect = false;
            dataLista.Name = "dataLista";
            dataLista.ReadOnly = true;
            dataLista.RowHeadersWidth = 92;
            dataLista.RowTemplate.Height = 55;
            dataLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLista.Size = new Size(563, 160);
            dataLista.TabIndex = 14;
            dataLista.DoubleClick += dataLista_DoubleClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(450, 102);
            lblTotal.Margin = new Padding(1, 0, 1, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 13;
            lblTotal.Text = "label3";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(187, 75);
            btnBuscar.Margin = new Padding(1, 1, 1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(79, 21);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(60, 76);
            txtBuscar.Margin = new Padding(1, 1, 1, 1);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(107, 23);
            txtBuscar.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(11, 76);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 8;
            label2.Text = "Nome";
            // 
            // frmVerProdutoEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 288);
            Controls.Add(label1);
            Controls.Add(dataLista);
            Controls.Add(lblTotal);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(1, 1, 1, 1);
            Name = "frmVerProdutoEntrada";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Selecionar Produto";
            Load += frmVerProdutoEntrada_Load;
            ((System.ComponentModel.ISupportInitialize)dataLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataLista;
        private Label lblTotal;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label2;
    }
}