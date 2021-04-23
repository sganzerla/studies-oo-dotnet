
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContaCorrente()
        {
            _itens = new ContaCorrente[5];
            _proximaPosicao = 0;
        }


        public void Adicionar(ContaCorrente item)
        {
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

    }
}