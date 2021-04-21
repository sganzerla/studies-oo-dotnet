using System;
using System.Text.RegularExpressions;
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


            // string padrao = "[0123456789][0123456789][0123456789][0123456789][-][0123456789][0123456789][0123456789][0123456789]";
            // string padrao = "[0-9][0-9][0-9][0-9][-][0-9][0-9][0-9][0-9]";
            // string padrao = "[0-9]{4,5}[-]{0,1}[0-9]{4}";
            string padrao = "[0-9]{4,5}-?[0-9]{4}";
            string textoTeste = "meu número é 12324-4545";
            Console.WriteLine("Padrão foi identificado? " + Regex.IsMatch(textoTeste, padrao));
            Console.WriteLine("Valor é: " + Regex.Match(textoTeste, padrao).Value);


            
            Console.ReadLine();
        }

    }
}
