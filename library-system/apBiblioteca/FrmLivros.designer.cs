namespace apBiblioteca
{
  partial class FrmLivros
  {
    /// <summary>
    /// Variável de designer necessária.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpar os recursos que estão sendo usados.
    /// </summary>
    /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código gerado pelo Windows Form Designer

    /// <summary>
    /// Método necessário para suporte ao Designer - não modifique 
    /// o conteúdo deste método com o editor de código.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivros));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.barraDeFerramentas = new System.Windows.Forms.ToolStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProcurar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNovo = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnSalvar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnExcluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoLeitor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnderecoLeitor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            this.CodigoLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTituloLivro = new System.Windows.Forms.TextBox();
            this.txtCodigoLivro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.lsbLivros = new System.Windows.Forms.ListBox();
            this.ssMensagem = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.imlBotoes = new System.Windows.Forms.ImageList(this.components);
            this.barraDeFerramentas.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
            this.tpLista.SuspendLayout();
            this.ssMensagem.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraDeFerramentas
            // 
            this.barraDeFerramentas.BackColor = System.Drawing.Color.Silver;
            this.barraDeFerramentas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barraDeFerramentas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barraDeFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
            this.toolStripSeparator1,
            this.btnProcurar,
            this.toolStripSeparator2,
            this.btnNovo,
            this.btnEditar,
            this.btnCancelar,
            this.btnSalvar,
            this.toolStripSeparator3,
            this.btnExcluir,
            this.toolStripSeparator4,
            this.btnSair});
            this.barraDeFerramentas.Location = new System.Drawing.Point(0, 0);
            this.barraDeFerramentas.Name = "barraDeFerramentas";
            this.barraDeFerramentas.Size = new System.Drawing.Size(611, 38);
            this.barraDeFerramentas.TabIndex = 0;
            this.barraDeFerramentas.Text = "toolStrip1";
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInicio.Margin = new System.Windows.Forms.Padding(35, 1, 0, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(40, 35);
            this.btnInicio.Text = "Início";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.ToolTipText = "Vai para o início dos dados";
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(54, 35);
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnterior.ToolTipText = " Vai ao registro anterior";
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(55, 35);
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximo.ToolTipText = "Avança para registro seguinte";
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(47, 35);
            this.btnUltimo.Text = "Último";
            this.btnUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUltimo.ToolTipText = "Posiciona no último registro";
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(56, 35);
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProcurar.ToolTipText = "Procura registro através de seu código";
            this.btnProcurar.Click += new System.EventHandler(this.btnProcurar_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(40, 35);
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNovo.ToolTipText = "Inclui novo registro em ordem de matrícula";
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(41, 35);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEditar.ToolTipText = "Permite alterar os dados do registro atual";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(57, 35);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.ToolTipText = "Cancela a operação atual";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSalvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(42, 35);
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSalvar.ToolTipText = "Armazena os valores atuais da tela";
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluir.Image")));
            this.btnExcluir.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnExcluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(45, 35);
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExcluir.ToolTipText = "Exclui o registro exibido na tela";
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(30, 35);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.ToolTipText = "Termina o programa";
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tpCadastro);
            this.tabControl2.Controls.Add(this.tpLista);
            this.tabControl2.Location = new System.Drawing.Point(0, 41);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(611, 352);
            this.tabControl2.TabIndex = 1;
            // 
            // tpCadastro
            // 
            this.tpCadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tpCadastro.Controls.Add(this.groupBox1);
            this.tpCadastro.Controls.Add(this.label3);
            this.tpCadastro.Controls.Add(this.dgvTipos);
            this.tpCadastro.Controls.Add(this.txtTituloLivro);
            this.tpCadastro.Controls.Add(this.txtCodigoLivro);
            this.tpCadastro.Controls.Add(this.label2);
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Location = new System.Drawing.Point(4, 27);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(603, 321);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCodigoLeitor);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtEnderecoLeitor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtNomeLeitor);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(21, 204);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 108);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leitor com este livro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Endereço:";
            // 
            // txtCodigoLeitor
            // 
            this.txtCodigoLeitor.BackColor = System.Drawing.Color.White;
            this.txtCodigoLeitor.Enabled = false;
            this.txtCodigoLeitor.Location = new System.Drawing.Point(98, 32);
            this.txtCodigoLeitor.MaxLength = 7;
            this.txtCodigoLeitor.Name = "txtCodigoLeitor";
            this.txtCodigoLeitor.Size = new System.Drawing.Size(83, 26);
            this.txtCodigoLeitor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(193, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome:";
            // 
            // txtEnderecoLeitor
            // 
            this.txtEnderecoLeitor.BackColor = System.Drawing.Color.White;
            this.txtEnderecoLeitor.Enabled = false;
            this.txtEnderecoLeitor.Location = new System.Drawing.Point(98, 68);
            this.txtEnderecoLeitor.Name = "txtEnderecoLeitor";
            this.txtEnderecoLeitor.Size = new System.Drawing.Size(422, 26);
            this.txtEnderecoLeitor.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Código:";
            // 
            // txtNomeLeitor
            // 
            this.txtNomeLeitor.BackColor = System.Drawing.Color.White;
            this.txtNomeLeitor.Enabled = false;
            this.txtNomeLeitor.Location = new System.Drawing.Point(254, 32);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(266, 26);
            this.txtNomeLeitor.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo:";
            // 
            // dgvTipos
            // 
            this.dgvTipos.AllowUserToAddRows = false;
            this.dgvTipos.AllowUserToDeleteRows = false;
            this.dgvTipos.AllowUserToResizeColumns = false;
            this.dgvTipos.AllowUserToResizeRows = false;
            this.dgvTipos.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoLivro,
            this.DescricaoLivro});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.DarkRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTipos.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTipos.Location = new System.Drawing.Point(93, 76);
            this.dgvTipos.MultiSelect = false;
            this.dgvTipos.Name = "dgvTipos";
            this.dgvTipos.ReadOnly = true;
            this.dgvTipos.RowHeadersVisible = false;
            this.dgvTipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTipos.Size = new System.Drawing.Size(489, 117);
            this.dgvTipos.TabIndex = 5;
            this.dgvTipos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipos_CellClick);
            this.dgvTipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipos_CellClick);
            this.dgvTipos.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipos_CellClick);
            this.dgvTipos.CellMouseEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipos_CellClick);
            this.dgvTipos.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTipos_CellClick);
            // 
            // CodigoLivro
            // 
            this.CodigoLivro.HeaderText = "Código";
            this.CodigoLivro.Name = "CodigoLivro";
            this.CodigoLivro.ReadOnly = true;
            this.CodigoLivro.Width = 75;
            // 
            // DescricaoLivro
            // 
            this.DescricaoLivro.HeaderText = "Descrição";
            this.DescricaoLivro.Name = "DescricaoLivro";
            this.DescricaoLivro.ReadOnly = true;
            this.DescricaoLivro.Width = 390;
            // 
            // txtTituloLivro
            // 
            this.txtTituloLivro.Location = new System.Drawing.Point(93, 44);
            this.txtTituloLivro.MaxLength = 30;
            this.txtTituloLivro.Name = "txtTituloLivro";
            this.txtTituloLivro.Size = new System.Drawing.Size(255, 26);
            this.txtTituloLivro.TabIndex = 4;
            this.txtTituloLivro.Leave += new System.EventHandler(this.txtTituloLivro_Leave);
            // 
            // txtCodigoLivro
            // 
            this.txtCodigoLivro.Location = new System.Drawing.Point(93, 12);
            this.txtCodigoLivro.MaxLength = 7;
            this.txtCodigoLivro.Name = "txtCodigoLivro";
            this.txtCodigoLivro.Size = new System.Drawing.Size(78, 26);
            this.txtCodigoLivro.TabIndex = 3;
            this.txtCodigoLivro.Leave += new System.EventHandler(this.txtCodigoGenero_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tpLista
            // 
            this.tpLista.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tpLista.Controls.Add(this.lsbLivros);
            this.tpLista.Location = new System.Drawing.Point(4, 27);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpLista.Size = new System.Drawing.Size(603, 321);
            this.tpLista.TabIndex = 1;
            this.tpLista.Text = "Lista";
            this.tpLista.Enter += new System.EventHandler(this.tpLista_Enter);
            // 
            // lsbLivros
            // 
            this.lsbLivros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbLivros.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbLivros.FormattingEnabled = true;
            this.lsbLivros.ItemHeight = 16;
            this.lsbLivros.Location = new System.Drawing.Point(8, 6);
            this.lsbLivros.Name = "lsbLivros";
            this.lsbLivros.Size = new System.Drawing.Size(587, 308);
            this.lsbLivros.TabIndex = 0;
            // 
            // ssMensagem
            // 
            this.ssMensagem.BackColor = System.Drawing.Color.Silver;
            this.ssMensagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stlbMensagem});
            this.ssMensagem.Location = new System.Drawing.Point(0, 400);
            this.ssMensagem.Name = "ssMensagem";
            this.ssMensagem.Size = new System.Drawing.Size(611, 22);
            this.ssMensagem.TabIndex = 2;
            this.ssMensagem.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(69, 17);
            this.toolStripStatusLabel1.Text = "Mensagem:";
            // 
            // stlbMensagem
            // 
            this.stlbMensagem.BackColor = System.Drawing.Color.Silver;
            this.stlbMensagem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.stlbMensagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stlbMensagem.Name = "stlbMensagem";
            this.stlbMensagem.Size = new System.Drawing.Size(56, 17);
            this.stlbMensagem.Text = "Bom dia!";
            // 
            // imlBotoes
            // 
            this.imlBotoes.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imlBotoes.ImageStream")));
            this.imlBotoes.TransparentColor = System.Drawing.Color.Transparent;
            this.imlBotoes.Images.SetKeyName(0, "first.bmp");
            this.imlBotoes.Images.SetKeyName(1, "prior.bmp");
            this.imlBotoes.Images.SetKeyName(2, "next.bmp");
            this.imlBotoes.Images.SetKeyName(3, "last.bmp");
            this.imlBotoes.Images.SetKeyName(4, "Oeil2.bmp");
            this.imlBotoes.Images.SetKeyName(5, "Add.bmp");
            this.imlBotoes.Images.SetKeyName(6, "COPY.BMP");
            this.imlBotoes.Images.SetKeyName(7, "UNDO.BMP");
            this.imlBotoes.Images.SetKeyName(8, "Save.bmp");
            this.imlBotoes.Images.SetKeyName(9, "Minus.bmp");
            this.imlBotoes.Images.SetKeyName(10, "CLOSE1.BMP");
            this.imlBotoes.Images.SetKeyName(11, "about.bmp");
            this.imlBotoes.Images.SetKeyName(12, "abort.bmp");
            this.imlBotoes.Images.SetKeyName(13, "FIND.BMP");
            this.imlBotoes.Images.SetKeyName(14, "PRINTER5.BMP");
            this.imlBotoes.Images.SetKeyName(15, "REDO.BMP");
            this.imlBotoes.Images.SetKeyName(16, "WINNEXT.BMP");
            this.imlBotoes.Images.SetKeyName(17, "WINPREV.BMP");
            // 
            // FrmLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 422);
            this.Controls.Add(this.ssMensagem);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.barraDeFerramentas);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmLivros";
            this.Text = "Manutenção de Livros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmFunc_Load);
            this.barraDeFerramentas.ResumeLayout(false);
            this.barraDeFerramentas.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
            this.tpLista.ResumeLayout(false);
            this.ssMensagem.ResumeLayout(false);
            this.ssMensagem.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.ToolStrip barraDeFerramentas;
    private System.Windows.Forms.TabControl tabControl2;
    private System.Windows.Forms.TabPage tpCadastro;
    private System.Windows.Forms.TabPage tpLista;
    private System.Windows.Forms.StatusStrip ssMensagem;
    private System.Windows.Forms.TextBox txtTituloLivro;
    private System.Windows.Forms.TextBox txtCodigoLivro;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.ToolStripButton btnInicio;
    private System.Windows.Forms.ToolStripButton btnAnterior;
    private System.Windows.Forms.ToolStripButton btnProximo;
    private System.Windows.Forms.ToolStripButton btnUltimo;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ImageList imlBotoes;
    private System.Windows.Forms.ToolStripButton btnProcurar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
    private System.Windows.Forms.ToolStripButton btnNovo;
    private System.Windows.Forms.ToolStripButton btnCancelar;
    private System.Windows.Forms.ToolStripButton btnSalvar;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    private System.Windows.Forms.ToolStripButton btnExcluir;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    private System.Windows.Forms.ToolStripButton btnSair;
    private System.Windows.Forms.ToolStripButton btnEditar;
    private System.Windows.Forms.ToolStripStatusLabel stlbMensagem;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ListBox lsbLivros;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTipos;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoLivro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoLeitor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnderecoLeitor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeLeitor;
    }
}

