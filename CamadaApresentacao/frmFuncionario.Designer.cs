namespace CamadaApresentacao
{
    partial class frmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            groupBox1 = new GroupBox();
            cbAcesso = new ComboBox();
            label10 = new Label();
            cbSexo = new ComboBox();
            txtSenha = new TextBox();
            label11 = new Label();
            txtUsuario = new TextBox();
            label12 = new Label();
            label13 = new Label();
            txtEndereco = new TextBox();
            txtSobrenome = new TextBox();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            label9 = new Label();
            txtNumDoc = new TextBox();
            label5 = new Label();
            btnNovo = new Button();
            txtTelefone = new TextBox();
            label6 = new Label();
            label8 = new Label();
            txtEmail = new TextBox();
            label7 = new Label();
            txtNome = new TextBox();
            txtId = new TextBox();
            label4 = new Label();
            label3 = new Label();
            tabPage2 = new TabPage();
            TabControl1 = new TabControl();
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
            label1 = new Label();
            errorIcone = new ErrorProvider(components);
            ToolTip1 = new ToolTip(components);
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLista).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorIcone).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbAcesso);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(cbSexo);
            groupBox1.Controls.Add(txtSenha);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtUsuario);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label13);
            groupBox1.Controls.Add(txtEndereco);
            groupBox1.Controls.Add(txtSobrenome);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(txtNumDoc);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(txtTelefone);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(1, 1, 1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 1, 1, 1);
            groupBox1.Size = new Size(615, 245);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Funcionário";
            // 
            // cbAcesso
            // 
            cbAcesso.FormattingEnabled = true;
            cbAcesso.Items.AddRange(new object[] { "Administrador", "Cliente", "Vendedor" });
            cbAcesso.Location = new Point(308, 147);
            cbAcesso.Margin = new Padding(1, 1, 1, 1);
            cbAcesso.Name = "cbAcesso";
            cbAcesso.Size = new Size(107, 23);
            cbAcesso.TabIndex = 36;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(425, 62);
            label10.Margin = new Padding(1, 0, 1, 0);
            label10.Name = "label10";
            label10.Size = new Size(32, 15);
            label10.TabIndex = 35;
            label10.Text = "Sexo";
            // 
            // cbSexo
            // 
            cbSexo.FormattingEnabled = true;
            cbSexo.Items.AddRange(new object[] { "F", "M", "O" });
            cbSexo.Location = new Point(503, 62);
            cbSexo.Margin = new Padding(1, 1, 1, 1);
            cbSexo.Name = "cbSexo";
            cbSexo.Size = new Size(51, 23);
            cbSexo.TabIndex = 34;
            // 
            // txtSenha
            // 
            txtSenha.Location = new Point(503, 144);
            txtSenha.Margin = new Padding(1, 1, 1, 1);
            txtSenha.Name = "txtSenha";
            txtSenha.Size = new Size(107, 23);
            txtSenha.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(425, 144);
            label11.Margin = new Padding(1, 0, 1, 0);
            label11.Name = "label11";
            label11.Size = new Size(39, 15);
            label11.TabIndex = 32;
            label11.Text = "Senha";
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(503, 105);
            txtUsuario.Margin = new Padding(1, 1, 1, 1);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(107, 23);
            txtUsuario.TabIndex = 30;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(425, 105);
            label12.Margin = new Padding(1, 0, 1, 0);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 29;
            label12.Text = "Usuário";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(231, 144);
            label13.Margin = new Padding(1, 0, 1, 0);
            label13.Name = "label13";
            label13.Size = new Size(44, 15);
            label13.TabIndex = 28;
            label13.Text = "Acesso";
            // 
            // txtEndereco
            // 
            txtEndereco.Location = new Point(92, 177);
            txtEndereco.Margin = new Padding(1, 1, 1, 1);
            txtEndereco.Name = "txtEndereco";
            txtEndereco.Size = new Size(345, 23);
            txtEndereco.TabIndex = 25;
            // 
            // txtSobrenome
            // 
            txtSobrenome.Location = new Point(308, 62);
            txtSobrenome.Margin = new Padding(1, 1, 1, 1);
            txtSobrenome.Name = "txtSobrenome";
            txtSobrenome.Size = new Size(107, 23);
            txtSobrenome.TabIndex = 24;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(165, 219);
            btnSalvar.Margin = new Padding(1, 1, 1, 1);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 21);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(299, 219);
            btnEditar.Margin = new Padding(1, 1, 1, 1);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 21);
            btnEditar.TabIndex = 7;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(434, 219);
            btnCancelar.Margin = new Padding(1, 1, 1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 21);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(19, 177);
            label9.Margin = new Padding(1, 0, 1, 0);
            label9.Name = "label9";
            label9.Size = new Size(56, 15);
            label9.TabIndex = 22;
            label9.Text = "Endereço";
            // 
            // txtNumDoc
            // 
            txtNumDoc.Location = new Point(96, 145);
            txtNumDoc.Margin = new Padding(1, 1, 1, 1);
            txtNumDoc.Name = "txtNumDoc";
            txtNumDoc.Size = new Size(107, 23);
            txtNumDoc.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 147);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 20;
            label5.Text = "Documento";
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(35, 219);
            btnNovo.Margin = new Padding(1, 1, 1, 1);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(79, 21);
            btnNovo.TabIndex = 8;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(308, 105);
            txtTelefone.Margin = new Padding(1, 1, 1, 1);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(107, 23);
            txtTelefone.TabIndex = 19;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(231, 105);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(51, 15);
            label6.TabIndex = 18;
            label6.Text = "Telefone";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(231, 63);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(68, 15);
            label8.TabIndex = 16;
            label8.Text = "Sobrenome";
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
            // txtNome
            // 
            txtNome.Location = new Point(96, 64);
            txtNome.Margin = new Padding(1, 1, 1, 1);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(107, 23);
            txtNome.TabIndex = 4;
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
            label4.Size = new Size(40, 15);
            label4.TabIndex = 1;
            label4.Text = "Nome";
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
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(1, 1, 1, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(1, 1, 1, 1);
            tabPage2.Size = new Size(618, 244);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Configurar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tabPage1);
            TabControl1.Controls.Add(tabPage2);
            TabControl1.Location = new Point(11, 62);
            TabControl1.Margin = new Padding(1, 1, 1, 1);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(626, 272);
            TabControl1.TabIndex = 5;
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
            tabPage1.Size = new Size(618, 244);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // chkDeletar
            // 
            chkDeletar.AutoSize = true;
            chkDeletar.Location = new Point(10, 43);
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
            dataLista.Location = new Point(2, 59);
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
            lblTotal.Location = new Point(392, 43);
            lblTotal.Margin = new Padding(1, 0, 1, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "label3";
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
            label2.Location = new Point(10, 18);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(46, 15);
            label2.TabIndex = 0;
            label2.Text = "Código";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.Control;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(11, 18);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(149, 32);
            label1.TabIndex = 4;
            label1.Text = "Funcionários";
            // 
            // errorIcone
            // 
            errorIcone.ContainerControl = this;
            // 
            // ToolTip1
            // 
            ToolTip1.IsBalloon = true;
            // 
            // frmFuncionario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(644, 339);
            Controls.Add(TabControl1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1, 1, 1, 1);
            Name = "frmFuncionario";
            Text = "Funcionário";
            Load += frmFuncionario_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataLista).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorIcone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Label label9;
        private TextBox txtNumDoc;
        private Label label5;
        private TextBox txtTelefone;
        private Label label6;
        private Label label8;
        private TextBox txtEmail;
        private Label label7;
        private Button btnCancelar;
        private Button btnNovo;
        private Button btnEditar;
        private Button btnSalvar;
        private TextBox txtNome;
        private TextBox txtId;
        private Label label4;
        private Label label3;
        private TabPage tabPage2;
        private TabControl TabControl1;
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
        private Label label1;
        private ErrorProvider errorIcone;
        private ToolTip ToolTip1;
        private TextBox txtSobrenome;
        private TextBox txtEndereco;
        private TextBox txtSenha;
        private Label label11;
        private TextBox txtUsuario;
        private Label label12;
        private Label label13;
        private Label label10;
        private ComboBox cbSexo;
        private ComboBox cbAcesso;
    }
}