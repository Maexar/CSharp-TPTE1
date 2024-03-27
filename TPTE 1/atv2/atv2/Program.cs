using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace atv2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero para iniciar a contagem regressiva: ");
            int numero = int.Parse(Console.ReadLine());

            Console.WriteLine("Contagem regressiva:");

            for (int i = numero; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000); //aguarda 1 sec. Diminua para a contagem ir mais rapida
            }

            Console.WriteLine("Fim da contagem regressiva.");
            Console.ReadLine();//faz o programa esperar um enter
        }
    }
}
