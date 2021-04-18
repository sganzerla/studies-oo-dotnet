using System;
using ByteBank.Modelos;
namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente = new Cliente("Alisson", "87282872112", "Analista de Sistemas");
            ContaCorrente conta = new ContaCorrente(cliente, 2, 3);
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
