using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            int idade = 22;
            System.Int32 idade2 = idade;

            Console.WriteLine($"Valor da idade 1: {idade}");
            Console.WriteLine($"Valor da idade 2: {idade2}");

            idade = 23;

            Console.WriteLine($"Valor da idade 1: {idade}");
            Console.WriteLine($"Valor da idade 2: {idade2}");

            // The int don't receive null value;
            int? idade3 = null;
            System.Nullable<int> idade4 = null;

        }
    }
}
