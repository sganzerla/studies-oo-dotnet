using System;

namespace ByteBank.Modelos.Funcionarios
{
    public class GerenteDeConta : FuncionarioAutenticavel
    {
        public GerenteDeConta(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario, senha)
        {
            Senha = senha;
            Console.WriteLine("Criando ... " + typeof(GerenteDeConta));
        }

        internal protected override double GetBonificacao()
        {
            return Salario * 0.5;
        }

        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }
    }
}