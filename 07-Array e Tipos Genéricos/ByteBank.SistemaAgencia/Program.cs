using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            Lista<int> idades = new Lista<int>();
            idades.Adicionar(1);
            idades.AdicionarVarios(1, 2, 3, 4);
            Console.ReadLine();
        }

        static void TesteContaCorrente()
        {
            ListaDeContaCorrente lista = new ListaDeContaCorrente();
            ContaCorrente[] contas = new ContaCorrente[]{
                new ContaCorrente(new Cliente("Cliente A", "019231029371", "reporter"), agencia: 1, 12),
                new ContaCorrente(new Cliente("Cliente B", "019231029371", "surfista"), 1, 13),
                new ContaCorrente(new Cliente("Cliente C", "019231029371", "pedreiro"), 1, 14),
                new ContaCorrente(new Cliente("Cliente C", "019231029371", "pedreiro"), 2, 15),
                new ContaCorrente(new Cliente("Cliente C", "019231029371", "pedreiro"), 3, 16),
                new ContaCorrente(new Cliente("Cliente C", "019231029371", "pedreiro"), 2, 17)
            };
            lista.AdicionarVarios(contas);
            ListarItens(lista);
            lista.Remover(new ContaCorrente(new Cliente("Cliente C", "019231029371", "pedreiro"), 2, 15));
            ListarItens(lista);
        }

        static void ListarItens(ListaDeContaCorrente lista)
        {
            for (int i = 0; i < lista.Tamanho; i++)
            {
                ContaCorrente itemAtual = lista[i];
                Console.WriteLine($"índice: {i} Agência: {itemAtual.Agencia} Conta: {itemAtual.Numero}  ");

            }

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
