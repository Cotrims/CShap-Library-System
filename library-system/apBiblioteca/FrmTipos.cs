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
    public partial class FrmTipos : Form
    {
        VetorDados<Livro> osLivros;
        VetorDados<TipoLivro> osTipos; // osLivros armazenará os dados lidos e terá os métodos de manutenção
        int ondeIncluir = 0;        // global --> acessível na classe toda

        internal VetorDados<TipoLivro> OsTipos { get => osTipos; set => osTipos = value; } //Propriedade para armazenar o vetor de tipos

        internal VetorDados<Livro> OsLivros { get => osLivros; set => osLivros = value; } //Propriedade para armazenar o vetor de livros

        public FrmTipos()
        {
            InitializeComponent();
        }

        private void FrmTipos_Load(object sender, EventArgs e)
        {
            int indice = 0;
            barraDeFerramentas.ImageList = imlBotoes;
            foreach (ToolStripItem item in barraDeFerramentas.Items) //Exibe as imagens do menu
                if (item is ToolStripButton) // se não é separador:
                    (item as ToolStripButton).ImageIndex = indice++;

            //Posiciona e exibe o primeiro tipo
            osTipos.PosicionarNoPrimeiro();
            AtualizarCampos();
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            if (!osTipos.EstaVazio)
            {
                int indice = osTipos.PosicaoAtual;

                if (osTipos[indice].CodTipo < 10)
                    txtCodigoTipo.Text = "0" + osTipos[indice].CodTipo + ""; //Formata o código
                else
                    txtCodigoTipo.Text = osTipos[indice].CodTipo + "";

                txtNomeTipo.Text = osTipos[indice].DescricaoTipo; //Exibe o nome do tipo atual

                TestarBotoes();
                stlbMensagem.Text =
                  "Registro " + (osTipos.PosicaoAtual + 1) +
                             "/" + osTipos.Tamanho;
            }
        }

        private void LimparTela() //Limpa os campos de digitação
        {
            txtCodigoTipo.Clear();
            txtNomeTipo.Clear();
        }

        private void TestarBotoes() //Em casa posição os botões poderão ser clicados ou não
        {
            //Caso esteja entre o inicio e o fim
            btnInicio.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;

            //Caso esteja no início
            if (osTipos.EstaNoInicio)
            {
                btnInicio.Enabled = false;
                btnAnterior.Enabled = false;
            }

            //Caso esteja no final
            if (osTipos.EstaNoFim)
            {
                btnProximo.Enabled = false;
                btnUltimo.Enabled = false;
            }
        }

        private void BtnSair_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        public void AtualizarCampos() //Para que os campos serão digitáveis ou não dependendo da situação em que o programa se encontra
        {
            if (osTipos.SituacaoAtual == Situacao.navegando)
            {
                txtCodigoTipo.Enabled = false;
                txtNomeTipo.Enabled = false;
            }

            if (osTipos.SituacaoAtual == Situacao.incluindo)
            {
                txtCodigoTipo.Enabled = true;
                txtNomeTipo.Enabled = true;
            }

            if (osTipos.SituacaoAtual == Situacao.editando)
                txtNomeTipo.Enabled = true;

            if (osTipos.SituacaoAtual == Situacao.pesquisando)
                txtCodigoTipo.Enabled = true;
        }

        private void BtnInicio_Click_1(object sender, EventArgs e) //Posiciona na primeira posição e exibe o tipo que está nela
        {
            osTipos.PosicionarNoPrimeiro();
            AtualizarTela();
        }

        private void BtnAnterior_Click_1(object sender, EventArgs e)  //Retrocede uma posição e exibe o tipo que está nela
        {
            osTipos.RetrocederPosicao();
            AtualizarTela();
        }

        private void BtnProximo_Click_1(object sender, EventArgs e) //Avança uma posição e exibe o tipo que está nela
        {
            osTipos.AvancarPosicao();
            AtualizarTela();
        }

        private void BtnUltimo_Click_1(object sender, EventArgs e) //Posiciona na última posição e exibe o tipo que está nela
        {
            osTipos.PosicionarNoUltimo();
            AtualizarTela();
        }

        private void BtnProcurar_Click_1(object sender, EventArgs e)
        {
            //Muda a situação
            osTipos.SituacaoAtual = Situacao.pesquisando;

            //Prepara a tela para o usuário digitar
            LimparTela();
            AtualizarCampos();
            txtCodigoTipo.Focus();
            
            //Pede ao usuário que digite o que procura
            stlbMensagem.Text = "Digite o código do tipo que procura e pressione TAB";
        }

        private void BtnNovo_Click_1(object sender, EventArgs e)
        {
            //Muda a situação
            osTipos.SituacaoAtual = Situacao.incluindo;

            //Prepara a tela para o usuário digitar
            LimparTela();
            AtualizarCampos();
            txtCodigoTipo.Focus();

            //Pede ao usuário que digite o que procura
            stlbMensagem.Text = "Digite o código do novo livro!";
            btnSalvar.Enabled = true;
        }

        private void TxtCodigoTipo_Leave(object sender, EventArgs e)
        {
            int codTipo = int.Parse(txtCodigoTipo.Text);

            if (codTipo == -1) //Verifica se o usuário digitou um código
                MessageBox.Show("Digite um código!");
            else
            {
                var procurado = new TipoLivro(codTipo, txtNomeTipo.Text);

                if(osTipos.SituacaoAtual == Situacao.pesquisando) //Caso esteja pesquisando
                {
                    int ondeAchou = 0;
                    if (!osTipos.Existe(procurado, ref ondeAchou)) //Se não achar 
                    { 
                        //Avisa o usuário e retorna a situação original de navegação
                        MessageBox.Show("Código ainda não cadastrado!");
                        osTipos.SituacaoAtual = Situacao.navegando;
                        AtualizarCampos();
                        AtualizarTela();
                    }
                    else
                    {
                        //Caso achar exibe o tipo achado e retorna a navegação
                        osTipos.PosicaoAtual = ondeAchou;
                        osTipos.SituacaoAtual = Situacao.navegando;
                        AtualizarCampos();
                        AtualizarTela();
                    }
                }

                if (osTipos.SituacaoAtual == Situacao.incluindo) //Caso esteja incluindo
                {
                    if(!osTipos.Existe(procurado, ref ondeIncluir)) //Se não existir o código digitado
                    {
                        //Solicida ao usuário que digite a descrição
                        stlbMensagem.Text = "Agora digite a descrição do tipo e pressione [Salvar]";
                        if (txtCodigoTipo.Text.Length < 2)
                            txtCodigoTipo.Text = "0" + txtCodigoTipo;
                        txtNomeTipo.Focus();
                    }
                    else
                    {
                        //Caso ja exista, informa o usuário da exisência, retorna a situação de navegação, e mostra o registro anterior
                        MessageBox.Show("Código já existente, inclusão cancelada!");
                        osTipos.SituacaoAtual = Situacao.navegando;
                        AtualizarCampos();
                        AtualizarTela();
                    }
                }
            }
        }

        private void BtnCancelar_Click_1(object sender, EventArgs e)
        {
            //Retorna a situação de navegação e exibe o registro anterior
            osTipos.SituacaoAtual = Situacao.navegando;
            AtualizarTela();
            AtualizarCampos();
            btnSalvar.Enabled = false;
        }

        private void BtnExcluir_Click_1(object sender, EventArgs e)
        {
            bool emUso = false;

            for(int i = 0; i < osLivros.Tamanho; i++) //Verifica se o tipo está em uso
                if(osLivros[i].CodTipoLivro == OsTipos[osTipos.PosicaoAtual].CodTipo)
                {
                    emUso = true;
                    break;
                }

            if (emUso) //Caso esteja cancela a exclusão
                MessageBox.Show("Tipo em uso, exclusão cancelada!");
            else //Caso não
            {
                if (MessageBox.Show("Deseja realmente excluir?", "Exclusão", MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Warning) == DialogResult.Yes) //Verifica se o usuário realmente quer excluir
                {
                    osTipos.Excluir(osTipos.PosicaoAtual); //Exclui e mostra outro registro

                    if (osTipos.PosicaoAtual >= osTipos.Tamanho) 
                        osTipos.PosicionarNoUltimo();

                    AtualizarTela();
                }
            }
        }

        private void BtnSalvar_Click_1(object sender, EventArgs e)
        {
            int codTipo = int.Parse(txtCodigoTipo.Text);

            if (codTipo == -1) //Se o usuário não digitou um código
                MessageBox.Show("Digite um cógido para o tipo!");
            else
            {
                if(osTipos.SituacaoAtual == Situacao.incluindo) //Caso esteja incluindo
                {
                    var novoTipo = new TipoLivro(codTipo, txtNomeTipo.Text); //Cria um novo tipo
                    osTipos.Incluir(novoTipo, ondeIncluir); //Inclui ele no vetor de tipos
                    //Retorna a situação de navegação e exibe o registro incluido
                    osTipos.SituacaoAtual = Situacao.navegando;

                    osTipos.PosicaoAtual = ondeIncluir;
                    AtualizarTela();
                    AtualizarCampos();
                }

                if(osTipos.SituacaoAtual == Situacao.editando) //Caso esteja editando
                {
                    osTipos[osTipos.PosicaoAtual] = new TipoLivro(codTipo, txtNomeTipo.Text); //Atualiza o registro
                    //Retorna a navegação exibindo o registro editado
                    osTipos.SituacaoAtual = Situacao.navegando;
                    AtualizarCampos();
                    AtualizarTela();
                }
            }
            btnSalvar.Enabled = false;
        }

        private void BtnEditar_Click_1(object sender, EventArgs e)
        {
            //Muda a situação
            osTipos.SituacaoAtual = Situacao.editando;
            //Prepara os campos para o usuário
            AtualizarCampos();
            stlbMensagem.Text = "Modifique o nome e pressione [Salvar]";
            txtNomeTipo.Focus();

            btnSalvar.Enabled = true;
        }

        private void TpCadastro_Enter(object sender, EventArgs e)
        {
            FrmLivros.ActiveForm.Height = 215;
        }

        private void TpLista_Enter(object sender, EventArgs e)
        {
            FrmLivros.ActiveForm.Height = 375;
            osTipos.ExibirDados(lsbTipos, "Código Descrição"); //Cabeçalho para o lsbTipos
        }
    }
}
