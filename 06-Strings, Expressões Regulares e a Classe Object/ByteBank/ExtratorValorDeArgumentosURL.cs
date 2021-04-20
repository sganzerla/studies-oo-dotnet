using System;
namespace ByteBank
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {

            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("O argumento " + nameof(url) + " não pode ser vazio ou nulo.");

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
            URL = url;

        }


        public string GetValor(string nomeParametro)
        {
            string termo = nomeParametro + "=";
            int indiceTermo = _argumentos.IndexOf(termo);
            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
                return resultado;

            return resultado.Remove(indiceEComercial);
        }
      
    }
}