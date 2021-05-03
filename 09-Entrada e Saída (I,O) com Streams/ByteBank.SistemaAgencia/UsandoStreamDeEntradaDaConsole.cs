using System;
using System.IO;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    {
        static void UsarStreamDeEntrada()
        {
            using (var fluxoDeEntrada = Console.OpenStandardInput())
                using (var fs = new FileStream("../entradaConsole.txt", FileMode.Create))
                {
                    {
                        var buffer = new byte[1024]; // 1kb
                        while (true)
                        {
                            var bytesLidos = fluxoDeEntrada.Read(buffer, 0, 1024);
                            fs.Write(buffer, 0, bytesLidos);
                            fs.Flush();
                            Console.WriteLine($"ByteLidos da console {bytesLidos}");
                        }
                    }
                }
        }
        
    }
}