using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            Cliente gabriela = new Cliente("Gabriela", "09230293720", "Reporter");
            Cliente gabrielaCosta = new Cliente("Gabriela Costa", "2323123892", "Radialista");

            ContaCorrente contaDaGabriela = new ContaCorrente(gabriela, 453, 222);

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente(gabrielaCosta, 22, 2222);

            contaDaGabrielaCosta.Sacar(20);
            contaDaGabriela.WriteLine();
            contaDaGabriela.Depositar(200);
            contaDaGabrielaCosta.WriteLine();
            contaDaGabriela.Transferir(78, contaDaGabrielaCosta);
            contaDaGabriela.WriteLine();
            contaDaGabrielaCosta.WriteLine();

            Console.ReadLine();

        }
    }
}
