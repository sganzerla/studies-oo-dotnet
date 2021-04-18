using System;
using ByteBank.Modelos;
using Humanizer;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Alisson", "87282872112", "Analista de Sistemas");
            ContaCorrente conta = new ContaCorrente(cliente, 2, 3);
            Console.WriteLine(conta.Saldo);



            DateTime dataFimPagamento = new DateTime(2021, 4, 18);
            DateTime hoje = DateTime.Now;

            TimeSpan diferenca = dataFimPagamento - hoje;

            Console.WriteLine("Vencimento em " + TimeSpanHumanizeExtensions.Humanize(diferenca));

            Console.ReadLine();
        }

    }
}
