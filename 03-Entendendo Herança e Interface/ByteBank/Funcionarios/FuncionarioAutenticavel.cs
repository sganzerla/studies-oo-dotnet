using ByteBank.Sistemas;

namespace ByteBank.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }


        public FuncionarioAutenticavel(string nome, string cpf, double salario, string senha) : base(nome, cpf, salario)
        {
            Senha = senha;
        }

        public bool Autenticar(string senha)
        {
            return senha == Senha;
        }

    }
}