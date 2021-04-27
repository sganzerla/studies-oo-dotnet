namespace ByteBank.Modelos
{
    public class AutenticacaoHelper
    {
        internal bool CompararSenhas(string senhaVerdadeira, string senhaTentativa)
        {
            return senhaTentativa == senhaVerdadeira;
        }
    }
}