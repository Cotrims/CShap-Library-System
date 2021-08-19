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
    public partial class FrmLivrosConsulta : Form
    {
        VetorDados<Livro> osLivros;
        VetorDados<TipoLivro> osTipos;
        VetorDados<Leitor> osLeitores;
        int ondeAchou = 0;

        internal VetorDados<Livro> OsLivros { get => osLivros; set => osLivros = value; } //Propriedade para receber o vetor de Livros
        internal VetorDados<TipoLivro> OsTipos { get => osTipos; set => osTipos = value; } //Propriedade para receber o vetor de Tipo de Livros
        internal VetorDados<Leitor> OsLeitores { get => osLeitores; set => osLeitores = value; }  //Propriedade para receber o vetor de Leitores


        public FrmLivrosConsulta()
        {
            InitializeComponent();
        }

        private void FrmLivrosConsulta_Load(object sender, EventArgs e)
        {
            int indice = 0;
            barraDeFerramentas.ImageList = imlBotoes;
            foreach (ToolStripItem item in barraDeFerramentas.Items) //Exibe as imagens do menu
                if (item is ToolStripButton) // se não é separador:
                    (item as ToolStripButton).ImageIndex = indice++;

            //Posiciona no primeiro livro
            osLivros.PosicionarNoPrimeiro();
            AtualizarTela();
        }

        public void AtualizarTela()
        {
            if (!osLivros.EstaVazio)
            {
                TestarBotoes(); //Verifica quais botões poderão ser clicados

                //Exibe as informações do livro
                txtCodigoLivro.Text = osLivros[osLivros.PosicaoAtual].CodigoLivro;
                txtNomeLivro.Text = osLivros[osLivros.PosicaoAtual].TituloLivro;

                var tipo = new TipoLivro(osLivros[osLivros.PosicaoAtual].CodTipoLivro, "");
                if (osTipos.Existe(tipo, ref ondeAchou)) //Exibe o nome do tipo
                    txtTipoLivro.Text = osTipos[ondeAchou].DescricaoTipo;

                var leitor = new Leitor(osLivros[osLivros.PosicaoAtual].CodigoLeitorComLivro);
                ondeAchou = 0;

                if(osLeitores.Existe(leitor, ref ondeAchou)) //Caso tenha algum leitor com o livro exibiremos suas informações
                {
                    txtCodigoLeitor.Text = osLeitores[ondeAchou].CodigoLeitor;
                    txtNomeLeitor.Text = osLeitores[ondeAchou].NomeLeitor;
                    txtEnderecoLeitor.Text = osLeitores[ondeAchou].EnderecoLeitor;
                }
                else //Caso não tenha os campos serão vazios
                {
                    txtNomeLeitor.Text = "";
                    txtEnderecoLeitor.Text = "";
                    txtCodigoLeitor.Text = osLivros[osLivros.PosicaoAtual].CodigoLeitorComLivro;
                }
            }
        }

        public void TestarBotoes() //Em casa posição exibida os botões poderão ou não serem clicados
        {
            //No meio do vetor
            btnInicio.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;

            //No inicio
            if (osLivros.EstaNoInicio)
            {
                btnInicio.Enabled = false;
                btnAnterior.Enabled = false;
            }

            //No final
            if (osLivros.EstaNoFim)
            {
                btnUltimo.Enabled = false;
                btnProximo.Enabled = false;
            }
        }

        private void BtnInicio_Click(object sender, EventArgs e)  //Posiciona no primeiro e mostra o livro que está na posição
        {
            osLivros.PosicionarNoPrimeiro();
            AtualizarTela();
        }

        private void BtnAnterior_Click(object sender, EventArgs e) //Retrocede uma posição e mostra o livro que está nela
        {
            osLivros.RetrocederPosicao();
            AtualizarTela();
        }

        private void BtnProximo_Click(object sender, EventArgs e) //Avança uma posição e mostra o livro que está nela
        {
            osLivros.AvancarPosicao();
            AtualizarTela();
        }

        private void BtnUltimo_Click(object sender, EventArgs e) //Posiciona no ultimo e mostra o livro que está na posição
        {
            osLivros.PosicionarNoUltimo();
            AtualizarTela();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtCodigoLivro_Leave(object sender, EventArgs e)
        {
            if (txtCodigoLivro.Text == "") //Verificamos se o usuário digitou um código
                MessageBox.Show("Digite um código para ser pesquisado!");
            else
            {
                int ondeAchou = 0;
                var procurado = new Livro(txtCodigoLivro.Text);

                if (osLivros.Existe(procurado, ref ondeAchou)) //Caso exista o livro procurado exibiremos ele e retornaremos a situação de navegação
                {
                    osLivros.PosicaoAtual = ondeAchou;
                    AtualizarTela();
                    txtCodigoLivro.Enabled = false;
                    osLivros.SituacaoAtual = Situacao.navegando;
                    stlbMensagem.Text = ":)";
                }
                else //Caso não exista exibiremos o livro anterior e retornaremos a situação de navegação
                {
                    MessageBox.Show("Livro não encontrado!");
                    AtualizarTela();
                    osLivros.SituacaoAtual = Situacao.navegando;
                    txtCodigoLivro.Enabled = false;
                    stlbMensagem.Text = ":(";
                }
            }
        }

        private void TpLista_Enter(object sender, EventArgs e)
        {
            ExibirLivros(lsbLivros, "Código  Título                              Tipo         Disponivel"); //Cabeçalho do lsbLivros
            FrmLivrosConsulta.ActiveForm.Width = 670;
        }

        public void ExibirLivros(ListBox lista, string cabecalho)
        {
            lista.Items.Clear();
            lista.Items.Add(cabecalho);

            string linha = "";

            for(int i = 0; i < osLivros.Tamanho; i++) //Exibimos livro a livros
            {
                linha += osLivros[i].CodigoLivro + " " +
                         osLivros[i].TituloLivro.PadRight(35, ' ') + " ";

                var tipo = new TipoLivro(osLivros[i].CodTipoLivro, "");
                if (osTipos.Existe(tipo, ref ondeAchou)) //Busca o nome da descrição
                    linha += osTipos[ondeAchou].DescricaoTipo;

                if (osLivros[i].CodigoLeitorComLivro == "000000") //Verifica se o livro está disponivel ou não
                    linha += "Sim";
                else
                    linha += "Não";

                lista.Items.Add(linha);

                linha = "";
            }
        }

        private void BtnProcurar_Click_1(object sender, EventArgs e)
        {
            //Muda a situação
            osLivros.SituacaoAtual = Situacao.pesquisando;

            //Prepara a tela para o usuário
            txtCodigoLivro.Enabled = true;
            LimparTela();
            txtCodigoLivro.Focus();

            //Pede ao usuário que digite o código do livro
            stlbMensagem.Text = "Digite o código do livro que procura e pressine TAB";
        }

        public void LimparTela() //Limpa a tela para o exibir o resultado da pesquisa
        {
            txtCodigoLivro.Text = "";
            txtNomeLivro.Text = "";
            txtTipoLivro.Text = "";
            txtCodigoLeitor.Text = "";
            txtNomeLeitor.Text = "";
            txtEnderecoLeitor.Text = "";
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            //Retorna a situação anterior e exibe o registro anterior
            osLivros.SituacaoAtual = Situacao.navegando;
            AtualizarTela();
            txtCodigoLivro.Enabled = false;
        }

        private void TpCadastro_Enter(object sender, EventArgs e)
        {
            FrmLivrosConsulta.ActiveForm.Width = 575;
        }
    }
}
