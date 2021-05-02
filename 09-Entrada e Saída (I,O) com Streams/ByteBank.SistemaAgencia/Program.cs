using System.Collections.Generic;
using System;
using System.Linq;
using System.IO;
using System.Text;
namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
        static void Main(string[] args)
        {
            // LidandoComFileStreamDiretamente();

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

            Console.ReadLine();
        }


        static ContaCorrente ConverterStringParaContaCorrente(string linha)
        {
            var campos = linha.Split(',');
            var agencia = campos[0];
            var numero = campos[1];
            var saldo = campos[2].Replace('.', ',');
            var nomeTitular = campos[3];

            var titular = new Cliente(nomeTitular);

            var resultado = new ContaCorrente(int.Parse(agencia), int.Parse(numero));
            resultado.Depositar(double.Parse(saldo));
            resultado.Titular = titular;
            return resultado;
        }

        static void EscreverBuffer(byte[] buffer, int bytesLidos)
        {

            // var utf8 = new UTF8Encoding();
            var utf8 = Encoding.UTF8;
            var texto = utf8.GetString(buffer, 0, bytesLidos);
            Console.Write(texto);
            // foreach (var meuByte in buffer)
            // {
            //     Console.Write(meuByte);
            //     Console.Write(" ");
            // }
        }


    }
}
