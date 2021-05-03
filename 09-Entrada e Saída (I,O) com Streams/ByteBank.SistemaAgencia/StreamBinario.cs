using System;
using System.IO;

namespace ByteBank.SistemaAgencia
{
    partial class Program
    {

        static void EscritaBinaria()
        {
            using (var fs = new FileStream(path: "../contaCorrente.txt", FileMode.Create))
            {
                using (var escritor = new BinaryWriter(fs))
                {
                    escritor.Write(3232323); // numero agencia
                    escritor.Write(2323232); // numero da conta
                    escritor.Write(12121212.3434); // saldo
                    escritor.Write("Paulo Pinto");
                }
            }
        }

        static void LeituraBinaria()
        {
            using (var fs = new FileStream(path: "../contaCorrente.txt", FileMode.Open))
            {
                using (var leitor = new BinaryReader(fs))
                {
                    var agencia = leitor.ReadInt32();
                    var numeroConta = leitor.ReadInt32();
                    var saldo = leitor.ReadDouble();
                    var titular = leitor.ReadString();
                    
                    Console.WriteLine($"Agência:{agencia}, Conta: {numeroConta}, Saldo: {saldo}, Titular: {titular}");
                }
            }
        }
    }
}