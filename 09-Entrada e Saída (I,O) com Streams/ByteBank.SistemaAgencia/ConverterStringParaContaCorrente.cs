using System.Collections.Generic;
using System;
using System.Linq;
using System.IO;
using System.Text;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
        static void ConverterStringParaContaCorrente()
        {
            var enderecoDoArquivo = "../contas.txt";
            using (var fluxoDeArquivo = new FileStream(enderecoDoArquivo, FileMode.Open))
            {
                using (var leitor = new StreamReader(fluxoDeArquivo, Encoding.UTF8))
                {
                    while (!leitor.EndOfStream)
                    {
                        var linha = leitor.ReadLine();
                        var contaCorrente = ConverterStringParaContaCorrente(linha);
                        Console.WriteLine($"{ contaCorrente.Titular.Nome } Conta número: {contaCorrente.Numero}, agência: {contaCorrente.Agencia}, saldo: { contaCorrente.Saldo }");
                    }

                }
            }
        }
    }
}