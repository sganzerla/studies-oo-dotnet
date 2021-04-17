using System;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente gabriela = new Cliente("Gabriela", "09230293720", "Reporter");
            Cliente gabrielaCosta = new Cliente("Gabriela Costa", "2323123892", "Radialista");
            try
            {
                ContaCorrente contaDaGabriela = new ContaCorrente(gabriela, 10, 222);
                // ContaCorrente contaDaGabriela = new ContaCorrente(gabriela, 0, 222); // erro
                ContaCorrente contaDaGabrielaCosta = new ContaCorrente(gabrielaCosta, 20, 2222);
                // ContaCorrente contaDaGabrielaCosta = new ContaCorrente(gabrielaCosta, 0, 2222); // erro
                // contaDaGabrielaCosta.Sacar(-30); // erro
                contaDaGabrielaCosta.Sacar(30);
                contaDaGabriela.WriteLine();
                // contaDaGabriela.Depositar(-200); // erro
                contaDaGabriela.Depositar(200);
                contaDaGabrielaCosta.WriteLine();
                // contaDaGabriela.Transferir(500, contaDaGabrielaCosta); // erro
                contaDaGabriela.Transferir(2300, contaDaGabrielaCosta);
                contaDaGabriela.WriteLine();
                contaDaGabrielaCosta.WriteLine();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }
            catch (SaldoInsuficienteException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                return;
            }
            catch (OperacaoFinanceiraException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine(ex.InnerException.StackTrace);
            }
            Console.ReadLine();
        }
    }
}
