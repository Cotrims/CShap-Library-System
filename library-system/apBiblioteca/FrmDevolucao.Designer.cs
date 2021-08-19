namespace apBiblioteca
{
    partial class FrmDevolucao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.codLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tituloLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLeitores = new System.Windows.Forms.DataGridView();
            this.codLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeLeitor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDevolver = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stlbMenssagem = new System.Windows.Forms.ToolStripStatusLabel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitores)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(400, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 25);
            this.label2.TabIndex = 23;
            this.label2.Text = "Livros com este leitor:";
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            this.dgvLivros.AllowUserToResizeColumns = false;
            this.dgvLivros.AllowUserToResizeRows = false;
            this.dgvLivros.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvLivros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvLivros.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
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
            this.dgvLivros.GridColor = System.Drawing.SystemColors.ActiveBorder;
            this.dgvLivros.Location = new System.Drawing.Point(349, 31);
            this.dgvLivros.MultiSelect = false;
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLivros.RowHeadersVisible = false;
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(316, 143);
            this.dgvLivros.TabIndex = 21;
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
            this.tituloLivro.Width = 238;
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvLeitores.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvLeitores.Location = new System.Drawing.Point(12, 31);
            this.dgvLeitores.MultiSelect = false;
            this.dgvLeitores.Name = "dgvLeitores";
            this.dgvLeitores.ReadOnly = true;
            this.dgvLeitores.RowHeadersVisible = false;
            this.dgvLeitores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeitores.Size = new System.Drawing.Size(331, 275);
            this.dgvLeitores.TabIndex = 20;
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
            this.nomeLeitor.Width = 238;
            // 
            // btnDevolver
            // 
            this.btnDevolver.BackColor = System.Drawing.Color.Gray;
            this.btnDevolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnDevolver.Enabled = false;
            this.btnDevolver.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDevolver.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnDevolver.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDevolver.Location = new System.Drawing.Point(434, 198);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(111, 57);
            this.btnDevolver.TabIndex = 19;
            this.btnDevolver.Text = "Devolver";
            this.btnDevolver.UseVisualStyleBackColor = false;
            this.btnDevolver.Click += new System.EventHandler(this.btnDevolver_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Silver;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.stlbMenssagem});
            this.statusStrip1.Location = new System.Drawing.Point(0, 316);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(677, 22);
            this.statusStrip1.TabIndex = 18;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(131, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Leitor:";
            // 
            // FrmDevolucao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(677, 338);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvLeitores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.btnDevolver);
            this.Controls.Add(this.statusStrip1);
            this.MinimumSize = new System.Drawing.Size(676, 377);
            this.Name = "FrmDevolucao";
            this.Text = "FrmDevolucao";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FrmDevolucao_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeitores)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.DataGridView dgvLeitores;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLeitor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeLeitor;
        private System.Windows.Forms.Button btnDevolver;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel stlbMenssagem;
        private System.Windows.Forms.DataGridViewTextBoxColumn codLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn tituloLivro;
        private System.Windows.Forms.Label label1;
    }
}