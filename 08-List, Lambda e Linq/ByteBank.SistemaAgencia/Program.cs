using System.Collections.Generic;
using System;
using ByteBank.Modelos;
using ByteBank.SistemaAgencia.Extensoes;

namespace ByteBank.SistemaAgencia
{
    class Program
    {
        static void Main(string[] args)
        {

            var contas = new List<ContaCorrente>(){

                new ContaCorrente(new Cliente("Carrel", "2837238723", "Comediante"), 899, 563),
                new ContaCorrente(new Cliente("Andy", "1231231231", "Produtor"), 343434, 12),
                new ContaCorrente(new Cliente("Vlad", "1231231231", "Produtor"), 112, 565),
                new ContaCorrente(new Cliente("Bet", "1231231231", "Produtor"), 65879, 33),
            };

            foreach (var item in contas)
                Console.WriteLine($"Conta número: {item.Numero}, agência: {item.Agencia}, cliente: {item.Titular.Nome}");

            Console.WriteLine("-----------------------");
            contas.Sort();

            foreach (var item in contas)
                Console.WriteLine($"Conta número: {item.Numero}, agência: {item.Agencia}, cliente: {item.Titular.Nome}");
            Console.WriteLine("-----------------------");
            contas.Sort(new ComparadorContaCorrentePorAgencia());

            foreach (var item in contas)
                Console.WriteLine($"Conta número: {item.Numero}, agência: {item.Agencia}, cliente: {item.Titular.Nome}");

            Console.ReadLine();
        }

        static void TestListString()
        {
            var nomes = new List<string>();
            nomes.Add("Carel");
            nomes.Add("Andy");
            nomes.Add("Cesar");
            nomes.AdicionarVarios("Patrick", "Bob", "Xuxu", "Anna");

            for (var i = 0; i < nomes.Count; i++)
                Console.WriteLine(nomes[i]);

            Console.WriteLine("---------");
            nomes.Sort();
            for (var i = 0; i < nomes.Count; i++)
                Console.WriteLine(nomes[i]);
        }

        static void TesteListInt()
        {
            var idades = new List<int>();
            idades.Add(1);
            idades.Add(2);
            // idades.AddRange(idades);
            idades.AdicionarVarios(12, 32, 4, 5, 63);

            for (var i = 0; i < idades.Count; i++)
                Console.WriteLine(idades[i]);
            idades.Sort();
            for (var i = 0; i < idades.Count; i++)
                Console.WriteLine(idades[i]);
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
