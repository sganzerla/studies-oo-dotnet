namespace ByteBank.Modelos.Funcionarios
{
    public class Desenvolvedor : Funcionario
    {
        public Desenvolvedor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {

        }

        public override void AumentarSalario()
        {
            Salario *= 1.05;
        }

        internal protected override double GetBonificacao()
        {
            return Salario *= 0.12;
        }
    }
}