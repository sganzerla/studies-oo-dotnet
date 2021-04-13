using System;

namespace ByteBank.Funcionarios
{
    public abstract class Funcionario
    {
        public static int TotalDeFuncionarios { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public double Salario { get; protected set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            TotalDeFuncionarios++;
            WriteLine();
        }

        public abstract void AumentarSalario();
        // {
        //     // Salario = Salario + (Salario * 0.1);
        //     // Salario = Salario * 1.1;
        //     // Salario *= 1.1;
        //     // Console.WriteLine("Aumentar salário de " + Nome + " para " + Salario);
        // }
        public abstract double GetBonificacao();
        // {
        //     return Salario * 0.10;
        // }

        public void WriteLine()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Total de funcionários: " + TotalDeFuncionarios);
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Cpf: " + Cpf);
            Console.WriteLine("Salário: " + Salario);
            Console.WriteLine("Bonificação: " + GetBonificacao());
            Console.WriteLine();
        }

    }
}