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
    public partial class FrmEmprestimo : Form
    {
        public FrmEmprestimo()
        {
            InitializeComponent();
        }

        VetorDados<Livro> osLivros;
        VetorDados<Leitor> osLeitores;
        Leitor oLeitor;
        Livro oLivro;

        internal VetorDados<Livro> OsLivros { get => osLivros; set => osLivros = value; } //Propriedade para receber o vetor de livros
        internal VetorDados<Leitor> OsLeitores { get => osLeitores; set => osLeitores = value; } //Propriedade para receber o vetor de leitores

        private void FrmEmprestimo_Load(object sender, EventArgs e)
        {
            stlbMenssagem.Text = "Escolha um leitor e um livro pra emprestar!"; //Informa ao usuário o que deve fazer

            dgvLeitores.RowCount = osLeitores.Tamanho;
            for(int i = 0; i < osLeitores.Tamanho; i++) //Exibe todos os leitores 
            {
                dgvLeitores[0, i ].Value = osLeitores[i].CodigoLeitor;
                dgvLeitores[1, i].Value = osLeitores[i].NomeLeitor.Trim();

                if (osLeitores[i].QuantosLivrosComLeitor >= 5) //Caso um leitor ja tenha 5 empréstimos(o limite para empréstimos)
                    dgvLeitores.Rows[i].DefaultCellStyle.BackColor = Color.Gainsboro; //Sua cor será visualmente diferente
            }
            dgvLeitores.ClearSelection();

            dgvLivros.RowCount = osLivros.Tamanho;
            for (int i = 0; i < osLivros.Tamanho; i++) //Exibe todos os livros
            {
                dgvLivros[0, i].Value = osLivros[i].CodigoLivro;
                dgvLivros[1, i].Value = osLivros[i].TituloLivro.Trim();

                if (osLivros[i].CodigoLeitorComLivro != "000000") //Caso um livro já esteja emprestado
                    dgvLivros.Rows[i].DefaultCellStyle.BackColor = Color.Gainsboro; //Sua cor será visualmente diferente
            }
            dgvLivros.ClearSelection();
        }

        private void dgvLeitores_CellClick(object sender, DataGridViewCellEventArgs e) //Ao selecionar um leitor
        {
            oLeitor = osLeitores[dgvLeitores.CurrentRow.Index]; //Será acessado o leitor no vetor de leitores

            if (oLeitor.QuantosLivrosComLeitor >= 5) //Caso o leitor selecionado ja tenha 5 empréstimos
            {
                MessageBox.Show("O(A) leitor(a) " + oLeitor.NomeLeitor.Trim() + " já possui 5 empréstimos!"); //Avisa ao leitor
                dgvLeitores.ClearSelection(); //Desseleciona
                oLeitor = null; //Esvazia o leitor
            }
            else //Caso não tenha
            {
                dgvLeitores.CurrentRow.Selected = true; //Mantém a linha selecionada
                if (oLivro == null) //Se o usuário ainda não escolheu um livro
                    stlbMenssagem.Text = "Agora selecione um livro!"; //Avisa ao usuário
                else //Caso tenha
                {
                    stlbMenssagem.Text = "Emprestimo pronto para ser realizado!"; //Avisa ao usuário
                    btnEmprestar.Focus(); 
                    btnEmprestar.Enabled = true; //Habilita o clique no botão de empréstimo
                }
            }
        }

        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e) //Ao selecionar um livro
        {
            oLivro = osLivros[dgvLivros.CurrentRow.Index]; //Será acessado o livro no vetor de livros

            if (oLivro.CodigoLeitorComLivro != "000000") //Caso o livro já esteja emprestado
            {
                MessageBox.Show("O livro " + oLivro.TituloLivro.Trim() + " já está emprestado!"); //Avisa o usuário
                dgvLivros.ClearSelection(); //Desseleciona
                oLivro = null; //Esvazia o livro
            }
            else //Caso não
            {
                dgvLivros.CurrentRow.Selected = true; //Mantém a linha selecionada
                if (oLeitor == null) //Se o usuário ainda não selecionou um leitor
                    stlbMenssagem.Text = "Agora selecione um leitor!"; //Avisa o usuário
                else //Caso ja tenha escolhido
                {
                    stlbMenssagem.Text = "Emprestimo pronto para ser realizado!"; //Avisa o usuário
                    btnEmprestar.Focus();
                    btnEmprestar.Enabled = true; //Habilita o botão de empréstimo
                }
            }
        }

        private void BtnEmprestar_Click(object sender, EventArgs e)//Ao realizar um empréstimo
        {
            oLeitor.CodigoLivroComLeitor[oLeitor.QuantosLivrosComLeitor] = oLivro.CodigoLivro; //Guarda o código do livro no vetor de livros do leitor
            oLeitor.QuantosLivrosComLeitor++; //Aumenta o número de livros com o leitor
            oLivro.CodigoLeitorComLivro = oLeitor.CodigoLeitor; //Coloca no livro, qual o código do leitor que está com ele
            oLivro.DataDevolucao = new DateTime(DateTime.Now.Year, DateTime.Now.Month + 1, DateTime.Now.Day); //Dá um mês de empréstimo

            if(oLeitor.QuantosLivrosComLeitor >= 5) //Caso o leitor ja tenha atingido 5 empréstimos
                dgvLeitores.Rows[dgvLeitores.CurrentRow.Index].DefaultCellStyle.BackColor = Color.Gainsboro; //Muda a cor do leitor pois já não pode realizar empréstimos

            dgvLivros.Rows[dgvLivros.CurrentRow.Index].DefaultCellStyle.BackColor = Color.Gainsboro; //Mudá a cor do livro, pois já não esta disponível

            stlbMenssagem.Text = "Emprestimo realizado com sucesso!"; 

            //Para que haja um novo empréstimo
            btnEmprestar.Enabled = false; //Desabilita o botão
            dgvLeitores.ClearSelection(); //Desseleciona o leitor
            dgvLivros.ClearSelection(); //Desseleciona o livro
            oLeitor = null; //Esvazia o leitor
            oLivro = null; //Esvazia o livro
        }
    }
}
