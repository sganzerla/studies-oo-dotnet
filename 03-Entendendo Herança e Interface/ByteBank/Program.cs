using System;
using ByteBank.Funcionarios;
using ByteBank.Sistemas;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistrarFuncionarios();
            UsarSistema();
            Console.ReadLine();
        }

        public static void UsarSistema()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Diretor roberto = new Diretor("Roberto", "0903292380", "senha");
            roberto.AumentarSalario();
            gerenciador.Registrar(roberto);

            GerenteDeConta naiara = new GerenteDeConta("Naiara", "337837718971", 2092, "123");
            gerenciador.Registrar(naiara);

            ParceiroComercial parceiro = new ParceiroComercial("sne");

            SistemaInterno sistema = new SistemaInterno();
            sistema.Logar(roberto, "s");
            sistema.Logar(roberto, "senha");
            sistema.Logar(naiara, "s");
            sistema.Logar(naiara, "123");
            sistema.Logar(parceiro, "sne");
        }

        public static void RegistrarFuncionarios()
        {
            GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

            Funcionario roberto = new Diretor("Roberto", "0903292380", "senha");
            gerenciador.Registrar(roberto);
            roberto.AumentarSalario();

            Funcionario igor = new Designer("Igor", "0398709384734", 450.0);
            gerenciador.Registrar(igor);
            igor.AumentarSalario();

            Funcionario antoni = new Auxiliar("Antoni", "89736837368", 10308);
            gerenciador.Registrar(antoni);


            Console.WriteLine("Total de bonificação: " + gerenciador.GetTotalBonificacao());
        }
    }
}
