using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite numero para calcular o fatorial:");
            int numero = int.Parse(Console.ReadLine());

            long fatorial = 1;
            for (int i= 1; i <= numero; i++) {

                fatorial *= i;
            }

            Console.WriteLine($"O fatorial de {numero} é {fatorial}");
            Console.ReadLine();
        }
       
    }
}
