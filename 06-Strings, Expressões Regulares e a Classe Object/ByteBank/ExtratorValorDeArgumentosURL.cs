using System;
namespace ByteBank
{
    public class ExtratorValorDeArgumentosURL
    {
        private readonly string _argumentos;
        public string URL { get; }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="url"></param>
        public ExtratorValorDeArgumentosURL(string url)
        {

            if (string.IsNullOrEmpty(url))
                throw new ArgumentException("O argumento " + nameof(url) + " não pode ser vazio ou nulo.");

            int indiceInterrogacao = url.IndexOf('?');
            _argumentos = url.Substring(indiceInterrogacao + 1);
            URL = url;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="nomeParametro"></param>
        /// <returns></returns>

        public string GetValor(string nomeParametro)
        {
            string termo = nomeParametro.ToUpper() + "=";
            int indiceTermo = _argumentos.ToUpper().IndexOf(termo);
            string resultado = _argumentos.Substring(indiceTermo + termo.Length);
            int indiceEComercial = resultado.IndexOf('&');

            if (indiceEComercial == -1)
                return resultado;

            return resultado.Remove(indiceEComercial);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            ExtratorValorDeArgumentosURL extrato = obj as ExtratorValorDeArgumentosURL;
            if (extrato == null)
                return false;

            return URL == extrato.URL && _argumentos == extrato._argumentos;
        }

    }
}