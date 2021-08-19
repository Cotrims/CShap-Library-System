namespace apBiblioteca
{
  partial class FrmBiblioteca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBiblioteca));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manutençãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.leitoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.sairToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empréstimosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devoluçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.livrosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.leitoresToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dlgAbrir = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manutençãoToolStripMenuItem,
            this.operaçõesToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(430, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manutençãoToolStripMenuItem
            // 
            this.manutençãoToolStripMenuItem.BackColor = System.Drawing.Color.White;
            this.manutençãoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem,
            this.toolStripMenuItem2,
            this.leitoresToolStripMenuItem,
            this.toolStripMenuItem1,
            this.sairToolStripMenuItem1});
            this.manutençãoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manutençãoToolStripMenuItem.Margin = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.manutençãoToolStripMenuItem.Name = "manutençãoToolStripMenuItem";
            this.manutençãoToolStripMenuItem.Size = new System.Drawing.Size(108, 25);
            this.manutençãoToolStripMenuItem.Text = "Manutenção";
            // 
            // livrosToolStripMenuItem
            // 
            this.livrosToolStripMenuItem.Name = "livrosToolStripMenuItem";
            this.livrosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.livrosToolStripMenuItem.Text = "Livros";
            this.livrosToolStripMenuItem.Click += new System.EventHandler(this.livrosToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 26);
            this.toolStripMenuItem2.Text = "Tipos de livro";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.ToolStripMenuItem2_Click);
            // 
            // leitoresToolStripMenuItem
            // 
            this.leitoresToolStripMenuItem.Name = "leitoresToolStripMenuItem";
            this.leitoresToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.leitoresToolStripMenuItem.Text = "Leitores";
            this.leitoresToolStripMenuItem.Click += new System.EventHandler(this.leitoresToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(177, 6);
            // 
            // sairToolStripMenuItem1
            // 
            this.sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            this.sairToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.sairToolStripMenuItem1.Text = "Sair";
            this.sairToolStripMenuItem1.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.empréstimosToolStripMenuItem,
            this.devoluçõesToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(96, 25);
            this.operaçõesToolStripMenuItem.Text = "Operações";
            // 
            // empréstimosToolStripMenuItem
            // 
            this.empréstimosToolStripMenuItem.Name = "empréstimosToolStripMenuItem";
            this.empréstimosToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.empréstimosToolStripMenuItem.Text = "Empréstimos";
            this.empréstimosToolStripMenuItem.Click += new System.EventHandler(this.empréstimosToolStripMenuItem_Click);
            // 
            // devoluçõesToolStripMenuItem
            // 
            this.devoluçõesToolStripMenuItem.Name = "devoluçõesToolStripMenuItem";
            this.devoluçõesToolStripMenuItem.Size = new System.Drawing.Size(171, 26);
            this.devoluçõesToolStripMenuItem.Text = "Devoluções";
            this.devoluçõesToolStripMenuItem.Click += new System.EventHandler(this.devoluçõesToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.livrosToolStripMenuItem1,
            this.leitoresToolStripMenuItem1});
            this.consultasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // livrosToolStripMenuItem1
            // 
            this.livrosToolStripMenuItem1.BackColor = System.Drawing.SystemColors.Control;
            this.livrosToolStripMenuItem1.Name = "livrosToolStripMenuItem1";
            this.livrosToolStripMenuItem1.Size = new System.Drawing.Size(135, 26);
            this.livrosToolStripMenuItem1.Text = "Livros";
            this.livrosToolStripMenuItem1.Click += new System.EventHandler(this.livrosToolStripMenuItem1_Click);
            // 
            // leitoresToolStripMenuItem1
            // 
            this.leitoresToolStripMenuItem1.Name = "leitoresToolStripMenuItem1";
            this.leitoresToolStripMenuItem1.Size = new System.Drawing.Size(135, 26);
            this.leitoresToolStripMenuItem1.Text = "Leitores";
            this.leitoresToolStripMenuItem1.Click += new System.EventHandler(this.leitoresToolStripMenuItem1_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // dlgAbrir
            // 
            this.dlgAbrir.FileName = "*.txt";
            // 
            // FrmBiblioteca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(430, 255);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBiblioteca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Projeto III - Biblioteca";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBiblioteca_FormClosing);
            this.Load += new System.EventHandler(this.FrmBiblioteca_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem manutençãoToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem leitoresToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem empréstimosToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem devoluçõesToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem livrosToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem leitoresToolStripMenuItem1;
    private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog dlgAbrir;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
    }
}

