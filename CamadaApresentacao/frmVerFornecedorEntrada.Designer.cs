namespace CamadaApresentacao
{
    partial class frmVerFornecedorEntrada
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
            dataLista = new DataGridView();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblTotal = new Label();
            ((System.ComponentModel.ISupportInitialize)dataLista).BeginInit();
            SuspendLayout();
            // 
            // dataLista
            // 
            dataLista.AllowUserToAddRows = false;
            dataLista.AllowUserToDeleteRows = false;
            dataLista.AllowUserToOrderColumns = true;
            dataLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLista.Location = new Point(14, 130);
            dataLista.Margin = new Padding(1, 1, 1, 1);
            dataLista.MultiSelect = false;
            dataLista.Name = "dataLista";
            dataLista.ReadOnly = true;
            dataLista.RowHeadersWidth = 92;
            dataLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLista.Size = new Size(552, 160);
            dataLista.TabIndex = 12;
            dataLista.DoubleClick += dataLista_DoubleClick;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(201, 84);
            btnBuscar.Margin = new Padding(1, 1, 1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(79, 21);
            btnBuscar.TabIndex = 9;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(87, 86);
            txtBuscar.Margin = new Padding(1, 1, 1, 1);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(107, 23);
            txtBuscar.TabIndex = 8;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 87);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 7;
            label2.Text = "Documento";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(14, 19);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 10;
            label1.Text = "Fornecedor";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(387, 114);
            lblTotal.Margin = new Padding(1, 0, 1, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 11;
            lblTotal.Text = "label3";
            // 
            // frmVerFornecedorEntrada
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 307);
            Controls.Add(dataLista);
            Controls.Add(btnBuscar);
            Controls.Add(txtBuscar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblTotal);
            Margin = new Padding(1, 1, 1, 1);
            Name = "frmVerFornecedorEntrada";
            Text = "Selecionar Fornecedor";
            Load += frmVerFornecedorEntrada_Load;
            ((System.ComponentModel.ISupportInitialize)dataLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataLista;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label2;
        private Label label1;
        private Label lblTotal;
    }
}