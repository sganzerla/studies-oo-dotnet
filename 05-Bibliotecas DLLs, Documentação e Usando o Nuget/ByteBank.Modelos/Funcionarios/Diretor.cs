using System;
namespace ByteBank.Modelos.Funcionarios

{
    public class Diretor : FuncionarioAutenticavel
    {
        public Diretor(string nome, string cpf, string senha) : base(nome, cpf, 5000, senha)
        {
            Senha = senha;
            Console.WriteLine("Criando ... " + typeof(Diretor));
        }

        public override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }
}