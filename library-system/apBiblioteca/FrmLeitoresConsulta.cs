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

    public partial class FrmLeitoresConsulta : Form
    {
        public FrmLeitoresConsulta()
        {
            InitializeComponent();
        }

        VetorDados<Livro> osLivros;
        VetorDados<TipoLivro> osTipos;
        VetorDados<Leitor> osLeitores;

        internal VetorDados<Livro> OsLivros { get => osLivros; set => osLivros = value; } //Propriedade para receber o vetor de livros
        internal VetorDados<TipoLivro> OsTipos { get => osTipos; set => osTipos = value; } //Propriedade para receber o vetor de tipos de livro
        internal VetorDados<Leitor> OsLeitores { get => osLeitores; set => osLeitores = value; } //Propriedade para receber o vetor de leitores

        private void FrmLeitoresConsulta_Load(object sender, EventArgs e)
        {
            int indice = 0;
            barraDeFerramentas.ImageList = imlBotoes;
            foreach (ToolStripItem item in barraDeFerramentas.Items) //Carrega as imagens do menu
                if (item is ToolStripButton) // se não é separador:
                    (item as ToolStripButton).ImageIndex = indice++;

            osLeitores.PosicionarNoPrimeiro(); //Exibe o leitor
            AtualizarTela();
        }

        public void AtualizarTela()
        {
            if (!osLeitores.EstaVazio) //Caso tenha leitores no vetor de leitores
            {
                TestarBotoes();

                Leitor oLeitor = osLeitores[osLeitores.PosicaoAtual];

                //Preenchemos cada text box com sua designada informação
                txtCodigoLeitor.Text = oLeitor.CodigoLeitor + "";
                txtNomeLeitor.Text = oLeitor.NomeLeitor;
                txtEndereco.Text = oLeitor.EnderecoLeitor;
                dgvLivros.RowCount = oLeitor.QuantosLivrosComLeitor;

                for (int umLivro = 0; umLivro < oLeitor.QuantosLivrosComLeitor; umLivro++) //Exibição dos livros com o leitor
                {
                    int ondeLivro = -1;
                    var livroProcurado = new Livro(oLeitor.CodigoLivroComLeitor[umLivro]);
                    if (osLivros.Existe(livroProcurado, ref ondeLivro)) //Acha o livro no vetor de livros
                    {
                        Livro oLivro = osLivros[ondeLivro]; //Guada o livro encontrado

                        //Exibe as informações do livro Data Grid View
                        dgvLivros.Rows[umLivro].Cells[0].Value = oLivro.CodigoLivro;
                        dgvLivros.Rows[umLivro].Cells[1].Value = oLivro.TituloLivro;
                        dgvLivros.Rows[umLivro].Cells[2].Value = oLivro.DataDevolucao.ToShortDateString();

                        if (oLivro.DataDevolucao < DateTime.Now.Date)
                            dgvLivros.Rows[umLivro].Cells[3].Value = "Sim";
                        else
                            dgvLivros.Rows[umLivro].Cells[3].Value = "Não";
                    }

                }
            }
        }

        public void TestarBotoes() //Em cada posição os botões devem estar de uma maneira
        {
            btnInicio.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;

            if (osLeitores.EstaNoFim) //Caso a posição seja inicial o usuário não poderá voltar ou ir para o início
            {
                btnUltimo.Enabled = false;
                btnProximo.Enabled = false;
            }

            if (osLeitores.EstaNoInicio) //Caso a posição seja a final o usuário não podera avançar ou ir para o final
            {
                btnInicio.Enabled = false;
                btnAnterior.Enabled = false;
            }
        }

        private void BtnInicio_Click(object sender, EventArgs e) //Vai para a primeira posição e exibe o leitor que está nela
        {
            osLeitores.PosicionarNoPrimeiro();
            AtualizarTela();
        }

        private void BtnAnterior_Click(object sender, EventArgs e) //Vai para a posição anterior e exibe o leitor que está nela
        {
            osLeitores.RetrocederPosicao();
            AtualizarTela();
        }

        private void BtnProximo_Click(object sender, EventArgs e) //Vai para a proxima posição e exibe o leitor que está nela
        {
            osLeitores.AvancarPosicao();
            AtualizarTela();
        }

        private void BtnUltimo_Click(object sender, EventArgs e) //Vai para a última posição e exibe o leitor que está nela
        {
            osLeitores.PosicionarNoUltimo();
            AtualizarTela();
        }

        private void BtnProcurar_Click(object sender, EventArgs e)
        { 
            osLeitores.SituacaoAtual = Situacao.pesquisando; //Muda a situação

            //Prepara a tela para o usuário digitar
            txtCodigoLeitor.Enabled = true;

            txtCodigoLeitor.Text = "";
            txtNomeLeitor.Clear();
            txtEndereco.Clear();
            txtCodigoLeitor.Focus();

            stlbMensagem.Text = "Digite o código do leitor que procura!"; 
        }

        private void TxtCodigoLeitor_Leave(object sender, EventArgs e)
        {
            if (txtCodigoLeitor.Text == "") //Caso o usuário não tenha digitado um código
                MessageBox.Show("Digite um código de leitor!");
            else
            {
                int ondeAchou = 0;
                var procurado = new Leitor(txtCodigoLeitor.Text);

                if(!osLeitores.Existe(procurado, ref ondeAchou)) //Caso não exista o leitor procurado
                {
                    MessageBox.Show("Leitor não registrado!");
                    //Retorna a situação de navegação
                    osLeitores.SituacaoAtual = Situacao.navegando; 
                    txtCodigoLeitor.Enabled = false;
                    txtCodigoLeitor.ReadOnly = true;
                    //Exibe o leitor anterior
                    AtualizarTela();
                    stlbMensagem.Text = "U_U";
                }
                else //Caso exista
                {
                    osLeitores.PosicaoAtual = ondeAchou;
                    //Retorna a situação de navegação 
                    osLeitores.SituacaoAtual = Situacao.navegando;
                    txtCodigoLeitor.Enabled = false;
                    txtCodigoLeitor.ReadOnly = true;
                    //Exibe o leitor achado
                    AtualizarTela();
                    stlbMensagem.Text = "º_º";
                }
            }
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TpLista_Enter(object sender, EventArgs e)
        {
            ExibirLeitores(lbsLeitores, "Código Nome                                Endereço                                   Pendências"); //Cabeçalho para o listbox
        }

        public void ExibirLeitores(ListBox lista, string cabecalho)
        {
            lista.Items.Clear();
            lista.Items.Add(cabecalho);

            string linha = "";

            for (int i = 0; i < osLeitores.Tamanho; i++) //Exibe linha a linha cada leitor
            {
                linha += osLeitores[i].CodigoLeitor + " " +
                         osLeitores[i].NomeLeitor + " " +
                         osLeitores[i].EnderecoLeitor + " " +
                         "0" + osLeitores[i].QuantosLivrosComLeitor + "";      

                lista.Items.Add(linha);

                linha = "";
            }
        }

        private void BtnProcurar_Click_1(object sender, EventArgs e)
        {
            //Muda a situação para pesquisa
            osLivros.SituacaoAtual = Situacao.pesquisando;
            //Prepara a tela para o usuário
            txtCodigoLeitor.Enabled = true;
            txtCodigoLeitor.ReadOnly = false;
            LimparTela();
            txtCodigoLeitor.Focus();
            stlbMensagem.Text = "Digite o código do livro que procura e pressine TAB";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            //Ao cancelar a situação retornaremos á situação padrão       
            osLeitores.SituacaoAtual = Situacao.navegando;
            //Exibimos último leitor visto
            AtualizarTela();
            txtCodigoLeitor.Enabled = false;
        }

        public void LimparTela()
        { 
            //Limpa todos os campos para o úsuário
            txtCodigoLeitor.Text = "";
            txtNomeLeitor.Text = "";
            txtEndereco.Text = "";
            dgvLivros.RowCount = 0;
        }
    } 
}
