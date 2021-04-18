
namespace ByteBank.Modelos
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public ParceiroComercial(string senha)
        {
            Senha = senha;
        }

        public bool Autenticar(string senha)
        {
            return senha == Senha;
        }
    }
}