using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            string urlParametros = "https://www.ssdd.com/cambio?moeda=real&moedaDist=dolar";
            ExtratorValorDeArgumentosURL extratorValor = new ExtratorValorDeArgumentosURL(urlParametros);
            string valor = extratorValor.GetValor("moeda");
            Console.WriteLine(valor);

            valor = extratorValor.GetValor("moedaDist");
            Console.WriteLine(valor);
            Console.ReadLine();
        }

    }
}
