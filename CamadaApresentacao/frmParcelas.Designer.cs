namespace CamadaApresentacao
{
    partial class frmParcelas
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
            Selecionar = new DataGridViewCheckBoxColumn();
            lblTotal = new Label();
            txtNome = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            chkDeletar = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataLista).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(54, -5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(598, 72);
            label1.TabIndex = 17;
            label1.Text = "Clientes que Parcelaram";
            // 
            // dataLista
            // 
            dataLista.AllowUserToAddRows = false;
            dataLista.AllowUserToDeleteRows = false;
            dataLista.AllowUserToOrderColumns = true;
            dataLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLista.Columns.AddRange(new DataGridViewColumn[] { Selecionar });
            dataLista.Location = new Point(41, 191);
            dataLista.Margin = new Padding(2);
            dataLista.MultiSelect = false;
            dataLista.Name = "dataLista";
            dataLista.ReadOnly = true;
            dataLista.RowHeadersWidth = 92;
            dataLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLista.Size = new Size(1183, 395);
            dataLista.TabIndex = 18;
            dataLista.CellContentClick += dataLista_CellContentClick;
            // 
            // Selecionar
            // 
            Selecionar.HeaderText = "Selecionar";
            Selecionar.MinimumWidth = 11;
            Selecionar.Name = "Selecionar";
            Selecionar.ReadOnly = true;
            Selecionar.Resizable = DataGridViewTriState.True;
            Selecionar.SortMode = DataGridViewColumnSortMode.Automatic;
            Selecionar.Width = 225;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(993, 155);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(90, 37);
            lblTotal.TabIndex = 16;
            lblTotal.Text = "label3";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(325, 132);
            txtNome.Margin = new Padding(6, 7, 6, 7);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(210, 43);
            txtNome.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 135);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 20;
            label2.Text = "Nome";
            // 
            // button1
            // 
            button1.Location = new Point(573, 118);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(161, 57);
            button1.TabIndex = 21;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(769, 118);
            button2.Margin = new Padding(6, 7, 6, 7);
            button2.Name = "button2";
            button2.Size = new Size(161, 57);
            button2.TabIndex = 22;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // chkDeletar
            // 
            chkDeletar.AutoSize = true;
            chkDeletar.Location = new Point(41, 151);
            chkDeletar.Margin = new Padding(2);
            chkDeletar.Name = "chkDeletar";
            chkDeletar.Size = new Size(171, 41);
            chkDeletar.TabIndex = 23;
            chkDeletar.Text = "Selecionar";
            chkDeletar.UseVisualStyleBackColor = true;
            chkDeletar.CheckedChanged += chkDeletar_CheckedChanged;
            // 
            // frmParcelas
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1328, 648);
            Controls.Add(chkDeletar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(dataLista);
            Controls.Add(lblTotal);
            Margin = new Padding(2);
            Name = "frmParcelas";
            Text = "Parcelas";
            Load += frmParcelas_Load;
            ((System.ComponentModel.ISupportInitialize)dataLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataLista;
        private Label lblTotal;
        private TextBox txtNome;
        private Label label2;
        private Button button1;
        private Button button2;
        private CheckBox chkDeletar;
        private DataGridViewCheckBoxColumn Selecionar;
    }
}