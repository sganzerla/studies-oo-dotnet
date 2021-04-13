using System;
using ByteBank.Funcionarios;
namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrarFuncionarios();
            Console.ReadLine();
        }

        public static void RegistrarFuncionarios()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
        
            Funcionario roberto = new Diretor("Roberto", "0903292380", 2500.0);
            gerenciador.Registrar(roberto);
            roberto.AumentarSalario();

            Funcionario igor = new Designer("Igor", "0398709384734", 450.0);
            gerenciador.Registrar(igor);
            igor.AumentarSalario();

            Funcionario antoni = new Auxiliar("Antoni", "89736837368", 10308);
            gerenciador.Registrar(antoni);

            Funcionario naiara = new GerenteDeConta("Naiara", "337837718971", 2092);
            gerenciador.Registrar(naiara);

            Console.WriteLine("Total de bonificação: " + gerenciador.GetTotalBonificacao());
        }
    }
}
