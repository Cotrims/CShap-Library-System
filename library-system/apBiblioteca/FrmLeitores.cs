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
    public partial class FrmLeitores : Form
    {
        VetorDados<Livro> osLivros;
        VetorDados<Leitor> osLeitores;
        int ondeIncluir = 0;  // global --> acessível na classe toda

        internal VetorDados<Leitor> OsLeitores { get => osLeitores; set => osLeitores = value; } //Propriedade para receber o vetor de leitores
        internal VetorDados<Livro> OsLivros { get => osLivros; set => osLivros = value; } //Propriedade para receber o vetor de livros

        public FrmLeitores()
        {
            InitializeComponent();
        }

        private void FrmFunc_Load(object sender, EventArgs e)
        {
            int indice = 0;
            barraDeFerramentas.ImageList = imlBotoes;
            foreach (ToolStripItem item in barraDeFerramentas.Items) //Exibe as imagens da barra de ferramentas
                if (item is ToolStripButton) // se não é separador:
                    (item as ToolStripButton).ImageIndex = indice++;

            osLeitores.PosicionarNoPrimeiro(); //Posiciona no primeiro leitor
            AtualizarTela(); //Atualiza a tela
            AtualizarCampos(); //Muda o estado dos campos
        }

        private void btnInicio_Click(object sender, EventArgs e) //Coloca a posição atual na primeira e exibe o leitor que está nela
        {
            osLeitores.PosicionarNoPrimeiro();
            AtualizarTela(); 
        }
        private void btnAnterior_Click(object sender, EventArgs e) //Retrocede a posição atual exibe o leitor que está nela
        {
            osLeitores.RetrocederPosicao();
            AtualizarTela(); 
        }
        private void btnProximo_Click(object sender, EventArgs e) //Avança a posição atual exibe o leitor que está nela
        {
            osLeitores.AvancarPosicao();
            AtualizarTela();
        }
        private void btnUltimo_Click(object sender, EventArgs e) //Coloca a posição atual na última e exibe o leitor que está nela
        {
            osLeitores.PosicionarNoUltimo(); 
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            if (!osLeitores.EstaVazio) //Caso tenha leitores para exibir
            {
                Leitor oLeitor = osLeitores[osLeitores.PosicaoAtual]; 
                txtCodigoLeitor.Text = oLeitor.CodigoLeitor + ""; //Exibe o código
                txtNomeLeitor.Text = oLeitor.NomeLeitor; //Exibe o nome
                txtEndereco.Text = oLeitor.EnderecoLeitor; //Exibe o endereço

                TestarBotoes(); //Verifica os estados dos botões
                stlbMensagem.Text =
                  "Registro " + (osLeitores.PosicaoAtual + 1) +
                             "/" + osLeitores.Tamanho; //Informa qual registro esta sendo exibido
            }
        }

        private void LimparTela() //Limpa o três campos de digitação
        {
            txtCodigoLeitor.Clear();
            txtNomeLeitor.Clear();
            txtEndereco.Text = "";
        }

        private void TestarBotoes() //Muda os estados dos botões conforme a posição que está sendo exibida
        {
            btnInicio.Enabled = true; //Habilita todos
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;
            if (osLeitores.EstaNoInicio) //Caso esteja no início o usuário não pode voltar um posição e nem posicionar na primeira
            {
                btnInicio.Enabled = false;
                btnAnterior.Enabled = false;
            } 
            if (osLeitores.EstaNoFim) //Caso esteja no final o usuário não pode avançar um posição e nem posicionar na última
            {
                btnProximo.Enabled = false;
                btnUltimo.Enabled = false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // saímos do modo de navegação e entramos no modo de inclusão:
            osLeitores.SituacaoAtual = Situacao.incluindo;

            // preparamos a tela para que seja possível digitar dados do novo livro
            AtualizarCampos();
            LimparTela();

            // colocamos o cursor no campo chave
            txtCodigoLeitor.Focus();

            // Exibimos mensagem no statusStrip para instruir o usuário a digitar dados
            stlbMensagem.Text = "Digite o código do novo leitor";

            btnSalvar.Enabled = true;
        }

        private void txtMatricula_Leave(object sender, EventArgs e)
        {
            if (txtCodigoLeitor.Text == "") //Caso o usuário não tenha digitado nenhum código
                MessageBox.Show("Digite um código válido!");
            else
            {
                var procurado = new Leitor(txtCodigoLeitor.Text); //Criamos um leitor com o codigo digitado
                switch (osLeitores.SituacaoAtual)
                {
                    case Situacao.incluindo:
                        if (osLeitores.Existe(procurado, ref ondeIncluir))   // se já existe o código
                        {
                            MessageBox.Show("Código repetido; inclusão cancelada."); //Cancelamos a operação mudando a situação e o estado dos campos
                            osLeitores.SituacaoAtual = Situacao.navegando;
                            AtualizarCampos();
                            AtualizarTela(); // restaura o registro visível anteriormente
                        }
                        else // o código ainda não existe no vetor dados
                        {
                            txtNomeLeitor.Focus();
                            stlbMensagem.Text = "Digite os demais dados. Após isso pressione [Salvar]";
                        }
                        break;

                    case Situacao.pesquisando:
                        int ondeAchou = 0;
                        if (!osLeitores.Existe(procurado, ref ondeAchou)) //Caso não ache
                        {
                            MessageBox.Show("Código não foi cadastrado ainda."); //Retorna a situação de navegação
                            AtualizarTela();
                            osLeitores.SituacaoAtual = Situacao.navegando;
                        }
                        else  // encontrou o código procurado na posição ondeAchou
                        {
                            osLeitores.PosicaoAtual = ondeAchou; //O leitor exibido será o da posição 'ondeAchou'
                            AtualizarTela();
                            osLeitores.SituacaoAtual = Situacao.navegando;
                            AtualizarCampos();
                        }
                        break;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (osLeitores.SituacaoAtual == Situacao.incluindo) // está no modo de inclusão
            {
                var novoDado = new Leitor(txtCodigoLeitor.Text,
                                       txtNomeLeitor.Text,
                                       txtEndereco.Text,
                                       0,    // --> 0 é o número de livros emprestados
                                       new string[5]);  // vetor com 5 códigos de livro vazios
                osLeitores.Incluir(novoDado, ondeIncluir);
                // para mudar o registro com o qual trabalhamos no momento
                osLeitores.PosicaoAtual = ondeIncluir;
                AtualizarTela();
                osLeitores.SituacaoAtual = Situacao.navegando; // termina o modo de inclusão
                AtualizarCampos();
            }
            else  // verificar se está editando
              if (osLeitores.SituacaoAtual == Situacao.editando) //está no modo e edição
            {
                osLeitores[osLeitores.PosicaoAtual] = //O leitor da posição editada receberá um novo leitor com o nome e endereços editados
                      new Leitor(
                      osLeitores[osLeitores.PosicaoAtual].CodigoLeitor,
                      txtNomeLeitor.Text,
                      txtEndereco.Text,
                      osLeitores[osLeitores.PosicaoAtual].QuantosLivrosComLeitor,
                      osLeitores[osLeitores.PosicaoAtual].CodigoLivroComLeitor);

                osLeitores.SituacaoAtual = Situacao.navegando; //Retorna à situação anterior
                AtualizarCampos();
                AtualizarTela();
            }
            btnSalvar.Enabled = false;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            // fecha o formulário mas antes dispara o evento FormClosing
            Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (osLeitores[osLeitores.PosicaoAtual].QuantosLivrosComLeitor != 0) //Caso o leitor possua algum empréstimo
                MessageBox.Show("Há livros com este leitor, inclusão cancelada!");
            else 
            {
                if (MessageBox.Show( //Verificamos se o usuário quer realmente excluir
                       "Deseja realmente excluir?", "Exclusão",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    osLeitores.Excluir(osLeitores.PosicaoAtual); //Se sim excluimos o leitor
                    if (osLeitores.PosicaoAtual >= osLeitores.Tamanho) //Exibimos outro leitor
                        osLeitores.PosicionarNoUltimo();
                    AtualizarTela();
                }
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //Prepara a tela para a pesquisa
            LimparTela();
            osLeitores.SituacaoAtual = Situacao.pesquisando;
            AtualizarCampos();
            //Mostra ao usuário o próximo passo
            txtCodigoLeitor.Focus();
            stlbMensagem.Text = "Digite o código do leitor que busca e pressione TAB";
        }

        private void tpLista_Enter(object sender, EventArgs e)
        {
            osLeitores.ExibirDados(lsbLeitores, "Código Nome                                Endereço");//Exibição de todos os leitores
            FrmLeitores.ActiveForm.Height = 400;
        }

        private void TpCadastro_Enter(object sender, EventArgs e)
        {
            FrmLeitores.ActiveForm.Height = 250; 
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Prepara os campos para a edição
            osLeitores.SituacaoAtual = Situacao.editando;
            //Mostra ao usuário seu próximo passo
            AtualizarCampos();
            stlbMensagem.Text = "Modifique os campos desejados e pressione [Salvar]";
            txtNomeLeitor.Focus();

            btnSalvar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Retorna a situação de navegação mostrando o leitor anterior
            osLeitores.SituacaoAtual = Situacao.navegando;
            AtualizarTela();
            AtualizarCampos();
            btnSalvar.Enabled = false;
        }

        public void AtualizarCampos() //Para que o usuário não dispare os eventos de leave dos txt's e nem digite nos campos
        {
            //Em cada situação os campos serão habilitados e/ou desabilitados conforme a nescessidade

            if (osLeitores.SituacaoAtual == Situacao.navegando)
            {
                txtCodigoLeitor.Enabled = false;
                txtNomeLeitor.Enabled = false;
                txtEndereco.Enabled = false;
            }

            if (osLeitores.SituacaoAtual == Situacao.incluindo)
            {
                txtCodigoLeitor.Enabled = true;
                txtNomeLeitor.Enabled = true;
                txtEndereco.Enabled = true;
            }

            if (osLeitores.SituacaoAtual == Situacao.editando)
            {
                txtNomeLeitor.Enabled = true;
                txtEndereco.Enabled = true;
            }

            if (osLeitores.SituacaoAtual == Situacao.pesquisando)
                txtCodigoLeitor.Enabled = true;
        }
    }
}

