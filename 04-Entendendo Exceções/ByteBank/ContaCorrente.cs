using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        public int Agencia { get; }
        public int Numero { get; }
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

        public ContaCorrente(Cliente cliente, int agencia, int numero)
        {

            if (agencia <= 0)
                throw new ArgumentException($"Parâmetro {nameof(agencia)} deve ser maior que zero.", nameof(agencia));

            if (numero <= 0)
                throw new ArgumentException($"Parâmetro {nameof(numero)} deve ser maior que zero.", nameof(numero));

            Titular = cliente;
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
            try
            {
                TaxaOperacao = 30 / TotalDeContasCriadas;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            Console.WriteLine("Total de contas criadas: " + TotalDeContasCriadas);
            Console.WriteLine("Taxa de operação: " + TaxaOperacao);
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));

            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(Saldo, valor);
            }

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Sacando ... " + valor + " de " + Titular.Nome);
            Console.WriteLine("");
            _saldo -= valor;
        }

        public void Depositar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor inválido para o deposito.", nameof(valor));

            _saldo += valor;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Depositando ... " + valor + " para " + Titular.Nome);
            Console.WriteLine("");
        }

        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para tranferência.", nameof(valor));
            }

            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw;
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Transferindo ... " + valor + " de " + Titular.Nome + " para " + contaDestino.Titular.Nome);
            Console.WriteLine("");
            contaDestino.Depositar(valor);
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