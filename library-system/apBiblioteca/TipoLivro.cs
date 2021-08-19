using System;
using System.Windows.Forms;
using System.IO;

namespace apBiblioteca
{
    class TipoLivro : IComparable<TipoLivro>, IRegistro
    {
        public const int tamanhoCodTipo =  2;
        const int tamanhoDescricao = 20;

        const int inicioCod = 0;
        const int inicioDescricao = inicioCod + tamanhoCodTipo;

        int codTipo;
        string descricaoTipo;

        public int CodTipo 
        {
            get => codTipo;
            set
            {
                if (value > 0)
                    codTipo = value;
            }
        }

        public string DescricaoTipo 
        {
            get => descricaoTipo;
            set
            {
                if (value.Length > tamanhoDescricao)
                    value = value.Substring(0, tamanhoDescricao);

                descricaoTipo = value.PadRight(tamanhoDescricao, ' ');
            }
        }

        public TipoLivro(int cod, string desc) 
        {
            codTipo = cod;
            descricaoTipo = desc;
        }

        public TipoLivro() 
        {
        }

        public void ParaDgv(DataGridView dgv)
        {
            dgv.Rows.Add(codTipo, descricaoTipo);
        }

        public void LerRegistro(StreamReader arq) 
        {
            if (!arq.EndOfStream)
            {
                string linha = arq.ReadLine();
                CodTipo = int.Parse(linha.Substring(inicioCod, tamanhoCodTipo));
                DescricaoTipo = linha.Substring(inicioDescricao);
            }
        }

        public int CompareTo(TipoLivro outro)
        {
            return codTipo.CompareTo(outro.codTipo);
        }

        public string ParaArquivo()
        {
            return Convert.ToString(codTipo).PadLeft(2, '0') + descricaoTipo; 
        }

        public override String ToString()
        {
            return Convert.ToString(codTipo).PadLeft(2, '0') + "     " + descricaoTipo; 
        }
    }
}
