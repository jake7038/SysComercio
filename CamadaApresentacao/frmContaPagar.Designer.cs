namespace CamadaApresentacao
{
    partial class frmContaPagar
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
            button1 = new Button();
            label2 = new Label();
            txtNome = new TextBox();
            label1 = new Label();
            dataLista = new DataGridView();
            Selecionar = new DataGridViewCheckBoxColumn();
            lblTotal = new Label();
            button2 = new Button();
            chkDeletar = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataLista).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(567, 136);
            button1.Margin = new Padding(6, 7, 6, 7);
            button1.Name = "button1";
            button1.Size = new Size(161, 57);
            button1.TabIndex = 27;
            button1.Text = "Pesquisar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 143);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 37);
            label2.TabIndex = 26;
            label2.Text = "Nome";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(324, 143);
            txtNome.Margin = new Padding(6, 7, 6, 7);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(210, 43);
            txtNome.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(11, 29);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(384, 72);
            label1.TabIndex = 23;
            label1.Text = "Contas a Pagar";
            label1.Click += label1_Click;
            // 
            // dataLista
            // 
            dataLista.AllowUserToAddRows = false;
            dataLista.AllowUserToDeleteRows = false;
            dataLista.AllowUserToOrderColumns = true;
            dataLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLista.Columns.AddRange(new DataGridViewColumn[] { Selecionar });
            dataLista.Location = new Point(11, 204);
            dataLista.Margin = new Padding(2);
            dataLista.MultiSelect = false;
            dataLista.Name = "dataLista";
            dataLista.ReadOnly = true;
            dataLista.RowHeadersWidth = 92;
            dataLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLista.Size = new Size(1183, 395);
            dataLista.TabIndex = 24;
            dataLista.CellContentClick += dataLista_CellContentClick;
            dataLista.CellDoubleClick += dataLista_CellDoubleClick;
            // 
            // Selecionar
            // 
            Selecionar.HeaderText = "Selecionar";
            Selecionar.MinimumWidth = 11;
            Selecionar.Name = "Selecionar";
            Selecionar.ReadOnly = true;
            Selecionar.Width = 225;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(977, 165);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(90, 37);
            lblTotal.TabIndex = 22;
            lblTotal.Text = "label3";
            // 
            // button2
            // 
            button2.Location = new Point(767, 136);
            button2.Margin = new Padding(6, 7, 6, 7);
            button2.Name = "button2";
            button2.Size = new Size(161, 57);
            button2.TabIndex = 28;
            button2.Text = "Imprimir";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // chkDeletar
            // 
            chkDeletar.AutoSize = true;
            chkDeletar.Location = new Point(11, 159);
            chkDeletar.Margin = new Padding(2);
            chkDeletar.Name = "chkDeletar";
            chkDeletar.Size = new Size(171, 41);
            chkDeletar.TabIndex = 29;
            chkDeletar.Text = "Selecionar";
            chkDeletar.UseVisualStyleBackColor = true;
            chkDeletar.CheckedChanged += chkDeletar_CheckedChanged;
            // 
            // frmContaPagar
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 650);
            Controls.Add(chkDeletar);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(dataLista);
            Controls.Add(lblTotal);
            Name = "frmContaPagar";
            Text = "frmContaPagar";
            Load += frmContaPagar_Load;
            ((System.ComponentModel.ISupportInitialize)dataLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label2;
        private TextBox txtNome;
        private Label label1;
        private DataGridView dataLista;
        private Label lblTotal;
        private Button button2;
        private CheckBox chkDeletar;
        private DataGridViewCheckBoxColumn Selecionar;
    }
}