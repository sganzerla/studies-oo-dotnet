using System;

namespace ByteBank.Funcionarios
{
    public class Funcionario
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public double Salario { get; set; }

        public Funcionario(string nome, string cpf, double salario)
        {
            Nome = nome;
            Cpf = cpf;
            Salario = salario;
            WriteLine();
        }

        public virtual double GetBonificacao()
        {
            return Salario * 0.10;
        }

        public void WriteLine()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Nome: " + Nome);
            Console.WriteLine("Cpf: " + Cpf);
            Console.WriteLine("Salário: " + Salario);
            Console.WriteLine("Bonificação: " + GetBonificacao());
            Console.WriteLine();
        }

    }
}