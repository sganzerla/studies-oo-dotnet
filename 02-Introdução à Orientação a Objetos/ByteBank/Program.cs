using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {

            ContaCorrente contaDaGabriela = new ContaCorrente();

            contaDaGabriela.titular = "Gabriela";
            contaDaGabriela.numeroAgencia = 4545;
            contaDaGabriela.numero = 3334;

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();

            contaDaGabrielaCosta.titular = "Gabriela Costa";
            contaDaGabrielaCosta.numeroAgencia = 4545;
            contaDaGabrielaCosta.numero = 3334;


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
