using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "pagina?argumentos";
            ExtratorValorDeArgumentosURL extrator = new ExtratorValorDeArgumentosURL(texto);
            extrator.RemoveQuantidadeDeStringInicio(6);

            extrator.RemoveStringAPartirDeIndice("?");

            Console.ReadLine();
        }

    }
}
