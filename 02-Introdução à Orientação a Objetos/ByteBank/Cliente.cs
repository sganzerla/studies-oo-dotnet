namespace ByteBank
{
    public class Cliente
    {
        public string Nome { get; set; }

        public string Cpf { get; set; }

        public string Profissao { get; set; }

        public Cliente(string nome, string cpf, string profissao)
        {
            Nome = nome;
            Cpf = cpf;
            Profissao = profissao;
        }

    }
}