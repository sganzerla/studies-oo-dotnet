namespace ByteBank.Funcionarios
{
    public class Diretor : Funcionario
    {
        public Diretor(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override double GetBonificacao()
        {
            return Salario + base.GetBonificacao();
        }
    }
}