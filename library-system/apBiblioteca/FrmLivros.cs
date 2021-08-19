using System;
using System.Windows.Forms;

namespace apBiblioteca
{
    public partial class FrmLivros : Form
    {
        VetorDados<Livro> osLivros; 
        VetorDados<TipoLivro> osTipos;
        VetorDados<Leitor> osLeitores;
        int ondeIncluir = 0;        // global --> acessível na classe toda
        int ondeAchou;
    
        internal VetorDados<Livro> OsLivros { get => osLivros; set => osLivros = value; } //Propriedade para receber o vetor de Livros
        internal VetorDados<TipoLivro> OsTipos { get => osTipos; set => osTipos = value; } //Propriedade para receber o vetor de Tipo de Livros
        internal VetorDados<Leitor> OsLeitores { get => osLeitores; set => osLeitores = value; } //Propriedade para receber o vetor de Leitores

        public FrmLivros()
        {
            InitializeComponent();
        }

        private void FrmFunc_Load(object sender, EventArgs e)
        {
            int indice = 0;
            barraDeFerramentas.ImageList = imlBotoes;
            foreach (ToolStripItem item in barraDeFerramentas.Items) //Exibe as imagens dos botões do Menu
                if (item is ToolStripButton) // se não é separador:
                    (item as ToolStripButton).ImageIndex = indice++;

            osTipos.ExibirDados(dgvTipos); //Exibe os tipos de livros no dgv
            //Posiciona no primeiro e o mostra
            osLivros.PosicionarNoPrimeiro();
            AtualizarTela();
            AtualizarCampos();
        }

        private void btnInicio_Click(object sender, EventArgs e) //Posiciona no primeiro e mostra o livro que está na posição
        {
            osLivros.PosicionarNoPrimeiro();
            AtualizarTela();
        }

        private void btnAnterior_Click(object sender, EventArgs e) //Retrocede uma posição e mostra o livro que está nela 
        {
            osLivros.RetrocederPosicao();
            AtualizarTela();
        }

        private void btnProximo_Click(object sender, EventArgs e) //Avança uma posição e mostra o livro que está nela
        {
            osLivros.AvancarPosicao();
            AtualizarTela();
        }
        private void btnUltimo_Click(object sender, EventArgs e) //Posiciona no ultimo e mostra o livro que está na posição
        {
            osLivros.PosicionarNoUltimo();
            AtualizarTela();
        }

        private void AtualizarTela()
        {
            if (!osLivros.EstaVazio)
            {
                TestarBotoes(); //Verifica quais botões devem ser exibidos

                int indice = osLivros.PosicaoAtual;
                var livro = osLivros[indice];
                var leitor = new Leitor(livro.CodigoLeitorComLivro);

                if (osLeitores.Existe(leitor, ref ondeAchou)) //Acha, caso exista o leitor com o livro atual
                {
                    leitor = osLeitores[ondeAchou];
                    txtCodigoLeitor.Text = leitor.CodigoLeitor;
                    txtNomeLeitor.Text = leitor.NomeLeitor;
                    txtEnderecoLeitor.Text = leitor.EnderecoLeitor;
                }
                else //Caso o livro não tenha um leitor
                {
                    txtCodigoLeitor.Text = "000000";
                    txtNomeLeitor.Text = "";
                    txtEnderecoLeitor.Text = "";
                }

                //Exibição dos campos do livro
                txtCodigoLivro.Text = livro.CodigoLivro + "";
                txtTituloLivro.Text = livro.TituloLivro;

                var tipo = new TipoLivro(livro.CodTipoLivro, "");

                if(osTipos.Existe(tipo, ref ondeAchou)) //Ao achar a posição do tipo do livro no vetor
                    dgvTipos.Rows[ondeAchou].Selected = true; //Seleciona a linha correspondente

                stlbMensagem.Text =
                  "Registro " + (osLivros.PosicaoAtual + 1) +
                             "/" + osLivros.Tamanho;
            }
        }

        private void LimparTela() 
        { 
            //Limpa todos os campos para a digitação do usuário
            txtCodigoLivro.Text = "";
            txtTituloLivro.Text = "";
            dgvTipos.ClearSelection();
        }

