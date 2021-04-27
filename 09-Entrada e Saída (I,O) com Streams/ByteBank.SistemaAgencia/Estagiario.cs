using ByteBank.Modelos.Funcionarios;

namespace ByteBank.SistemaAgencia
{
    public class Estagiario : Funcionario
    {
        public Estagiario(string nome, string cpf, double salario) : base(nome, cpf, salario)
        {
        }

        public override void AumentarSalario()
        {

        }

        protected override double GetBonificacao()
        {
            throw new System.NotImplementedException();
        }

    }
}