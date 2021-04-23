using System;
using ByteBank.Modelos;

namespace ByteBank.SistemaAgencia
{
    public class ListaDeContaCorrente
    {
        private ContaCorrente[] _itens;
        private int _proximaPosicao;

        public ListaDeContaCorrente(int capacidadeInicial = 2)
        {
            _itens = new ContaCorrente[capacidadeInicial];
            _proximaPosicao = 0;
        }

        public void Adicionar(ContaCorrente item)
        {
            VerificaCapacidade(_proximaPosicao + 1);
            Console.WriteLine($"Adicionando item na posição {_proximaPosicao}");
            _itens[_proximaPosicao] = item;
            _proximaPosicao++;
        }

        private void VerificaCapacidade(int tamanhoNecessario)
        {
            if (_itens.Length >= tamanhoNecessario)
                return;

            var novoTamanho = _itens.Length * 2;
            if (novoTamanho < tamanhoNecessario)
                novoTamanho = tamanhoNecessario;

            Console.WriteLine("Aumentando a capacidade da Lista.");
            ContaCorrente[] novoArray = new ContaCorrente[novoTamanho];

            for (int indice = 0; indice < _itens.Length; indice++)
                novoArray[indice] = _itens[indice];

            _itens = novoArray;
        }

    }
}