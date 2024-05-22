namespace CamadaApresentacao
{
    partial class frmProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProduto));
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
            tabPage2 = new TabPage();
            btnNovo = new Button();
            groupBox1 = new GroupBox();
            cbApresentacao = new ComboBox();
            label8 = new Label();
            btnCategoria = new Button();
            txtCategoria = new TextBox();
            txtIdCategoria = new TextBox();
            label7 = new Label();
            txtCodigo = new TextBox();
            btnLimpar = new Button();
            label6 = new Label();
            pxImagem = new PictureBox();
            btnCarregar = new Button();
            txtId = new TextBox();
            txtDescricao = new TextBox();
            label3 = new Label();
            txtNome = new TextBox();
            label4 = new Label();
            label5 = new Label();
            btnSalvar = new Button();
            btnEditar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            errorIcone = new ErrorProvider(components);
            ToolTip1 = new ToolTip(components);
            TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLista).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pxImagem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorIcone).BeginInit();
            SuspendLayout();
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tabPage1);
            TabControl1.Controls.Add(tabPage2);
            TabControl1.Location = new Point(9, 71);
            TabControl1.Margin = new Padding(1, 1, 1, 1);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(612, 286);
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
            tabPage1.Size = new Size(604, 258);
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
            dataLista.Location = new Point(8, 58);
            dataLista.Margin = new Padding(1, 1, 1, 1);
            dataLista.MultiSelect = false;
            dataLista.Name = "dataLista";
            dataLista.ReadOnly = true;
            dataLista.RowHeadersWidth = 92;
            dataLista.RowTemplate.Height = 55;
            dataLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLista.Size = new Size(563, 160);
            dataLista.TabIndex = 6;
            dataLista.CellContentClick += dataLista_CellContentClick;
            dataLista.CellDoubleClick += dataLista_CellDoubleClick;
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
            lblTotal.Location = new Point(454, 42);
            lblTotal.Margin = new Padding(1, 0, 1, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "label3";
            lblTotal.Click += lblTotal_Click;
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(368, 16);
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
            label2.Location = new Point(17, 19);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnNovo);
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Controls.Add(btnSalvar);
            tabPage2.Controls.Add(btnEditar);
            tabPage2.Controls.Add(btnCancelar);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Margin = new Padding(1, 1, 1, 1);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(1, 1, 1, 1);
            tabPage2.Size = new Size(604, 258);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Configurar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(31, 227);
            btnNovo.Margin = new Padding(1, 1, 1, 1);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(79, 21);
            btnNovo.TabIndex = 23;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbApresentacao);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(btnCategoria);
            groupBox1.Controls.Add(txtCategoria);
            groupBox1.Controls.Add(txtIdCategoria);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(txtCodigo);
            groupBox1.Controls.Add(btnLimpar);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(pxImagem);
            groupBox1.Controls.Add(btnCarregar);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(1, 1, 1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 1, 1, 1);
            groupBox1.Size = new Size(599, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Produto";
            // 
            // cbApresentacao
            // 
            cbApresentacao.FormattingEnabled = true;
            cbApresentacao.Location = new Point(405, 65);
            cbApresentacao.Name = "cbApresentacao";
            cbApresentacao.Size = new Size(121, 23);
            cbApresentacao.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(293, 66);
            label8.Margin = new Padding(1, 0, 1, 0);
            label8.Name = "label8";
            label8.Size = new Size(70, 15);
            label8.TabIndex = 27;
            label8.Text = "Embalagem";
            // 
            // btnCategoria
            // 
            btnCategoria.BackColor = Color.White;
            btnCategoria.BackgroundImage = (Image)resources.GetObject("btnCategoria.BackgroundImage");
            btnCategoria.BackgroundImageLayout = ImageLayout.Stretch;
            btnCategoria.Cursor = Cursors.Hand;
            btnCategoria.FlatStyle = FlatStyle.Popup;
            btnCategoria.Location = new Point(537, 27);
            btnCategoria.Margin = new Padding(1, 1, 1, 1);
            btnCategoria.Name = "btnCategoria";
            btnCategoria.Size = new Size(25, 25);
            btnCategoria.TabIndex = 26;
            btnCategoria.UseVisualStyleBackColor = false;
            btnCategoria.Click += btnCategoria_Click;
            // 
            // txtCategoria
            // 
            txtCategoria.Location = new Point(405, 27);
            txtCategoria.Margin = new Padding(1, 1, 1, 1);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(130, 23);
            txtCategoria.TabIndex = 25;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(355, 27);
            txtIdCategoria.Margin = new Padding(1, 1, 1, 1);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(45, 23);
            txtIdCategoria.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(293, 30);
            label7.Margin = new Padding(1, 0, 1, 0);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 23;
            label7.Text = "Categoria";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(81, 103);
            txtCodigo.Margin = new Padding(1, 1, 1, 1);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(107, 23);
            txtCodigo.TabIndex = 22;
            // 
            // btnLimpar
            // 
            btnLimpar.BackgroundImage = (Image)resources.GetObject("btnLimpar.BackgroundImage");
            btnLimpar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Location = new Point(475, 151);
            btnLimpar.Margin = new Padding(1, 1, 1, 1);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(60, 60);
            btnLimpar.TabIndex = 16;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(4, 103);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(46, 15);
            label6.TabIndex = 21;
            label6.Text = "Código";
            // 
            // pxImagem
            // 
            pxImagem.BackgroundImageLayout = ImageLayout.Zoom;
            pxImagem.Location = new Point(321, 92);
            pxImagem.Name = "pxImagem";
            pxImagem.Size = new Size(150, 119);
            pxImagem.TabIndex = 15;
            pxImagem.TabStop = false;
            // 
            // btnCarregar
            // 
            btnCarregar.BackColor = Color.Transparent;
            btnCarregar.BackgroundImage = (Image)resources.GetObject("btnCarregar.BackgroundImage");
            btnCarregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCarregar.Cursor = Cursors.Hand;
            btnCarregar.Location = new Point(475, 92);
            btnCarregar.Margin = new Padding(1, 1, 1, 1);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(60, 59);
            btnCarregar.TabIndex = 14;
            btnCarregar.UseVisualStyleBackColor = false;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(81, 58);
            txtId.Margin = new Padding(1, 1, 1, 1);
            txtId.Name = "txtId";
            txtId.Size = new Size(107, 23);
            txtId.TabIndex = 15;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(81, 173);
            txtDescricao.Margin = new Padding(1, 1, 1, 1);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtDescricao.Size = new Size(201, 38);
            txtDescricao.TabIndex = 17;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(4, 58);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 12;
            label3.Text = "ID";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(81, 141);
            txtNome.Margin = new Padding(1, 1, 1, 1);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(107, 23);
            txtNome.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 144);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 13;
            label4.Text = "Nome";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(4, 186);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 14;
            label5.Text = "descricao";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(123, 227);
            btnSalvar.Margin = new Padding(1, 1, 1, 1);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 21);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(223, 227);
            btnEditar.Margin = new Padding(1, 1, 1, 1);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(79, 21);
            btnEditar.TabIndex = 19;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(324, 227);
            btnCancelar.Margin = new Padding(1, 1, 1, 1);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(79, 21);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(10, 27);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 32);
            label1.TabIndex = 4;
            label1.Text = "Produtos";
            // 
            // errorIcone
            // 
            errorIcone.ContainerControl = this;
            // 
            // ToolTip1
            // 
            ToolTip1.IsBalloon = true;
            // 
            // frmProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(627, 369);
            Controls.Add(TabControl1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmProduto";
            Text = "frmProduto";
            FormClosed += frmProduto_FormClosed;
            Load += frmProduto_Load;
            TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataLista).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pxImagem).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorIcone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

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
        private TabPage tabPage2;
        private GroupBox groupBox1;
        private Label label1;
        private ErrorProvider errorIcone;
        private ToolTip ToolTip1;
        private Button btnLimpar;
        private PictureBox pxImagem;
        private Button btnCarregar;
        private TextBox txtCodigo;
        private Label label6;
        private Button btnCancelar;
        private Button btnEditar;
        private Button btnSalvar;
        private TextBox txtId;
        private TextBox txtDescricao;
        private Label label3;
        private TextBox txtNome;
        private Label label4;
        private Label label5;
        private Button btnNovo;
        private Button btnCategoria;
        private TextBox txtCategoria;
        private TextBox txtIdCategoria;
        private Label label7;
        private Label label8;
        private ComboBox cbApresentacao;
    }
}