        private void TestarBotoes() //Verifica quais botões devem ser exibidos
        {
            //Caso esteja no meio do vetor
            btnInicio.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;

            //Caso esteja no inicio
            if (osLivros.EstaNoInicio)
            {
                btnInicio.Enabled = false;
                btnAnterior.Enabled = false;
            }

            //Caso esteja no final
            if (osLivros.EstaNoFim)
            {
                btnProximo.Enabled = false;
                btnUltimo.Enabled = false;
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            // saímos do modo de navegação e entramos no modo de inclusão:
            osLivros.SituacaoAtual = Situacao.incluindo;

            // preparamos a tela para que seja possível digitar dados do novo livro
            AtualizarCampos();
            LimparTela();

            // colocamos o cursor no campo chave
            txtCodigoLivro.Focus();

            // Exibimos mensagem no statusStrip para instruir o usuário a digitar dados
            stlbMensagem.Text = "Digite o código do novo livro";

            btnSalvar.Enabled = true;
        }

        private void txtCodigoGenero_Leave(object sender, EventArgs e)
        {
            if (txtCodigoLivro.Text == "") //Verificamos se o usuário digitou um código
                MessageBox.Show("Digite um código válido!");
            else
            {
                var procurado = new Livro(txtCodigoLivro.Text);
                switch (osLivros.SituacaoAtual)
                {
                    case Situacao.incluindo:
                        if (osLivros.Existe(procurado, ref ondeIncluir))   // se já existe o código
                        {
                            MessageBox.Show("Código repetido; inclusão cancelada.");
                            osLivros.SituacaoAtual = Situacao.navegando;
                            AtualizarCampos();
                            AtualizarTela(); // restaura o registro visível anteriormente
                        }
                        else // o código ainda não existe no vetor dados
                        {
                            txtTituloLivro.Focus();
                            stlbMensagem.Text = "Agora dê um nome e um tipo ao livro e pressione [Salvar]";
                        }
                        break;
                    case Situacao.pesquisando:
                        int ondeAchou = 0;
                        if (!osLivros.Existe(procurado, ref ondeAchou)) //Caso não ache será exibido o registro anterior
                        {
                            MessageBox.Show("Código não foi cadastrado ainda.");
                            AtualizarTela();
                            osLivros.SituacaoAtual = Situacao.navegando;
                            AtualizarCampos();
                        }
                        else  // encontrou o código procurado na posição ondeAchou
                        {
                            //Exibição do livro encontrado
                            osLivros.PosicaoAtual = ondeAchou;
                            AtualizarTela();
                            osLivros.SituacaoAtual = Situacao.navegando;
                            AtualizarCampos();
                        }
                        break;
                }
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        { 
            int codLivro = int.Parse(txtCodigoLivro.Text); //Verificamos se o usuário digitou um código
            if (codLivro == -1)
                MessageBox.Show("Selecione um livro antes de salvar o registro!");
            else
                if (osLivros.SituacaoAtual == Situacao.incluindo) // está no modo de inclusão
                {
                    var novoDado = new Livro(txtCodigoLivro.Text,
                                                txtTituloLivro.Text,
                                                osTipos[dgvTipos.CurrentRow.Index].CodTipo,
                                                new DateTime(1234, 12, 12),
                                                "000000");
                    osLivros.Incluir(novoDado, ondeIncluir);
                    // para mudar o registro com o qual trabalhamos no momento
                    osLivros.PosicaoAtual = ondeIncluir;
                    AtualizarTela();
                    osLivros.SituacaoAtual = Situacao.navegando; // termina o modo de inclusão
                    AtualizarCampos();
                }
                else  // verificar se está editando
                if (osLivros.SituacaoAtual == Situacao.editando)
                {
                    //Salva tudo o que foi editado
                    osLivros[osLivros.PosicaoAtual] = new Livro(
                            txtCodigoLivro.Text, txtTituloLivro.Text,
                            osTipos[dgvTipos.CurrentRow.Index].CodTipo,
                            osLivros[osLivros.PosicaoAtual].DataDevolucao,
                            osLivros[osLivros.PosicaoAtual].CodigoLeitorComLivro);
                    osLivros.SituacaoAtual = Situacao.navegando;
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
            if (osLivros[osLivros.PosicaoAtual].CodigoLeitorComLivro != "000000") //Verificamos se o livro está emprestado
                MessageBox.Show("Há leitores com este livro, exclusão cancelada!");
            else
            if (MessageBox.Show(
                   "Deseja realmente excluir?", "Exclusão",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Warning) == DialogResult.Yes) //Caso o usuário queira realmente excluir o livro
            {
                //Excluimos e exibimos outro registro
                osLivros.Excluir(osLivros.PosicaoAtual);
                if (osLivros.PosicaoAtual >= osLivros.Tamanho)
                    osLivros.PosicionarNoUltimo();
                AtualizarTela();
            }
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            //Preparamos a tela para exibir o registro procurado
            LimparTela();
            osLivros.SituacaoAtual = Situacao.pesquisando;
            AtualizarCampos();
            txtCodigoLivro.Focus();
            stlbMensagem.Text = "Digite o código do livro que busca e pressione TAB";
        }

        private void tpLista_Enter(object sender, EventArgs e)
        {
            ExibirLivros(lsbLivros, "Código  Título                         Tipo");//Cabeçalho para o lsbLivros
        }

        public void ExibirLivros(ListBox lista, string cabecalho)
        {
            lista.Items.Clear();
            lista.Items.Add(cabecalho);

            string linha = "";
            int onde = 0;

            for (int i = 0; i < osLivros.Tamanho; i++) //Exibimos livro por livro
            {
                linha += osLivros[i].CodigoLivro + " " +
                         osLivros[i].TituloLivro + " ";

                var tipo = new TipoLivro(osLivros[i].CodTipoLivro, ""); //Achamos o nome do tipo
                if (osTipos.Existe(tipo, ref onde))
                    linha += osTipos[onde].DescricaoTipo;

                lista.Items.Add(linha);
                linha = "";
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //Preparamos os campos para a digitação do usuário
            osLivros.SituacaoAtual = Situacao.editando;
            AtualizarCampos();
            stlbMensagem.Text = "Modifique os campos desejados e pressione [Salvar]";
            txtTituloLivro.Focus();
            btnSalvar.Enabled = true;
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTituloLivro_Leave(object sender, EventArgs e)
        {
            if (osLivros.SituacaoAtual == Situacao.incluindo || osLivros.SituacaoAtual == Situacao.incluindo)
                if (txtTituloLivro.Text == "") //Verificamos se o usuário digitou um nome para o livro
                    MessageBox.Show("Escreva um título para o livro!");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Retornamos à situação de navegação exibindo o registro anteriormente mostrado
            osLivros.SituacaoAtual = Situacao.navegando;
            AtualizarCampos();
            AtualizarTela();
            btnSalvar.Enabled = false;
        }

        private void DgvTipos_CellClick(object sender, DataGridViewCellEventArgs e)
        { 
            //Para que a propiedade selected das linhas do dgvTipos não sejam alteras em outros momentos, permitiremos apenas nos modos de inclusão e edição
            if(OsLivros.SituacaoAtual != Situacao.incluindo 
            && OsLivros.SituacaoAtual != Situacao.editando)
            {
                dgvTipos.Rows[dgvTipos.CurrentRow.Index].Selected = false;
                dgvTipos.Rows[ondeAchou].Selected = true;
            }
        }


        public void AtualizarCampos() //Em cada situação os campos devem ser digitaveis ou não
        {
            if (osLivros.SituacaoAtual == Situacao.navegando)
            {
                txtCodigoLivro.Enabled = false;
                txtTituloLivro.Enabled = false;
            }

            if (osLivros.SituacaoAtual == Situacao.incluindo)
            {
                txtCodigoLivro.Enabled = true;
                txtTituloLivro.Enabled = true;
            }

            if (osLivros.SituacaoAtual == Situacao.editando)
                txtTituloLivro.Enabled = true;

            if (osLivros.SituacaoAtual == Situacao.pesquisando)
                txtCodigoLivro.Enabled = true;
        }
    }
}

