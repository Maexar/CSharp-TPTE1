using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, nota5, media;

            Console.WriteLine("Digite a nota da primeira disciplina");
            nota1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da segunda disciplina");
            nota2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da terceira disciplina");
            nota3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da quarta disciplina");
            nota4 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota da quinta disciplina");
            nota5 = int.Parse(Console.ReadLine());

            media = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            Console.Write($"Sua media foi de {media}");

            if (media >= 6)

                Console.WriteLine("\nAprovado!");

            else
                Console.WriteLine("\nReprovado!");

            Console.ReadLine();
        }
    }
}
