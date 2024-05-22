namespace CamadaApresentacao
{
    partial class frmEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntrada));
            ToolTip1 = new ToolTip(components);
            label1 = new Label();
            btnSalvar = new Button();
            btnCancelar = new Button();
            errorIcone = new ErrorProvider(components);
            btnFornecedor = new Button();
            txtFornecedor = new TextBox();
            btnNovo = new Button();
            groupBox1 = new GroupBox();
            cbCorrelativo = new ComboBox();
            TotalPagar = new Label();
            label16 = new Label();
            DataListaDetalhes = new DataGridView();
            txtImposto = new TextBox();
            label12 = new Label();
            txtSerie = new TextBox();
            label11 = new Label();
            cbComprovante = new ComboBox();
            dtData = new DateTimePicker();
            label10 = new Label();
            txtIdFornecedor = new TextBox();
            label7 = new Label();
            label6 = new Label();
            txtId = new TextBox();
            label3 = new Label();
            groupBox2 = new GroupBox();
            dtDataValidade = new DateTimePicker();
            label15 = new Label();
            dtDataPedido = new DateTimePicker();
            label14 = new Label();
            label13 = new Label();
            txtPrecoVenda = new TextBox();
            label8 = new Label();
            txtPrecoCompra = new TextBox();
            label5 = new Label();
            txtEstoqueInicial = new TextBox();
            txtProduto = new TextBox();
            btnProduto = new Button();
            btnCarregar = new Button();
            btnLimpar = new Button();
            label4 = new Label();
            txtIdProduto = new TextBox();
            TabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            dtFinal = new DateTimePicker();
            dtInicial = new DateTimePicker();
            label9 = new Label();
            chkDeletar = new CheckBox();
            dataLista = new DataGridView();
            Deletar = new DataGridViewCheckBoxColumn();
            lblTotal = new Label();
            btnImprimir = new Button();
            btnDeletar = new Button();
            btnBuscar = new Button();
            label2 = new Label();
            tabPage2 = new TabPage();
            ((System.ComponentModel.ISupportInitialize)errorIcone).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DataListaDetalhes).BeginInit();
            groupBox2.SuspendLayout();
            TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLista).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // ToolTip1
            // 
            ToolTip1.IsBalloon = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.WhiteSmoke;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(32, 44);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(218, 72);
            label1.TabIndex = 6;
            label1.Text = "Pedidos";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(1200, 710);
            btnSalvar.Margin = new Padding(2);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(169, 52);
            btnSalvar.TabIndex = 18;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(1421, 710);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(169, 52);
            btnCancelar.TabIndex = 20;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorIcone
            // 
            errorIcone.ContainerControl = this;
            // 
            // btnFornecedor
            // 
            btnFornecedor.BackColor = Color.White;
            btnFornecedor.BackgroundImage = (Image)resources.GetObject("btnFornecedor.BackgroundImage");
            btnFornecedor.BackgroundImageLayout = ImageLayout.Stretch;
            btnFornecedor.Cursor = Cursors.Hand;
            btnFornecedor.FlatStyle = FlatStyle.Popup;
            btnFornecedor.Location = new Point(1101, 59);
            btnFornecedor.Margin = new Padding(2);
            btnFornecedor.Name = "btnFornecedor";
            btnFornecedor.Size = new Size(49, 52);
            btnFornecedor.TabIndex = 26;
            btnFornecedor.UseVisualStyleBackColor = false;
            btnFornecedor.Click += btnFornecedor_Click;
            // 
            // txtFornecedor
            // 
            txtFornecedor.Location = new Point(810, 64);
            txtFornecedor.Margin = new Padding(2);
            txtFornecedor.Name = "txtFornecedor";
            txtFornecedor.Size = new Size(263, 43);
            txtFornecedor.TabIndex = 25;
            // 
            // btnNovo
            // 
            btnNovo.Location = new Point(966, 710);
            btnNovo.Margin = new Padding(2);
            btnNovo.Name = "btnNovo";
            btnNovo.Size = new Size(169, 52);
            btnNovo.TabIndex = 23;
            btnNovo.Text = "Novo";
            btnNovo.UseVisualStyleBackColor = true;
            btnNovo.Click += btnNovo_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbCorrelativo);
            groupBox1.Controls.Add(TotalPagar);
            groupBox1.Controls.Add(label16);
            groupBox1.Controls.Add(DataListaDetalhes);
            groupBox1.Controls.Add(txtImposto);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(txtSerie);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(cbComprovante);
            groupBox1.Controls.Add(dtData);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(btnFornecedor);
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(txtFornecedor);
            groupBox1.Controls.Add(txtIdFornecedor);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Location = new Point(6, 5);
            groupBox1.Margin = new Padding(2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(2);
            groupBox1.Size = new Size(1650, 772);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Pedidos";
            // 
            // cbCorrelativo
            // 
            cbCorrelativo.FormattingEnabled = true;
            cbCorrelativo.Items.AddRange(new object[] { "debito", "credito", "pix", "boleto" });
            cbCorrelativo.Location = new Point(810, 163);
            cbCorrelativo.Name = "cbCorrelativo";
            cbCorrelativo.Size = new Size(272, 45);
            cbCorrelativo.TabIndex = 49;
            // 
            // TotalPagar
            // 
            TotalPagar.AutoSize = true;
            TotalPagar.Location = new Point(210, 713);
            TotalPagar.Margin = new Padding(2, 0, 2, 0);
            TotalPagar.Name = "TotalPagar";
            TotalPagar.Size = new Size(53, 37);
            TotalPagar.TabIndex = 48;
            TotalPagar.Text = "0.0";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(17, 713);
            label16.Margin = new Padding(2, 0, 2, 0);
            label16.Name = "label16";
            label16.Size = new Size(194, 37);
            label16.TabIndex = 47;
            label16.Text = "Total à Pagar =";
            // 
            // DataListaDetalhes
            // 
            DataListaDetalhes.AllowUserToAddRows = false;
            DataListaDetalhes.AllowUserToDeleteRows = false;
            DataListaDetalhes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataListaDetalhes.Location = new Point(0, 479);
            DataListaDetalhes.Margin = new Padding(2);
            DataListaDetalhes.Name = "DataListaDetalhes";
            DataListaDetalhes.RowHeadersWidth = 102;
            DataListaDetalhes.Size = new Size(1622, 212);
            DataListaDetalhes.TabIndex = 38;
            // 
            // txtImposto
            // 
            txtImposto.Location = new Point(1421, 160);
            txtImposto.Margin = new Padding(2);
            txtImposto.Name = "txtImposto";
            txtImposto.Size = new Size(203, 43);
            txtImposto.TabIndex = 36;
            txtImposto.Text = "0";
            txtImposto.TextChanged += textBox1_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(1275, 160);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(115, 37);
            label12.TabIndex = 35;
            label12.Text = "Imposto";
            // 
            // txtSerie
            // 
            txtSerie.Location = new Point(677, 163);
            txtSerie.Margin = new Padding(2);
            txtSerie.Name = "txtSerie";
            txtSerie.Size = new Size(122, 43);
            txtSerie.TabIndex = 33;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(510, 163);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(114, 37);
            label11.TabIndex = 32;
            label11.Text = "Número";
            // 
            // cbComprovante
            // 
            cbComprovante.FormattingEnabled = true;
            cbComprovante.Items.AddRange(new object[] { "Nota Fiscal", "Recibo", "Nota Carioca" });
            cbComprovante.Location = new Point(197, 163);
            cbComprovante.Margin = new Padding(2);
            cbComprovante.Name = "cbComprovante";
            cbComprovante.Size = new Size(268, 45);
            cbComprovante.TabIndex = 31;
            // 
            // dtData
            // 
            dtData.Format = DateTimePickerFormat.Short;
            dtData.Location = new Point(1380, 69);
            dtData.Margin = new Padding(2);
            dtData.Name = "dtData";
            dtData.Size = new Size(173, 43);
            dtData.TabIndex = 30;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1275, 69);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(73, 37);
            label10.TabIndex = 29;
            label10.Text = "Data";
            // 
            // txtIdFornecedor
            // 
            txtIdFornecedor.Location = new Point(677, 64);
            txtIdFornecedor.Margin = new Padding(2);
            txtIdFornecedor.Name = "txtIdFornecedor";
            txtIdFornecedor.Size = new Size(118, 43);
            txtIdFornecedor.TabIndex = 24;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(510, 64);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(151, 37);
            label7.TabIndex = 23;
            label7.Text = "Fornecedor";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(9, 163);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(179, 37);
            label6.TabIndex = 21;
            label6.Text = "Comprovante";
            // 
            // txtId
            // 
            txtId.Enabled = false;
            txtId.Location = new Point(186, 64);
            txtId.Margin = new Padding(2);
            txtId.Name = "txtId";
            txtId.Size = new Size(225, 43);
            txtId.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 69);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(43, 37);
            label3.TabIndex = 12;
            label3.Text = "ID";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtDataValidade);
            groupBox2.Controls.Add(label15);
            groupBox2.Controls.Add(dtDataPedido);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(txtPrecoVenda);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(txtPrecoCompra);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(txtEstoqueInicial);
            groupBox2.Controls.Add(txtProduto);
            groupBox2.Controls.Add(btnProduto);
            groupBox2.Controls.Add(btnCarregar);
            groupBox2.Controls.Add(btnLimpar);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(txtIdProduto);
            groupBox2.Location = new Point(0, 227);
            groupBox2.Margin = new Padding(2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(2);
            groupBox2.Size = new Size(1622, 247);
            groupBox2.TabIndex = 37;
            groupBox2.TabStop = false;
            groupBox2.Text = "Detalhes";
            // 
            // dtDataValidade
            // 
            dtDataValidade.Format = DateTimePickerFormat.Short;
            dtDataValidade.Location = new Point(1166, 160);
            dtDataValidade.Margin = new Padding(2);
            dtDataValidade.Name = "dtDataValidade";
            dtDataValidade.Size = new Size(173, 43);
            dtDataValidade.TabIndex = 46;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(986, 165);
            label15.Margin = new Padding(2, 0, 2, 0);
            label15.Name = "label15";
            label15.Size = new Size(183, 37);
            label15.TabIndex = 45;
            label15.Text = "Data Validade";
            // 
            // dtDataPedido
            // 
            dtDataPedido.Format = DateTimePickerFormat.Short;
            dtDataPedido.Location = new Point(1166, 94);
            dtDataPedido.Margin = new Padding(2);
            dtDataPedido.Name = "dtDataPedido";
            dtDataPedido.Size = new Size(173, 43);
            dtDataPedido.TabIndex = 39;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(986, 99);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(163, 37);
            label14.TabIndex = 38;
            label14.Text = "Data Pedido";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(594, 160);
            label13.Margin = new Padding(2, 0, 2, 0);
            label13.Name = "label13";
            label13.Size = new Size(164, 37);
            label13.TabIndex = 43;
            label13.Text = "Preço Venda";
            // 
            // txtPrecoVenda
            // 
            txtPrecoVenda.Location = new Point(780, 158);
            txtPrecoVenda.Margin = new Padding(2);
            txtPrecoVenda.Name = "txtPrecoVenda";
            txtPrecoVenda.Size = new Size(156, 43);
            txtPrecoVenda.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(594, 91);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(185, 37);
            label8.TabIndex = 41;
            label8.Text = "Preço Compra";
            // 
            // txtPrecoCompra
            // 
            txtPrecoCompra.Location = new Point(780, 91);
            txtPrecoCompra.Margin = new Padding(2);
            txtPrecoCompra.Name = "txtPrecoCompra";
            txtPrecoCompra.Size = new Size(156, 43);
            txtPrecoCompra.TabIndex = 42;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(17, 155);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(188, 37);
            label5.TabIndex = 39;
            label5.Text = "Estoque Inicial";
            // 
            // txtEstoqueInicial
            // 
            txtEstoqueInicial.Location = new Point(261, 155);
            txtEstoqueInicial.Margin = new Padding(2);
            txtEstoqueInicial.Name = "txtEstoqueInicial";
            txtEstoqueInicial.Size = new Size(199, 43);
            txtEstoqueInicial.TabIndex = 40;
            // 
            // txtProduto
            // 
            txtProduto.Location = new Point(261, 86);
            txtProduto.Margin = new Padding(2);
            txtProduto.Name = "txtProduto";
            txtProduto.Size = new Size(199, 43);
            txtProduto.TabIndex = 38;
            // 
            // btnProduto
            // 
            btnProduto.BackColor = Color.White;
            btnProduto.BackgroundImage = (Image)resources.GetObject("btnProduto.BackgroundImage");
            btnProduto.BackgroundImageLayout = ImageLayout.Stretch;
            btnProduto.Cursor = Cursors.Hand;
            btnProduto.FlatStyle = FlatStyle.Popup;
            btnProduto.Location = new Point(495, 84);
            btnProduto.Margin = new Padding(2);
            btnProduto.Name = "btnProduto";
            btnProduto.Size = new Size(45, 49);
            btnProduto.TabIndex = 38;
            btnProduto.UseVisualStyleBackColor = false;
            btnProduto.Click += button1_Click;
            // 
            // btnCarregar
            // 
            btnCarregar.BackColor = Color.Transparent;
            btnCarregar.BackgroundImage = Properties.Resources._299068_add_sign_icon;
            btnCarregar.BackgroundImageLayout = ImageLayout.Stretch;
            btnCarregar.Cursor = Cursors.Hand;
            btnCarregar.Location = new Point(1391, 118);
            btnCarregar.Margin = new Padding(2);
            btnCarregar.Name = "btnCarregar";
            btnCarregar.Size = new Size(71, 72);
            btnCarregar.TabIndex = 14;
            btnCarregar.UseVisualStyleBackColor = false;
            btnCarregar.Click += btnCarregar_Click;
            // 
            // btnLimpar
            // 
            btnLimpar.BackgroundImage = Properties.Resources._9004715_cross_delete_remove_cancel_icon;
            btnLimpar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpar.Cursor = Cursors.Hand;
            btnLimpar.Location = new Point(1500, 118);
            btnLimpar.Margin = new Padding(2);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(71, 72);
            btnLimpar.TabIndex = 16;
            btnLimpar.UseVisualStyleBackColor = true;
            btnLimpar.Click += btnLimpar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(17, 86);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 37);
            label4.TabIndex = 13;
            label4.Text = "Produto";
            // 
            // txtIdProduto
            // 
            txtIdProduto.Location = new Point(163, 86);
            txtIdProduto.Margin = new Padding(2);
            txtIdProduto.Name = "txtIdProduto";
            txtIdProduto.Size = new Size(79, 43);
            txtIdProduto.TabIndex = 16;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tabPage1);
            TabControl1.Controls.Add(tabPage2);
            TabControl1.Location = new Point(32, 138);
            TabControl1.Margin = new Padding(2);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(1674, 829);
            TabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(dtFinal);
            tabPage1.Controls.Add(dtInicial);
            tabPage1.Controls.Add(label9);
            tabPage1.Controls.Add(chkDeletar);
            tabPage1.Controls.Add(dataLista);
            tabPage1.Controls.Add(lblTotal);
            tabPage1.Controls.Add(btnImprimir);
            tabPage1.Controls.Add(btnDeletar);
            tabPage1.Controls.Add(btnBuscar);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(10, 55);
            tabPage1.Margin = new Padding(2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(2);
            tabPage1.Size = new Size(1654, 764);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Listar";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(1089, 54);
            button1.Name = "button1";
            button1.Size = new Size(169, 52);
            button1.TabIndex = 11;
            button1.Text = "A pagar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // dtFinal
            // 
            dtFinal.Format = DateTimePickerFormat.Short;
            dtFinal.Location = new Point(184, 86);
            dtFinal.Margin = new Padding(2);
            dtFinal.Name = "dtFinal";
            dtFinal.Size = new Size(173, 43);
            dtFinal.TabIndex = 10;
            // 
            // dtInicial
            // 
            dtInicial.Format = DateTimePickerFormat.Short;
            dtInicial.Location = new Point(184, 30);
            dtInicial.Margin = new Padding(2);
            dtInicial.Name = "dtInicial";
            dtInicial.Size = new Size(173, 43);
            dtInicial.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(17, 86);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(136, 37);
            label9.TabIndex = 8;
            label9.Text = "Data Final";
            // 
            // chkDeletar
            // 
            chkDeletar.AutoSize = true;
            chkDeletar.Location = new Point(17, 133);
            chkDeletar.Margin = new Padding(2);
            chkDeletar.Name = "chkDeletar";
            chkDeletar.Size = new Size(126, 41);
            chkDeletar.TabIndex = 7;
            chkDeletar.Text = "Anular";
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
            dataLista.Location = new Point(17, 173);
            dataLista.Margin = new Padding(2);
            dataLista.MultiSelect = false;
            dataLista.Name = "dataLista";
            dataLista.ReadOnly = true;
            dataLista.RowHeadersWidth = 92;
            dataLista.RowTemplate.Height = 55;
            dataLista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataLista.Size = new Size(1622, 590);
            dataLista.TabIndex = 6;
            dataLista.CellContentClick += dataLista_CellContentClick;
            dataLista.DoubleClick += dataLista_DoubleClick;
            // 
            // Deletar
            // 
            Deletar.HeaderText = "Anular";
            Deletar.MinimumWidth = 11;
            Deletar.Name = "Deletar";
            Deletar.ReadOnly = true;
            Deletar.Width = 225;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(1189, 133);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(90, 37);
            lblTotal.TabIndex = 5;
            lblTotal.Text = "label3";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(876, 54);
            btnImprimir.Margin = new Padding(2);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(169, 52);
            btnImprimir.TabIndex = 4;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = true;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(675, 54);
            btnDeletar.Margin = new Padding(2);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(169, 52);
            btnDeletar.TabIndex = 3;
            btnDeletar.Text = "Anular";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(478, 54);
            btnBuscar.Margin = new Padding(2);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(169, 52);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(17, 30);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(149, 37);
            label2.TabIndex = 0;
            label2.Text = "Data Inicial";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(groupBox1);
            tabPage2.Location = new Point(10, 55);
            tabPage2.Margin = new Padding(2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(2);
            tabPage2.Size = new Size(1654, 764);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Configurar";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // frmEntrada
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1809, 999);
            Controls.Add(label1);
            Controls.Add(TabControl1);
            Margin = new Padding(2);
            Name = "frmEntrada";
            Text = "Pedidos";
            FormClosed += frmEntrada_FormClosed;
            Load += frmEntrada_Load;
            ((System.ComponentModel.ISupportInitialize)errorIcone).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DataListaDetalhes).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataLista).EndInit();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolTip ToolTip1;
        private Label label1;
        private Button btnSalvar;
        private Button btnCancelar;
        private ErrorProvider errorIcone;
        private TabControl TabControl1;
        private TabPage tabPage1;
        private CheckBox chkDeletar;
        private DataGridView dataLista;
        private Label lblTotal;
        private Button btnImprimir;
        private Button btnDeletar;
        private Button btnBuscar;
        private Label label2;
        private TabPage tabPage2;
        private Button btnNovo;
        private GroupBox groupBox1;
        private Button btnFornecedor;
        private TextBox txtFornecedor;
        private TextBox txtIdFornecedor;
        private Label label7;
        private Button btnLimpar;
        private Label label6;
        private Button btnCarregar;
        private TextBox txtId;
        private Label label3;
        private TextBox txtIdProduto;
        private Label label4;
        private Label label9;
        private DataGridViewCheckBoxColumn Deletar;
        private DateTimePicker dtFinal;
        private DateTimePicker dtInicial;
        private DateTimePicker dtData;
        private Label label10;
        private TextBox txtSerie;
        private Label label11;
        private ComboBox cbComprovante;
        private TextBox txtImposto;
        private Label label12;
        private GroupBox groupBox2;
        private Button btnProduto;
        private DateTimePicker dtDataValidade;
        private Label label15;
        private DateTimePicker dtDataPedido;
        private Label label14;
        private Label label13;
        private TextBox txtPrecoVenda;
        private Label label8;
        private TextBox txtPrecoCompra;
        private Label label5;
        private TextBox txtEstoqueInicial;
        private TextBox txtProduto;
        private Label TotalPagar;
        private Label label16;
        private DataGridView DataListaDetalhes;
        private Button button1;
        private ComboBox cbCorrelativo;
    }
}