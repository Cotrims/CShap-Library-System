using System;
using System.IO;
using System.Windows.Forms;

namespace apBiblioteca
{
    class Livro : IComparable<Livro>, IRegistro
    {
        public const int tamanhoCodigoLivro = 7;
        const int tamanhoTitulo = 30;
        const int tamanhoCodTipo = TipoLivro.tamanhoCodTipo;
        const int tamanhoData = 10;
        const int tamanhoCodigoLeitor = Leitor.tamanhoCodigoLeitor;

        const int inicioCodigoLivro = 0;
        const int inicioTitulo = inicioCodigoLivro + tamanhoCodigoLivro;
        const int inicioTipo = inicioTitulo + tamanhoTitulo;
        const int inicioData = inicioTipo + tamanhoCodTipo;
        const int inicioCodigoLeitor = inicioData + tamanhoData;

        string codigoLivro;
        string tituloLivro;
        int codTipoLivro;
        DateTime dataDevolucao;
        string codigoLeitorComLivro;

        public Livro()
        {
        }

        public Livro(string cl)
        {
            CodigoLivro = cl;
        }

        public Livro(string livro, string titulo, int tipo, DateTime data, string leitor)
        {
            CodigoLivro = livro;
            TituloLivro = titulo;
            CodTipoLivro = tipo;
            DataDevolucao = data;
            CodigoLeitorComLivro = leitor;
        }

        public void LerRegistro(StreamReader arq)
        {
            if (!arq.EndOfStream)
            {
                String linha = arq.ReadLine();
                CodigoLivro = linha.Substring(inicioCodigoLivro, tamanhoCodigoLivro);
                TituloLivro = linha.Substring(inicioTitulo, tamanhoTitulo);
                CodTipoLivro = int.Parse(linha.Substring(inicioTipo, tamanhoCodTipo));
                DataDevolucao = DateTime.Parse(linha.Substring(inicioData, tamanhoData));
                CodigoLeitorComLivro = linha.Substring(inicioCodigoLeitor, tamanhoCodigoLeitor);
            }
        }

        public string CodigoLivro
        {
            get => codigoLivro;
            set
            {
                if (value.Length > tamanhoCodigoLivro)
                    value = value.Substring(0, tamanhoCodigoLivro);
                codigoLivro = value.PadLeft(tamanhoCodigoLivro, '0');
            }
        }
        public string TituloLivro
        {
            get => tituloLivro;
            set
            {
                if (value.Length > tamanhoTitulo)
                    value = value.Substring(0, tamanhoTitulo);
                tituloLivro = value.PadRight(tamanhoTitulo, ' ');
            }
        }
        public int CodTipoLivro
        {
            get => codTipoLivro;
            set
            {
                if (value > 0)
                    codTipoLivro = value;
            }
        }
        public DateTime DataDevolucao
        {
            get => dataDevolucao;
            set => dataDevolucao = value;
        }
        public string CodigoLeitorComLivro
        {
            get => codigoLeitorComLivro;
            set
            {
                if (value.Length > tamanhoCodigoLeitor)
                    value = value.Substring(0, tamanhoCodigoLeitor);
                codigoLeitorComLivro = value.PadLeft(tamanhoCodigoLeitor, '0');
            }
        }

        public override String ToString()
        {
            String resultado = CodigoLivro + " " + TituloLivro + " " +
                   CodTipoLivro.ToString().PadLeft(tamanhoCodTipo, '0');
            if (CodigoLeitorComLivro != "000000")
                resultado += " " + DataDevolucao.ToShortDateString() + " " + CodigoLeitorComLivro;
            return resultado;
        }

        public String ParaArquivo()
        {
            return CodigoLivro.ToString() + TituloLivro + CodTipoLivro.ToString().PadLeft(tamanhoCodTipo, '0') +
                   DataDevolucao.ToShortDateString() + CodigoLeitorComLivro;
        }

        public int CompareTo(Livro outro)
        {
            return codigoLivro.CompareTo(outro.codigoLivro);
        }

        public void ParaDgv(DataGridView dgv)
        {
            dgv.Rows.Add(codigoLivro, tituloLivro, codTipoLivro, dataDevolucao, codigoLeitorComLivro);
        }

    }
}
