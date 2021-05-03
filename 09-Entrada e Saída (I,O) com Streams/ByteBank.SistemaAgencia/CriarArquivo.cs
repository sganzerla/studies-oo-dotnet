using System;
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

        static void CriarArquivoComWriter()
        {
            var caminhoNovoArquivo = "../contasExportadas.csv";

            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDeArquivo))
                {
                    escritor.Write("2323,232323,2323.0, Félix Almeida");
                }
                {
                    
                }
            }
        }

        static void TestaEscrita(){

            var caminhoNovoArquivo = "../contasExportadas.csv";
            using (var fluxoDeArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
            {
                using (var escritor = new StreamWriter(fluxoDeArquivo))
                {
                    for (int i = 0; i < 100000; i++)
                    {
                        escritor.WriteLine($"Linha {i}");
                        escritor.Flush(); //  Despeja o buffer para o Stream, grava agora o texto
                        Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter para adicionar novamente.");
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}