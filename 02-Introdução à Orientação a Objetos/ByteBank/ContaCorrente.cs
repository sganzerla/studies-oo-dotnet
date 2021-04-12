using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public string titular { get; set; }
        public int numeroAgencia { get; set; }
        public int numero { get; set; }
        public double saldo { get; set; } = 100;

        public bool Sacar(double valor)
        {
            if (saldo < valor) return false;
            Console.WriteLine("Sacando ... " + valor + " de " + titular);
            saldo -= valor;
            return true;
        }

        public void Depositar(double valor)
        {
            saldo += valor;
            Console.WriteLine("Depositando ... " + valor + " para " + titular);
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (Sacar(valor))
            {
                Console.WriteLine("Transferindo ... " + valor + " de " + titular + " para " + contaDestino.titular);
                contaDestino.Depositar(valor);
            }
            return false;
        }

        public void WriteLine()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Titular: " + titular);
            Console.WriteLine("Nr Agência: " + numeroAgencia);
            Console.WriteLine("Número: " + numero);
            Console.WriteLine("Saldo: " + saldo);
            Console.WriteLine("");


        }

    }
}