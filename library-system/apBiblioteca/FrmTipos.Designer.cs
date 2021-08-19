namespace apBiblioteca
{
    partial class FrmTipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTipos));
            this.ssMensagem = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlbMensagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.txtNomeTipo = new System.Windows.Forms.TextBox();
            this.txtCodigoTipo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpLista = new System.Windows.Forms.TabPage();
            this.lsbTipos = new System.Windows.Forms.ListBox();
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
            this.imlBotoes = new System.Windows.Forms.ImageList(this.components);
            this.ssMensagem.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tpCadastro.SuspendLayout();
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
            this.ssMensagem.Location = new System.Drawing.Point(0, 154);
            this.ssMensagem.Name = "ssMensagem";
            this.ssMensagem.Size = new System.Drawing.Size(618, 22);
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
            // tabControl2
            // 
            this.tabControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl2.Controls.Add(this.tpCadastro);
            this.tabControl2.Controls.Add(this.tpLista);
            this.tabControl2.Location = new System.Drawing.Point(0, 43);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(618, 109);
            this.tabControl2.TabIndex = 4;
            // 
            // tpCadastro
            // 
            this.tpCadastro.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tpCadastro.Controls.Add(this.txtNomeTipo);
            this.tpCadastro.Controls.Add(this.txtCodigoTipo);
            this.tpCadastro.Controls.Add(this.label2);
            this.tpCadastro.Controls.Add(this.label1);
            this.tpCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpCadastro.Location = new System.Drawing.Point(4, 22);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(3);
            this.tpCadastro.Size = new System.Drawing.Size(610, 83);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            this.tpCadastro.Enter += new System.EventHandler(this.TpCadastro_Enter);
            // 
            // txtNomeTipo
            // 
            this.txtNomeTipo.Location = new System.Drawing.Point(93, 44);
            this.txtNomeTipo.MaxLength = 20;
            this.txtNomeTipo.Name = "txtNomeTipo";
            this.txtNomeTipo.Size = new System.Drawing.Size(296, 26);
            this.txtNomeTipo.TabIndex = 4;
            // 
            // txtCodigoTipo
            // 
            this.txtCodigoTipo.Location = new System.Drawing.Point(93, 12);
            this.txtCodigoTipo.MaxLength = 2;
            this.txtCodigoTipo.Name = "txtCodigoTipo";
            this.txtCodigoTipo.Size = new System.Drawing.Size(38, 26);
            this.txtCodigoTipo.TabIndex = 3;
            this.txtCodigoTipo.Leave += new System.EventHandler(this.TxtCodigoTipo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tpLista
            // 
            this.tpLista.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tpLista.Controls.Add(this.lsbTipos);
            this.tpLista.Location = new System.Drawing.Point(4, 22);
            this.tpLista.Name = "tpLista";
            this.tpLista.Padding = new System.Windows.Forms.Padding(3);
            this.tpLista.Size = new System.Drawing.Size(610, 83);
            this.tpLista.TabIndex = 1;
            this.tpLista.Text = "Lista";
            this.tpLista.Enter += new System.EventHandler(this.TpLista_Enter);
            // 
            // lsbTipos
            // 
            this.lsbTipos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbTipos.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbTipos.FormattingEnabled = true;
            this.lsbTipos.ItemHeight = 16;
            this.lsbTipos.Location = new System.Drawing.Point(8, 6);
            this.lsbTipos.Name = "lsbTipos";
            this.lsbTipos.Size = new System.Drawing.Size(596, 68);
            this.lsbTipos.TabIndex = 0;
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
            this.barraDeFerramentas.Size = new System.Drawing.Size(618, 38);
            this.barraDeFerramentas.TabIndex = 3;
            this.barraDeFerramentas.Text = "toolStrip1";
            // 
            // btnInicio
            // 
            this.btnInicio.Image = ((System.Drawing.Image)(resources.GetObject("btnInicio.Image")));
            this.btnInicio.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btnInicio.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnInicio.Margin = new System.Windows.Forms.Padding(40, 1, 0, 2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(40, 35);
            this.btnInicio.Text = "Início";
            this.btnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnInicio.ToolTipText = "Vai para o início dos dados";
            this.btnInicio.Click += new System.EventHandler(this.BtnInicio_Click_1);
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
            this.btnAnterior.Click += new System.EventHandler(this.BtnAnterior_Click_1);
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
            this.btnProximo.Click += new System.EventHandler(this.BtnProximo_Click_1);
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
            this.btnUltimo.Click += new System.EventHandler(this.BtnUltimo_Click_1);
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
            this.btnProcurar.Click += new System.EventHandler(this.BtnProcurar_Click_1);
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
            this.btnNovo.Click += new System.EventHandler(this.BtnNovo_Click_1);
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
            this.btnEditar.Click += new System.EventHandler(this.BtnEditar_Click_1);
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
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click_1);
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
            this.btnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click_1);
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
            this.btnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click_1);
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
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click_1);
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
            // 
            // FrmTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(618, 176);
            this.Controls.Add(this.ssMensagem);
            this.Controls.Add(this.tabControl2);
            this.Controls.Add(this.barraDeFerramentas);
            this.Name = "FrmTipos";
            this.Text = "Manutenção de tipos de livros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmTipos_Load);
            this.ssMensagem.ResumeLayout(false);
            this.ssMensagem.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.tpCadastro.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.TextBox txtNomeTipo;
        private System.Windows.Forms.TextBox txtCodigoTipo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpLista;
        private System.Windows.Forms.ListBox lsbTipos;
        private System.Windows.Forms.ToolStrip barraDeFerramentas;
        private System.Windows.Forms.ToolStripButton btnInicio;
        private System.Windows.Forms.ToolStripButton btnAnterior;
        private System.Windows.Forms.ToolStripButton btnProximo;
        private System.Windows.Forms.ToolStripButton btnUltimo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnProcurar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnNovo;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnExcluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnSair;
        private System.Windows.Forms.ImageList imlBotoes;
    }
}