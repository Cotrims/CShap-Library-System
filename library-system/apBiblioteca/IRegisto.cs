using System;
using System.IO;
using System.Windows.Forms;

interface IRegistro
{
    void LerRegistro(StreamReader arq);
    string ParaArquivo();
    void ParaDgv(DataGridView dgv);
}
