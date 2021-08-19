namespace apBiblioteca
{
    partial class FrmLivrosConsulta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmLivrosConsulta));
            this.ssMensagem = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTipoLivro = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoLeitor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEnderecoLeitor = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeLeitor = new System.Windows.Forms.TextBox();
            this.txtNomeLivro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigoLivro = new System.Windows.Forms.TextBox();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.lsbLivros = new System.Windows.Forms.ListBox();
            this.barraDeFerramentas = new System.Windows.Forms.ToolStrip();
            this.btnInicio = new System.Windows.Forms.ToolStripButton();
            this.btnAnterior = new System.Windows.Forms.ToolStripButton();
            this.btnProximo = new System.Windows.Forms.ToolStripButton();
            this.btnUltimo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnProcurar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSair = new System.Windows.Forms.ToolStripButton();
            this.imlBotoes = new System.Windows.Forms.ImageList(this.components);
            this.ssMensagem.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpLista.SuspendLayout();
            this.barraDeFerramentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssMensagem
            // 
            this.ssMensagem.BackColor = System.Drawing.Color.Silver;
            this.ssMensagem.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stlbMensagem});
            this.ssMensagem.Location = new System.Drawing.Point(58, 304);
            this.ssMensagem.Name = "ssMensagem";
            this.ssMensagem.Size = new System.Drawing.Size(501, 22);
            this.ssMensagem.TabIndex = 5;
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
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tpCadastro);
            this.tabControl1.Controls.Add(this.tpLista);
            this.tabControl1.Location = new System.Drawing.Point(60, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(499, 300);
            this.tabControl1.TabIndex = 4;
            // 
            // tpCadastro
            // 
            this.tpCadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Controls.Add(this.label2);
            this.tpCadastro.Controls.Add(this.txtTipoLivro);
            this.tpCadastro.Controls.Add(this.groupBox1);
            this.tpCadastro.Controls.Add(this.txtNomeLivro);
            this.tpCadastro.Controls.Add(this.label3);
            this.tpCadastro.Controls.Add(this.txtCodigoLivro);
            this.tpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(491, 274);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.Enter += new System.EventHandler(this.TpCadastro_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(26, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // txtTipoLivro
            // 
            this.txtTipoLivro.BackColor = System.Drawing.Color.White;
            this.txtTipoLivro.Enabled = false;
            this.txtTipoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipoLivro.Location = new System.Drawing.Point(114, 78);
            this.txtTipoLivro.MaxLength = 50;
            this.txtTipoLivro.Name = "txtTipoLivro";
            this.txtTipoLivro.Size = new System.Drawing.Size(141, 26);
            this.txtTipoLivro.TabIndex = 6;
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
            this.groupBox1.Location = new System.Drawing.Point(16, 125);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 135);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Leitor com este livro:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 95);
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
            this.label5.Location = new System.Drawing.Point(11, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nome:";
            // 
            // txtEnderecoLeitor
            // 
            this.txtEnderecoLeitor.BackColor = System.Drawing.Color.White;
            this.txtEnderecoLeitor.Enabled = false;
            this.txtEnderecoLeitor.Location = new System.Drawing.Point(98, 92);
            this.txtEnderecoLeitor.Name = "txtEnderecoLeitor";
            this.txtEnderecoLeitor.Size = new System.Drawing.Size(333, 26);
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
            this.txtNomeLeitor.Location = new System.Drawing.Point(98, 62);
            this.txtNomeLeitor.Name = "txtNomeLeitor";
            this.txtNomeLeitor.Size = new System.Drawing.Size(256, 26);
            this.txtNomeLeitor.TabIndex = 10;
            // 
            // txtNomeLivro
            // 
            this.txtNomeLivro.BackColor = System.Drawing.Color.White;
            this.txtNomeLivro.Enabled = false;
            this.txtNomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeLivro.Location = new System.Drawing.Point(114, 47);
            this.txtNomeLivro.MaxLength = 35;
            this.txtNomeLivro.Name = "txtNomeLivro";
            this.txtNomeLivro.Size = new System.Drawing.Size(233, 26);
            this.txtNomeLivro.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tipo:";
            // 
            // txtCodigoLivro
            // 
            this.txtCodigoLivro.BackColor = System.Drawing.Color.White;
            this.txtCodigoLivro.Enabled = false;
            this.txtCodigoLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigoLivro.Location = new System.Drawing.Point(114, 16);
            this.txtCodigoLivro.MaxLength = 7;
            this.txtCodigoLivro.Name = "txtCodigoLivro";
            this.txtCodigoLivro.Size = new System.Drawing.Size(100, 26);
            this.txtCodigoLivro.TabIndex = 1;
            this.txtCodigoLivro.Leave += new System.EventHandler(this.TxtCodigoLivro_Leave);
            // 
            // tpLista
            // 
            this.tpLista.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tpLista.Controls.Add(this.lsbLivros);
            this.tpLista.Location = new System.Drawing.Point(4, 22);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpLista.Size = new System.Drawing.Size(491, 274);
            this.tpLista.TabIndex = 1;
            this.tpLista.Text = "Lista";
            this.tpLista.Enter += new System.EventHandler(this.TpLista_Enter);
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
            this.lsbLivros.Size = new System.Drawing.Size(471, 260);
            this.lsbLivros.TabIndex = 0;
            // 
            // barraDeFerramentas
            // 
            this.barraDeFerramentas.BackColor = System.Drawing.Color.Silver;
            this.barraDeFerramentas.CanOverflow = false;
            this.barraDeFerramentas.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraDeFerramentas.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.barraDeFerramentas.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.barraDeFerramentas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnInicio,
            this.btnAnterior,
            this.btnProximo,
            this.btnUltimo,
            this.toolStripSeparator1,
            this.btnProcurar,
            this.btnCancelar,
            this.toolStripSeparator2,
            this.btnSair});
            this.barraDeFerramentas.Location = new System.Drawing.Point(0, 0);
            this.barraDeFerramentas.Name = "barraDeFerramentas";
            this.barraDeFerramentas.Size = new System.Drawing.Size(58, 326);
            this.barraDeFerramentas.TabIndex = 3;
            this.barraDeFerramentas.Text = "toolStrip1";
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInicio.Margin = new System.Windows.Forms.Padding(0, 10, 0, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(55, 35);
            this.btnInicio.Text = "Início";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.ToolTipText = "Vai para o início dos dados";
            this.btnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Image = ((System.Drawing.Image)(resources.GetObject("btnAnterior.Image")));
            this.btnAnterior.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnAnterior.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(55, 35);
            this.btnAnterior.Text = "Anterior";
            this.btnAnterior.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnAnterior.ToolTipText = " Vai ao registro anterior";
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProximo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProximo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(55, 35);
            this.btnProximo.Text = "Próximo";
            this.btnProximo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProximo.ToolTipText = "Avança para registro seguinte";
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnUltimo.Image")));
            this.btnUltimo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnUltimo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(55, 35);
            this.btnUltimo.Text = "Último";
            this.btnUltimo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnUltimo.ToolTipText = "Posiciona no último registro";
            this.btnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(55, 6);
            // 
            // btnProcurar
            // 
            this.btnProcurar.Image = ((System.Drawing.Image)(resources.GetObject("btnProcurar.Image")));
            this.btnProcurar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnProcurar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnProcurar.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(55, 35);
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnProcurar.ToolTipText = "Procura registro através de seu código";
            this.btnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(55, 35);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelar.ToolTipText = "Procura registro através de seu código";
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(55, 6);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnSair.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSair.Margin = new System.Windows.Forms.Padding(0, 5, 0, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(55, 35);
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSair.ToolTipText = "Termina o programa";
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
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
            this.imlBotoes.Images.SetKeyName(5, "UNDO.BMP");
            this.imlBotoes.Images.SetKeyName(6, "CLOSE1.BMP");
            // 
            // FrmLivrosConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 326);
            this.Controls.Add(this.ssMensagem);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.barraDeFerramentas);
            this.Name = "FrmLivrosConsulta";
            this.Text = "Consulta de Livros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmLivrosConsulta_Load);
            this.ssMensagem.ResumeLayout(false);
            this.ssMensagem.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpLista.ResumeLayout(false);
            this.barraDeFerramentas.ResumeLayout(false);
            this.barraDeFerramentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssMensagem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stlbMensagem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.TextBox txtTipoLivro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomeLivro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpLista;
        private System.Windows.Forms.ListBox lsbLivros;
        private System.Windows.Forms.ToolStrip barraDeFerramentas;
        private System.Windows.Forms.ToolStripButton btnInicio;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ImageList imlBotoes;
        private System.Windows.Forms.TextBox txtCodigoLivro;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoLeitor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEnderecoLeitor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeLeitor;
        private System.Windows.Forms.ToolStripButton btnProcurar;
    }
}