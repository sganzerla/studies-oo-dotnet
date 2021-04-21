using System;

namespace ByteBank.Modelos.Funcionarios
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
    
        internal protected abstract double GetBonificacao();
    

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