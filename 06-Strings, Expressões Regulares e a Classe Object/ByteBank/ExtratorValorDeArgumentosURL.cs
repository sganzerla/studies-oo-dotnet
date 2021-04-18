using System;
namespace ByteBank
{
    public class ExtratorValorDeArgumentosURL
    {

        public string URL { get; }
        public ExtratorValorDeArgumentosURL(string url)
        {

            if (string.IsNullOrEmpty(url))
                throw new ArgumentNullException(nameof(url));

            URL = url;

        }

        public void RemoveStringAPartirDeIndice(string indice)
        {
            GetInicioPrint();
            int indiceTexto = URL.IndexOf(indice);
            Console.WriteLine("Remover do texto \"" + URL + "\" a partir do índice gerado por " + indice + ".");
            Console.WriteLine("Índice: " + indice);
            Console.WriteLine(URL.Substring(indiceTexto + 1));
            GetFimPrint();
        }
        public void RemoveQuantidadeDeStringInicio(int quantidade)
        {
            GetInicioPrint();
            Console.WriteLine("Remover do texto \"" + URL + "\" as " + quantidade + " primeiras letras.");
            Console.WriteLine(URL.Substring(quantidade));
            GetFimPrint();
        }

        private static void GetInicioPrint() =>
            Console.WriteLine("-------------------------------------------------");


        private static void GetFimPrint() =>
            Console.WriteLine("");
    }
}