using System;
using ByteBank.Funcionarios;
namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
            Funcionario carlos = new Funcionario("Carlos", "0903292380", 2000.0);
            gerenciador.Registrar(carlos);
            Funcionario roberto = new Diretor("Roberto", "0903292380", 2500.0);
            gerenciador.Registrar(roberto);

            Console.WriteLine("Total de bonificação: " + gerenciador.GetTotalBonificacao());

            Console.ReadLine();
        }
    }
}
