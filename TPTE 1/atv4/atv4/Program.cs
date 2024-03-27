using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv4{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Aleatorio = random.Next(1,101);

            Console.WriteLine("Tente adivinhar o número( entre 1 e 100): ");
            
            int tentativas = 0;

            while(true)
            {
                Console.Write("Digite um número:");
                int palpite = int.Parse(Console.ReadLine());
                int opcao;
                tentativas++;

                if (palpite == Aleatorio)
                {
                    Console.WriteLine($"Parabens! Voce acertou em {tentativas} tentativas!");
                    Console.WriteLine("Deseja Jogar Novamente? Sim = 1 Não = 2");

                    break;
                }

                else if (palpite < Aleatorio) {
                    Console.WriteLine("O numero é maior");
                }
                else
                {
                    Console.WriteLine("O numero é menor");
                }


            }
            Console.ReadLine();
        }
    }
}
