namespace ByteBank.Modelos
{
    public class Cliente
    {
        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public string Profissao { get; private set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
        }

    }
}