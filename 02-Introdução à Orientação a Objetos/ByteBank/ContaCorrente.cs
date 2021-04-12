using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public Cliente Titular { get; private set; }
        public int NumeroAgencia { get; private set; }
        public int Numero { get; private set; }
        public double Saldo { get; private set; } = 100;

        public ContaCorrente(Cliente cliente, int numeroAgencia, int numero)
        {
            Titular = cliente;
            NumeroAgencia = numeroAgencia;
            Numero = numero;

        }

        public bool Sacar(double valor)
        {
            if (Saldo < valor) return false;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Sacando ... " + valor + " de " + Titular.Nome);
            Console.WriteLine("");
            Saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            Saldo += valor;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Depositando ... " + valor + " para " + Titular.Nome);
            Console.WriteLine("");
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Sacar(valor))
            {
                Console.WriteLine("-----------------------------------------------------------------------------");
                Console.WriteLine("Transferindo ... " + valor + " de " + Titular + " para " + contaDestino.Titular.Nome);
                Console.WriteLine("");
                contaDestino.Depositar(valor);
            }
        }

        public void WriteLine()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Titular: " + Titular.Nome);
            Console.WriteLine("Nr Agência: " + NumeroAgencia);
            Console.WriteLine("Número: " + Numero);
            Console.WriteLine("Saldo: " + Saldo);
            Console.WriteLine("");


        }

    }
}