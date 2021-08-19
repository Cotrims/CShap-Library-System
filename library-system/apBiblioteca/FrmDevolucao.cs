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
    public partial class FrmDevolucao : Form
    {
        public FrmDevolucao()
        {
            InitializeComponent();
        }

        VetorDados<Livro> osLivros;
        VetorDados<Leitor> osLeitores;
        Leitor oLeitor;
        Livro oLivro;

        internal VetorDados<Livro> OsLivros { get => osLivros; set => osLivros = value; } //Propiedade para receber o vetor de livros
        internal VetorDados<Leitor> OsLeitores { get => osLeitores; set => osLeitores = value; } //Propiedade para receber o vetor de leitores

        private void FrmDevolucao_Load(object sender, EventArgs e)
        {
            stlbMenssagem.Text = "Escolha um leitor!"; //Informa ao usuário sua proxima ação esperada

            dgvLeitores.RowCount = osLeitores.Tamanho;
            for (int i = 0; i < osLeitores.Tamanho; i++) //Exibe os leitores no Data Grid View de leitores
            {
                dgvLeitores[0, i].Value = osLeitores[i].CodigoLeitor;
                dgvLeitores[1, i].Value = osLeitores[i].NomeLeitor.Trim();

                if (osLeitores[i].QuantosLivrosComLeitor <= 0) //Caso um leitor não tenha pendências, sua linha será visualmente diferente das demais
                    dgvLeitores.Rows[i].DefaultCellStyle.BackColor = Color.Gainsboro;
            }
            dgvLeitores.ClearSelection();
        }

        private void dgvLeitores_CellClick(object sender, DataGridViewCellEventArgs e) // Ao selecionar um leitor
        {
            oLeitor = osLeitores[dgvLeitores.CurrentRow.Index]; //Acessa, no vetor de leitores, o leitor escolhido no Data Grid View

            if (oLeitor.QuantosLivrosComLeitor < 1) //Caso o leitor não tenha empréstimos
            {
                MessageBox.Show("O(A) leitor(ra) " + oLeitor.NomeLeitor.Trim() + " não possui mais pendências!"); //Avisa o usuário
                dgvLeitores.ClearSelection(); //Desseleciona o leitor
            }
            else //Caso tenha algum empréstimo
            {
                ExibirLivros(); //Exibe os livros com o leitor
                stlbMenssagem.Text = "Agora selecione um livro para devolver!"; //Informa ao usuário seu proximo passo
            }
        }

        private void dgvLivros_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            oLivro = new Livro(dgvLivros.CurrentRow.Cells[0].Value.ToString()); //Cria um novo livro com o código do livro da linha selecionada
            int ondeAchou = 0;

            if (osLivros.Existe(oLivro, ref ondeAchou)) //Procura no vetor de livros o livro escolhido
                oLivro = osLivros[ondeAchou]; //Acessa e guarda no oLivro o livro encontrado

            stlbMenssagem.Text = "Devolução pronta para ser realizada!"; //Informa ao usuário seu proximo passo
            btnDevolver.Enabled = true; //Habilita o botão para realizar a devolução
        }

        public void ExibirLivros() //Exibe os livros com o leitor selecionado
        {
            dgvLivros.RowCount = oLeitor.QuantosLivrosComLeitor;
            for (int i = 0; i < dgvLivros.RowCount; i++)
            {
                oLivro = new Livro(oLeitor.CodigoLivroComLeitor[i].ToString()); //Para achar o livro, cria-se um novo livro com o mesmo código do livro com o leitor
                int ondeAchou = 0;

                if (osLivros.Existe(oLivro, ref ondeAchou)) //Achamos a posição do livro existente
                    oLivro = osLivros[ondeAchou]; //Guardamos o livro no oLivro

                dgvLivros[0, i].Value = oLivro.CodigoLivro; //Exibe o código do livro na primeira coluna
                dgvLivros[1, i].Value = oLivro.TituloLivro; //E o título na segunda
            }
            dgvLivros.ClearSelection(); //Desseleciona todos os livros
        }

        private void btnDevolver_Click(object sender, EventArgs e)//Ao realizar a devolução
        {
            oLivro.CodigoLeitorComLivro = "000000"; //O código do leitor com o livro será "000000" o que significa que está sem leitores
            oLeitor.QuantosLivrosComLeitor--; //Um livro a menos com o leitor
            oLeitor.CodigoLivroComLeitor[dgvLivros.CurrentRow.Index] = null; //O código do livro devolvido não fará mais parte do vetor de livros do leitor

            for (int indice = dgvLivros.CurrentRow.Index; indice < oLeitor.CodigoLivroComLeitor.Length - 1; indice++) //Reorganiza o vetor de livros com leitor
            {
                oLeitor.CodigoLivroComLeitor[indice] = oLeitor.CodigoLivroComLeitor[indice + 1]; //O anterior receberá o próximo
                oLeitor.CodigoLivroComLeitor[indice + 1] = null; //E o próximo será nulo
            }

            if (oLeitor.QuantosLivrosComLeitor <= 0) //Caso não tenha mais livros com o leitor
                dgvLeitores.Rows[dgvLeitores.CurrentRow.Index].DefaultCellStyle.BackColor = Color.Gainsboro; //Ele não será uma opção válida, então terá sua cor mudada

            stlbMenssagem.Text = "Devolução realizada com sucesso!"; //Informa ao usuário que a devolução foi bem sucedida
            btnDevolver.Enabled = false; //Desabilita o botão de devoluçao
            dgvLeitores.ClearSelection();
            dgvLivros.RowCount = 0; 
        }
    }
}
