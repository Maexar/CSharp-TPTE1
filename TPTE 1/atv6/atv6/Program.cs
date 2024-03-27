using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace atv6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Postivos = new List<int>();

            while(true)
            {
                Console.Write("Digite um número(negativo para sair):");
                int numero = int.Parse(Console.ReadLine());

                if(numero < 0)
                {
                    break;
                }

                Postivos.Add(numero);
            }

           Console.WriteLine("Numeros positivos inseridos:");
           foreach(int Posit in Postivos)
            {
                Console.WriteLine(Posit);
            }
           Console.ReadLine();  
        }
    }
}
