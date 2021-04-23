using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            var cliente = new Cliente("Cliente A", "019231029371", "reporter");
            lista.Adicionar(new ContaCorrente(cliente, 123, 12312132));
            lista.Adicionar(new ContaCorrente(new Cliente("Cliente B", "019231029371", "surfista"), 1212, 343423));
            lista.Adicionar(new ContaCorrente(new Cliente("Cliente C", "019231029371", "pedreiro"), 7678, 4554));


            Console.ReadLine();
        }

        static void TestaArrayContaCorrente()
        {
            ContaCorrente[] contas = new ContaCorrente[] {
                 new ContaCorrente(new Cliente("Cliente A", "019231029371", "reporter"), 123, 12312132),
                 new ContaCorrente(new Cliente("Cliente B", "019231029371", "surfista"), 1212, 343423),
                 new ContaCorrente(new Cliente("Cliente C", "019231029371", "pedreiro"), 7678, 4554)
            };



            for (int i = 0; i < contas.Length; i++)
            {
                Console.WriteLine($"Conta {i} {contas[i].Titular.Nome}");
            }
        }

    }
}
