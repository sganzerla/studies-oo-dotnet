using System;
using ByteBank.Funcionarios;

namespace ByteBank.Sistemas
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine("Logado");
                return true;
            }
            else
            {
                Console.WriteLine("Senha errada.");
                return false;
            }
        }
    }
}