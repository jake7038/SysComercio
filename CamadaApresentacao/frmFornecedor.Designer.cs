namespace CamadaApresentacao
{
    partial class frmFornecedor
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFornecedor));
            ToolTip1 = new ToolTip(components);
            label3 = new Label();
            tabPage1 = new TabPage();
            chkDeletar = new CheckBox();
            dataLista = new DataGridView();
            Deletar = new DataGridViewCheckBoxColumn();
            lblTotal = new Label();
            btnImprimir = new Button();
            btnDeletar = new Button();
            btnBuscar = new Button();
            txtBuscar = new TextBox();
            label2 = new Label();
            btnCancelar = new Button();
            btnNovo = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            txtEmpresa = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            cbSetorComercial = new ComboBox();
            txtEndereco = new TextBox();
            label9 = new Label();
            txtNumDoc = new TextBox();
            label5 = new Label();
            txtTelefone = new TextBox();
            label6 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            tabPage2 = new TabPage();
            TabControl1 = new TabControl();
            errorIcone = new ErrorProvider(components);
            label1 = new Label();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLista).BeginInit();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            TabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcone).BeginInit();
            SuspendLayout();
            // 
            // ToolTip1
            // 
            ToolTip1.IsBalloon = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(19, 27);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Código";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(chkDeletar);
            tabPage1.Controls.Add(dataLista);
            tabPage1.Controls.Add(lblTotal);
            tabPage1.Controls.Add(btnImprimir);
            tabPage1.Controls.Add(btnDeletar);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(txtBuscar);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Margin = new Padding(1, 1, 1, 1);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(1, 1, 1, 1);
            tabPage1.Size = new Size(573, 226);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkDeletar
            // 
            chkDeletar.AutoSize = true;
            chkDeletar.Location = new Point(9, 42);
            chkDeletar.Margin = new Padding(1, 1, 1, 1);
            chkDeletar.Name = "chkDeletar";
            chkDeletar.Size = new Size(63, 19);
            chkDeletar.TabIndex = 7;
            chkDeletar.Text = "Deletar";
            chkDeletar.UseVisualStyleBackColor = true;
            chkDeletar.CheckedChanged += chkDeletar_CheckedChanged;
            // 
            // dataLista
            // 
            dataLista.AllowUserToAddRows = false;
            dataLista.AllowUserToDeleteRows = false;
            dataLista.AllowUserToOrderColumns = true;
            dataLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataLista.Columns.AddRange(new DataGridViewColumn[] { Deletar });
            dataLista.Location = new Point(8, 58);
            dataLista.Margin = new Padding(1, 1, 1, 1);
            dataLista.MultiSelect = false;
            dataLista.Name = "dataLista";
            dataLista.ReadOnly = true;
            dataLista.RowHeadersWidth = 92;
            dataLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLista.Size = new Size(552, 160);
            dataLista.TabIndex = 6;
            dataLista.CellContentClick += dataLista_CellContentClick;
            dataLista.DoubleClick += dataLista_DoubleClick;
            // 
            // Deletar
            // 
            Deletar.HeaderText = "Deletar";
            Deletar.MinimumWidth = 11;
            Deletar.Name = "Deletar";
            Deletar.ReadOnly = true;
            Deletar.Width = 225;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(391, 42);
            lblTotal.Margin = new Padding(1, 0, 1, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "label3";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(366, 17);
            btnImprimir.Margin = new Padding(1, 1, 1, 1);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(79, 21);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(274, 16);
            btnDeletar.Margin = new Padding(1, 1, 1, 1);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(79, 21);
            btnDeletar.TabIndex = 3;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(182, 16);
            btnBuscar.Margin = new Padding(1, 1, 1, 1);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(79, 21);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(60, 17);
            txtBuscar.Margin = new Padding(1, 1, 1, 1);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(107, 23);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 17);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Código";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(419, 187);
            btnCancelar.Margin = new Padding(1, 1, 1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 21);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(73, 187);
            btnNovo.Margin = new Padding(1, 1, 1, 1);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(79, 21);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(303, 187);
            btnEditar.Margin = new Padding(1, 1, 1, 1);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 21);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(185, 187);
            btnSalvar.Margin = new Padding(1, 1, 1, 1);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 21);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtEmpresa
            // 
            txtEmpresa.Location = new Point(96, 64);
            txtEmpresa.Margin = new Padding(1, 1, 1, 1);
            txtEmpresa.Name = "txtEmpresa";
            txtEmpresa.Size = new Size(107, 23);
            txtEmpresa.TabIndex = 4;
            // 
            // txtId
            // 
            txtId.Location = new Point(96, 27);
            txtId.Margin = new Padding(1, 1, 1, 1);
            txtId.Name = "txtId";
            txtId.Size = new Size(107, 23);
            txtId.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(19, 64);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 1;
            label4.Text = "Empresa";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbSetorComercial);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtNumDoc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtEmpresa);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(1, 1, 1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 1, 1, 1);
            groupBox1.Size = new Size(567, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Fornecedor";
            // 
            // cbSetorComercial
            // 
            cbSetorComercial.FormattingEnabled = true;
            cbSetorComercial.Items.AddRange(new object[] { "ALIMENTOS", "ROUPAS", "PEÇAS", "TECH" });
            cbSetorComercial.Location = new Point(323, 20);
            cbSetorComercial.Name = "cbSetorComercial";
            cbSetorComercial.Size = new Size(107, 23);
            cbSetorComercial.TabIndex = 24;
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(96, 150);
            txtEndereco.Margin = new Padding(1, 1, 1, 1);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(334, 23);
            txtEndereco.TabIndex = 23;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 150);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 22;
            label9.Text = "Endereço";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(323, 107);
            txtNumDoc.Margin = new Padding(1, 1, 1, 1);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(107, 23);
            txtNumDoc.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(246, 107);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 20;
            label5.Text = "Documento";
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(323, 64);
            txtTelefone.Margin = new Padding(1, 1, 1, 1);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(107, 23);
            txtTelefone.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(246, 64);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 18;
            label6.Text = "Telefone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(246, 27);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(34, 15);
            label8.TabIndex = 16;
            label8.Text = "Setor";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(96, 107);
            txtEmail.Margin = new Padding(1, 1, 1, 1);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(107, 23);
            txtEmail.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 107);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(36, 15);
            label7.TabIndex = 14;
            label7.Text = "Email";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(1, 1, 1, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(1, 1, 1, 1);
            tabPage2.Size = new Size(573, 226);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Configurar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tabPage1);
            TabControl1.Controls.Add(tabPage2);
            TabControl1.Location = new Point(10, 53);
            TabControl1.Margin = new Padding(1, 1, 1, 1);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(581, 254);
            TabControl1.TabIndex = 3;
            // 
            // errorIcone
            // 
            errorIcone.ContainerControl = this;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(10, 9);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(135, 32);
            label1.TabIndex = 2;
            label1.Text = "Fornecedor";
            // 
            // frmFornecedor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(591, 314);
            Controls.Add(TabControl1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmFornecedor";
            Text = "frmFornecedor";
            Load += frmFornecedor_Load;
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataLista).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            TabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorIcone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip ToolTip1;
        private Label label3;
        private TabPage tabPage1;
        private CheckBox chkDeletar;
        private DataGridView dataLista;
        private DataGridViewCheckBoxColumn Deletar;
        private Label lblTotal;
        private Button btnImprimir;
        private Button btnDeletar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label2;
        private Button btnCancelar;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private TextBox txtEmpresa;
        private TextBox txtId;
        private Label label4;
        private GroupBox groupBox1;
        private TabPage tabPage2;
        private TabControl TabControl1;
        private ErrorProvider errorIcone;
        private Label label1;
        private TextBox txtSetor_Comercial;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private TextBox txtNumDoc;
        private Label label5;
        private TextBox txtTelefone;
        private Label label6;
        private TextBox txtEndereco;
        private Label label9;
        private ComboBox cbSetorComercial;
    }
}