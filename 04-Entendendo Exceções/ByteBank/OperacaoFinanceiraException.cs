using System;

namespace ByteBank
{
    public class OperacaoFinanceiraException : Exception
    {
        public OperacaoFinanceiraException()
        {

        }

        public OperacaoFinanceiraException(string mensagem) : base(mensagem)
        {

        }

        public OperacaoFinanceiraException(string mensagem, Exception execaoInterna) : base(mensagem, execaoInterna)
        {

        }

    }
}