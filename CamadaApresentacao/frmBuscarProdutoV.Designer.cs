namespace CamadaApresentacao
{
    partial class frmBuscarProdutoV
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
            label1.Location = new Point(23, 38);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(274, 81);
            label1.TabIndex = 18;
            label1.Text = "Produtos";
            // 
            // dataLista
            // 
            dataLista.AllowUserToAddRows = false;
            dataLista.AllowUserToDeleteRows = false;
            dataLista.AllowUserToOrderColumns = true;
            dataLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLista.Location = new Point(23, 296);
            dataLista.Margin = new Padding(2, 3, 2, 3);
            dataLista.MultiSelect = false;
            dataLista.Name = "dataLista";
            dataLista.ReadOnly = true;
            dataLista.RowHeadersWidth = 92;
            dataLista.RowTemplate.Height = 80;
            dataLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLista.Size = new Size(1367, 437);
            dataLista.TabIndex = 20;
            dataLista.DoubleClick += dataLista_DoubleClick;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1091, 252);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(97, 41);
            lblTotal.TabIndex = 19;
            lblTotal.Text = "label3";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(450, 176);
            btnBuscar.Margin = new Padding(2, 3, 2, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(192, 57);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(142, 181);
            txtBuscar.Margin = new Padding(2, 3, 2, 3);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(254, 47);
            txtBuscar.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 181);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(100, 41);
            label2.TabIndex = 15;
            label2.Text = "Nome";
            // 
            // frmBuscarProdutoV
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 755);
            Controls.Add(label1);
            Controls.Add(dataLista);
            Controls.Add(lblTotal);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Name = "frmBuscarProdutoV";
            Text = "Selecione o Produto";
            Load += frmBuscarProdutoV_Load;
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