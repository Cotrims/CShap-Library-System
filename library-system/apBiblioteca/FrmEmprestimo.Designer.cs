namespace apBiblioteca
{
    partial class FrmEmprestimo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlbMenssagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnEmprestar = new System.Windows.Forms.Button();
            this.dgvLeitores = new System.Windows.Forms.DataGridView();
            this.codLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.codLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stlbMenssagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 307);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(793, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Silver;
            this.toolStripStatusLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(74, 17);
            this.toolStripStatusLabel1.Text = "Menssagem:";
            // 
            // stlbMenssagem
            // 
            this.stlbMenssagem.BackColor = System.Drawing.Color.Silver;
            this.stlbMenssagem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stlbMenssagem.Name = "stlbMenssagem";
            this.stlbMenssagem.Size = new System.Drawing.Size(25, 17);
            this.stlbMenssagem.Text = "Olá";
            // 
            // btnEmprestar
            // 
            this.btnEmprestar.BackColor = System.Drawing.Color.SkyBlue;
            this.btnEmprestar.Enabled = false;
            this.btnEmprestar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnEmprestar.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmprestar.Location = new System.Drawing.Point(350, 142);
            this.btnEmprestar.Name = "btnEmprestar";
            this.btnEmprestar.Size = new System.Drawing.Size(109, 40);
            this.btnEmprestar.TabIndex = 11;
            this.btnEmprestar.Text = "Emprestar";
            this.btnEmprestar.UseVisualStyleBackColor = false;
            this.btnEmprestar.Click += new System.EventHandler(this.BtnEmprestar_Click);
            // 
            // dgvLeitores
            // 
            this.dgvLeitores.AllowUserToAddRows = false;
            this.dgvLeitores.AllowUserToDeleteRows = false;
            this.dgvLeitores.AllowUserToResizeColumns = false;
            this.dgvLeitores.AllowUserToResizeRows = false;
            this.dgvLeitores.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLeitores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLeitores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeitores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLeitor,
            this.nomeLeitor});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeitores.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLeitores.Location = new System.Drawing.Point(12, 33);
            this.dgvLeitores.MultiSelect = false;
            this.dgvLeitores.Name = "dgvLeitores";
            this.dgvLeitores.ReadOnly = true;
            this.dgvLeitores.RowHeadersVisible = false;
            this.dgvLeitores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeitores.Size = new System.Drawing.Size(332, 266);
            this.dgvLeitores.TabIndex = 14;
            this.dgvLeitores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeitores_CellClick);
            // 
            // codLeitor
            // 
            this.codLeitor.HeaderText = "Código";
            this.codLeitor.Name = "codLeitor";
            this.codLeitor.ReadOnly = true;
            this.codLeitor.Width = 75;
            // 
            // nomeLeitor
            // 
            this.nomeLeitor.HeaderText = "Nome";
            this.nomeLeitor.Name = "nomeLeitor";
            this.nomeLeitor.ReadOnly = true;
            this.nomeLeitor.Width = 235;
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            this.dgvLivros.AllowUserToResizeColumns = false;
            this.dgvLivros.AllowUserToResizeRows = false;
            this.dgvLivros.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codLivro,
            this.tituloLivro});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLivros.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvLivros.Location = new System.Drawing.Point(465, 33);
            this.dgvLivros.MultiSelect = false;
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.RowHeadersVisible = false;
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(316, 266);
            this.dgvLivros.TabIndex = 15;
            this.dgvLivros.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellClick);
            // 
            // codLivro
            // 
            this.codLivro.HeaderText = "Código";
            this.codLivro.Name = "codLivro";
            this.codLivro.ReadOnly = true;
            this.codLivro.Width = 75;
            // 
            // tituloLivro
            // 
            this.tituloLivro.HeaderText = "Título";
            this.tituloLivro.Name = "tituloLivro";
            this.tituloLivro.ReadOnly = true;
            this.tituloLivro.Width = 220;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(124, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Leitores:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(603, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Livros:";
            // 
            // FrmEmprestimo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(793, 329);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.dgvLeitores);
            this.Controls.Add(this.btnEmprestar);
            this.Controls.Add(this.statusStrip1);
            this.Name = "FrmEmprestimo";
            this.Text = "Empréstimo de Livros";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmEmprestimo_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stlbMenssagem;
        private System.Windows.Forms.Button btnEmprestar;
        private System.Windows.Forms.DataGridView dgvLeitores;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLeitor;
    }
}