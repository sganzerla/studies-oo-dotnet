using System;

namespace ByteBank
{
    public class ContaCorrente
    {

        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; private set; }
        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            private set
            {
                if (value < 0) return;
                _agencia = value;
            }
        }

        private int _numero;
        public int Numero
        {
            get
            {
                return _numero;
            }
            private set
            {
                if (value < 0) return;
                _numero = value;
            }
        }

        private double _saldo = 100;
        public double Saldo
        {
            get { return _saldo; }
            private set
            {
                if (value < 0) return;
                _saldo = value;
            }
        }

        public ContaCorrente(Cliente cliente, int numeroAgencia, int numero)
        {
            Titular = cliente;
            Agencia = numeroAgencia;
            Numero = numero;
            TotalDeContasCriadas++;
            Console.WriteLine("Total de contas criadas: " + TotalDeContasCriadas);

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
                Console.WriteLine("Transferindo ... " + valor + " de " + Titular.Nome + " para " + contaDestino.Titular.Nome);
                Console.WriteLine("");
                contaDestino.Depositar(valor);
            }
        }

        public void WriteLine()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Titular: " + Titular.Nome);
            Console.WriteLine("Agência: " + Agencia);
            Console.WriteLine("Número: " + Numero);
            Console.WriteLine("Saldo: " + Saldo);
            Console.WriteLine("");
        }

    }
}