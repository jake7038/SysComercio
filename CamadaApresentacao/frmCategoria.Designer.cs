namespace CamadaApresentacao
{
    partial class frmCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCategoria));
            label1 = new Label();
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
            groupBox1 = new GroupBox();
            btnCancelar = new Button();
            btnNovo = new Button();
            btnEditar = new Button();
            btnSalvar = new Button();
            txtDescricao = new TextBox();
            txtNome = new TextBox();
            txtIdCategoria = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            errorIcone = new ErrorProvider(components);
            ToolTip1 = new ToolTip(components);
            TabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataLista).BeginInit();
            tabPage2.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcone).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(6, 4);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 32);
            label1.TabIndex = 0;
            label1.Text = "Categorias";
            label1.Click += label1_Click;
            // 
            // TabControl1
            // 
            TabControl1.Controls.Add(tabPage1);
            TabControl1.Controls.Add(tabPage2);
            TabControl1.Location = new Point(6, 48);
            TabControl1.Margin = new Padding(1, 1, 1, 1);
            TabControl1.Name = "TabControl1";
            TabControl1.SelectedIndex = 0;
            TabControl1.Size = new Size(581, 254);
            TabControl1.TabIndex = 1;
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
            chkDeletar.Location = new Point(8, 41);
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
            lblTotal.Location = new Point(385, 42);
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
            label2.Location = new Point(15, 17);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 0;
            label2.Text = "Nome";
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
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCancelar);
            groupBox1.Controls.Add(btnNovo);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnSalvar);
            groupBox1.Controls.Add(txtDescricao);
            groupBox1.Controls.Add(txtNome);
            groupBox1.Controls.Add(txtIdCategoria);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Location = new Point(3, 2);
            groupBox1.Margin = new Padding(1, 1, 1, 1);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(1, 1, 1, 1);
            groupBox1.Size = new Size(567, 223);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Categorias";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(356, 144);
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
            btnNovo.Location = new Point(45, 144);
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
            btnEditar.Location = new Point(244, 144);
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
            btnSalvar.Location = new Point(144, 144);
            btnSalvar.Margin = new Padding(1, 1, 1, 1);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(79, 21);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // txtDescricao
            // 
            txtDescricao.Location = new Point(96, 95);
            txtDescricao.Margin = new Padding(1, 1, 1, 1);
            txtDescricao.Multiline = true;
            txtDescricao.Name = "txtDescricao";
            txtDescricao.ScrollBars = ScrollBars.Vertical;
            txtDescricao.Size = new Size(201, 38);
            txtDescricao.TabIndex = 5;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(96, 64);
            txtNome.Margin = new Padding(1, 1, 1, 1);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(107, 23);
            txtNome.TabIndex = 4;
            // 
            // txtIdCategoria
            // 
            txtIdCategoria.Location = new Point(96, 27);
            txtIdCategoria.Margin = new Padding(1, 1, 1, 1);
            txtIdCategoria.Name = "txtIdCategoria";
            txtIdCategoria.Size = new Size(107, 23);
            txtIdCategoria.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(21, 98);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 2;
            label5.Text = "descricao";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 66);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(40, 15);
            label4.TabIndex = 1;
            label4.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 29);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 0;
            label3.Text = "Código";
            // 
            // errorIcone
            // 
            errorIcone.ContainerControl = this;
            // 
            // ToolTip1
            // 
            ToolTip1.IsBalloon = true;
            // 
            // frmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(602, 318);
            Controls.Add(TabControl1);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(1, 1, 1, 1);
            Name = "frmCategoria";
            Text = "Controle de Categorias";
            Load += frmCategoria_Load;
            TabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataLista).EndInit();
            tabPage2.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorIcone).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TabControl TabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Button btnImprimir;
        private Button btnDeletar;
        private Button btnBuscar;
        private TextBox txtBuscar;
        private Label label2;
        private Label lblTotal;
        private DataGridView dataLista;
        private CheckBox chkDeletar;
        private DataGridViewCheckBoxColumn Deletar;
        private GroupBox groupBox1;
        private Button btnSalvar;
        private TextBox txtDescricao;
        private TextBox txtNome;
        private TextBox txtIdCategoria;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button btnCancelar;
        private Button btnNovo;
        private Button btnEditar;
        private ErrorProvider errorIcone;
        private ToolTip ToolTip1;
    }
}