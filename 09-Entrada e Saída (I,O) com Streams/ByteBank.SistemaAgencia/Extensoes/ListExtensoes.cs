using System.Collections.Generic;
namespace ByteBank.SistemaAgencia.Extensoes
{
    public static class ListExtensoes
    {
        public static void AdicionarVarios<T>(this List<T> list, params T[] itens)
        {
            foreach (T item in itens)
            {
                list.Add(item);
            }
        }

    }
}