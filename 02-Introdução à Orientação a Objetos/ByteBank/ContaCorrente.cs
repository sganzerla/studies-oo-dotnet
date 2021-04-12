using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente titular { get; set; }
        public int numeroAgencia { get; set; }
        public int numero { get; set; }
        public double saldo { get; set; } = 100;

        public bool Sacar(double valor)
        {
            if (saldo < valor) return false;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Sacando ... " + valor + " de " + titular.Nome);
            Console.WriteLine("");
            saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Depositando ... " + valor + " para " + titular.Nome);
            Console.WriteLine("");
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Sacar(valor))
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("Transferindo ... " + valor + " de " + titular + " para " + contaDestino.titular.Nome);
                Console.WriteLine("");
                contaDestino.Depositar(valor);
            }
        }

        public void WriteLine()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Titular: " + titular.Nome);
            Console.WriteLine("Nr Agência: " + numeroAgencia);
            Console.WriteLine("Número: " + numero);
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("");


        }

    }
}