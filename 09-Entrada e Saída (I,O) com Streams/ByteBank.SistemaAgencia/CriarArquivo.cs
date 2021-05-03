using System.IO;
using System.Text;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
        static void CriarArquivo()
        {
            var caminhoNovoArquivo = "../contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                var contaComoString = "3434,23213233,1231232.50, Gustavo Santos";
                var encoding = Encoding.UTF8;
                var bytes = encoding.GetBytes(contaComoString);
                
                fluxoDeArquivo.Write(bytes, 0, bytes.Length);
            }
        }
    }
}