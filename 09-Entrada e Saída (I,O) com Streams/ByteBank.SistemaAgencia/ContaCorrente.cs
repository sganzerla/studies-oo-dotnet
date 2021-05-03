using System;

namespace ByteBank.SistemaAgencia
{
    /// <summary>
    /// Define uma Conta Corrente do banco ByteBank
    /// </summary>
    public class ContaCorrente : IComparable
    {
        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }
        public Cliente Titular { get; set; }

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

        public ContaCorrente()
        {

        }

        /// <summary>
        /// Cria uma instância de ContaCorrente com os arumentos utilizados
        /// </summary>
        /// <param name="agencia">Representa o valor da propriedade <see cref="Agencia"/> e deve possuir valor maior que zero </param>
        /// <param name="numero">Representa o valor da propriedade <see cref="Numero"/> e deve possuir valor maior que zero </param>
        public ContaCorrente(  int agencia, int numero)
        {

            if (agencia <= 0)
                throw new ArgumentException($"Parâmetro {nameof(agencia)} deve ser maior que zero.", nameof(agencia));

            if (numero <= 0)
                throw new ArgumentException($"Parâmetro {nameof(numero)} deve ser maior que zero.", nameof(numero));

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

        /// <summary>
        /// Método para realizar saque da conta corrente.
        /// </summary>
        /// <param name="valor">Representa o valor que será sacado, o parâmetro <paramref name="valor"/> não pode ser menor que zero nem que o saldo da conta.</param>
        /// <exception cref="ArgumentException">Exceção será lançada quando o parâmetro <paramref name="valor"/> possuir valor menor que zero. </exception>
        public void Sacar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor inválido para o saque.", nameof(valor));

            if (_saldo < valor)
                ContadorSaquesNaoPermitidos++;

            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Sacando ... " + valor  );
            Console.WriteLine("");
            _saldo -= valor;
        }

        /// <summary>
        /// Método para realizar depositos na conta corrente.
        /// </summary>
        /// <param name="valor">Representa o valor para deposito, <paramref name="valor"/> não pode ser menor que zero.</param>
        /// <exception cref="ArgumentException">Exceção lançada quando o parâmetro <paramref name="valor"/> recece valor menor que zero.</exception>
        public void Depositar(double valor)
        {
            if (valor < 0)
                throw new ArgumentException("Valor inválido para o deposito.", nameof(valor));

            _saldo += valor;
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Depositando ... " + valor  );
            Console.WriteLine("");
        }

        /// <summary>
        /// Método para realizar transferências de valores para outra conta corrente.
        /// </summary>
        /// <param name="valor">Representa o valor a ser transferido, não pode ser menor que zero e nem que o <see cref="Saldo"/>.</param>
        /// <param name="contaDestino">Representa o valor da conta corrente que receberá a transferência. </param>
        /// <exception cref="ArgumentException">Exceção lançada quando o parâmetro <paramref name="valor"/> recece valor menor que zero.</exception>
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
                throw new ArgumentException("Valor inválido para tranferência.", nameof(valor));

            try
            {
                Sacar(valor);
            }
            catch (Exception ex)
            {
                ContadorTransferenciasNaoPermitidas++;
            }
            Console.WriteLine("-----------------------------------------------------------------------------");
            Console.WriteLine("Transferindo ... " + valor     );
            Console.WriteLine("");
            contaDestino.Depositar(valor);
        }


        public override bool Equals(object obj)
        {
            ContaCorrente outraConta = obj as ContaCorrente;
            if (outraConta == null)
                return false;

            return Numero == outraConta.Numero && Agencia == outraConta.Agencia;
        }

        public void WriteLine()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Agência: " + Agencia);
            Console.WriteLine("Número: " + Numero);
            Console.WriteLine("Saldo: " + Saldo);
            Console.WriteLine("");
        }

        /// <summary>
        /// Compara item recebido com a instância atual da classe e retorna um valor inteiro como resultado 
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>
        /// Quando instância é menor que o objeto recebido retorna número negativo
        /// Quando são equivalentes retorna zero
        /// Quando instância é maior que o objeto recebido retorna número positivo
        /// </returns>
        /// <exception cref="ArgumentException">Exceção será lançada quando o parâmetro <paramref name="obj"/> não for uma instância da classe <see cref="ContaCorrente"/> </exception>
        public int CompareTo(object obj)
        {

            var outraConta = obj as ContaCorrente;
            if (outraConta == null)
                throw new ArgumentNullException($"Exception: Argumento não é do tipo {nameof(ContaCorrente)} e não pode ser comparado.");

            if (Numero < outraConta.Numero)
                return -1;

            if (Numero > outraConta.Numero)
                return 1;

            return 0;
        }
    }
}