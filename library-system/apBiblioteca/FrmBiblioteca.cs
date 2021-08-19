using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apBiblioteca
{
    public partial class FrmBiblioteca : Form
    {
        FrmTipos frmTipos;
        FrmLivros frmLivros;
        FrmLeitores frmLeitores;
        FrmLeitoresConsulta frmLeitoresCons;
        FrmLivrosConsulta frmLivrosCons;
        FrmEmprestimo frmEmprestimo;
        FrmDevolucao frmDevolucao;
        VetorDados<Livro> osLivros;
        VetorDados<TipoLivro> osTipos;
        VetorDados<Leitor> osLeitores;

        string nomeArquivoLeitores, nomeArquivoLivros, nomeArquivoTipos;

        public FrmBiblioteca()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e) //Ao iniciar o form de manutenção de livros
        {
            frmLivros = new FrmLivros(); //Instância o form
            frmLivros.OsLivros = osLivros; //Da o vetor de livros
            frmLivros.OsLeitores = osLeitores; //Da o vetor de leitores
            frmLivros.OsTipos = osTipos; //Da o vetor de tipos
            frmLivros.Show(); //Mostra o form

            //Todos os outros Itens do Menu seguem o mesmo esquema
        }

        private void leitoresToolStripMenuItem_Click(object sender, EventArgs e) //Ao iniciar o form de manutenção de leitores
        {
            frmLeitores = new FrmLeitores();
            frmLeitores.OsLeitores = osLeitores;
            frmLeitores.OsLivros = osLivros;
            frmLeitores.Show();
        }

        private void empréstimosToolStripMenuItem_Click(object sender, EventArgs e) //Ao iniciar o form de empréstimo
        {
            frmEmprestimo = new FrmEmprestimo();
            frmEmprestimo.OsLeitores = osLeitores;
            frmEmprestimo.OsLivros = osLivros;
            frmEmprestimo.Show();
        }

        private void devoluçõesToolStripMenuItem_Click(object sender, EventArgs e) //Ao iniciar o form de devolução
        {
            frmDevolucao = new FrmDevolucao();
            frmDevolucao.OsLeitores = osLeitores;
            frmDevolucao.OsLivros = osLivros;
            frmDevolucao.Show();
        }

        private void livrosToolStripMenuItem1_Click(object sender, EventArgs e) //Ao iniciar o form de consulta de livros
        {
            frmLivrosCons = new FrmLivrosConsulta();
            frmLivrosCons.OsLeitores = osLeitores;
            frmLivrosCons.OsLivros = osLivros;
            frmLivrosCons.OsTipos = osTipos;
            frmLivrosCons.Show();
        }

        private void FrmBiblioteca_FormClosing(object sender, FormClosingEventArgs e) //Ao fechar o FrmBiblioteca grava os vetores Livros, Leitores e Tipos em seus arquivos
        {
            osLivros.GravarDados(nomeArquivoLivros);
            osLeitores.GravarDados(nomeArquivoLeitores);
            osTipos.GravarDados(nomeArquivoTipos);
        }

        private void ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTipos = new FrmTipos();
            frmTipos.OsTipos = osTipos;
            frmTipos.OsLivros = osLivros;
            frmTipos.Show();
        }

        private void leitoresToolStripMenuItem1_Click(object sender, EventArgs e) //Ao iniciar o form de consulta de leitores
        {
            frmLeitoresCons = new FrmLeitoresConsulta();
            frmLeitoresCons.OsLeitores = osLeitores;
            frmLeitoresCons.OsLivros = osLivros;
            frmLeitoresCons.OsTipos = osTipos;
            frmLeitoresCons.Show();
        }

        private void FrmBiblioteca_Load(object sender, EventArgs e)
        {
            osLeitores = new VetorDados<Leitor>(50); // instancia com vetor dados com 50 posições
            dlgAbrir.Title = "Selecione o arquivo com os dados de leitores";
            if (dlgAbrir.ShowDialog() == DialogResult.OK) //Lê e grava leitores
            {
                nomeArquivoLeitores = dlgAbrir.FileName; 
                osLeitores.LerDados(nomeArquivoLeitores);
            }

            osLivros = new VetorDados<Livro>(50); // instancia com vetor dados com 50 posições
            dlgAbrir.Title = "Selecione o arquivo com os dados de livros";
            if (dlgAbrir.ShowDialog() == DialogResult.OK) //Lê e grava os livros
            {
                nomeArquivoLivros = dlgAbrir.FileName;
                osLivros.LerDados(nomeArquivoLivros);
            }

            osTipos = new VetorDados<TipoLivro>(10);  // instancia com vetor dados com 10 posições
            dlgAbrir.Title = "Selecione o arquivo com os dados dos Tipos de livros";
            if (dlgAbrir.ShowDialog() == DialogResult.OK) //Lê e grava os tipos de livros
            {
                nomeArquivoTipos = dlgAbrir.FileName;
                osTipos.LerDados(nomeArquivoTipos);
            }
        }
    }
}
