using System.Collections.Generic;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public class ComparadorContaCorrentePorAgencia : IComparer<ContaCorrente>
    {
        public int Compare(ContaCorrente x, ContaCorrente y)
        {

            if (x == null)
                return 1;

            if (y == null)
                return -1;

            //  return x.Agencia.CompareTo(y.Agencia); // faz a mesma coisa que os três abaixo

            if (x.Agencia < y.Agencia)
                return -1;

            if (x.Agencia > y.Agencia)
                return 1;

            return 0;


        }
    }
}