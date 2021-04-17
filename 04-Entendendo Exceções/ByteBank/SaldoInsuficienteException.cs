using System;

namespace ByteBank
{
    public class SaldoInsuficienteException : OperacaoFinanceiraException
    {

        public double Saldo { get; }
        public double Saque { get; }

        public SaldoInsuficienteException()
        {
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
        }

        public SaldoInsuficienteException(double saldo, double saque) : this("Exception: Tentativa de saque do valor de " + saque + " em uma conta com saldo " + saldo + ".")
        {
            Saldo = saldo;
            Saque = saque;
        }

        public SaldoInsuficienteException(string mensagem, Exception exceptionInterna) : base(mensagem, exceptionInterna)
        {

        }

    }
}