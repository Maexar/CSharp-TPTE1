using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atv3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            while (true)
            {
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("2 - Listar Produtos");
                Console.WriteLine("3 - Sair");
                Console.Write("Escolha uma opção: ");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 1)
                {
                    Console.Write("Digite o nome do produto: ");
                    string nome = Console.ReadLine();

                    Console.Write("Digite o preço do produto: ");
                    double preco = double.Parse(Console.ReadLine());

                    Produto produto = new Produto(nome, preco);
                    produtos.Add(produto);
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("Produtos cadastrados:");
                    foreach (Produto produto in produtos)
                    {
                        Console.WriteLine($"Nome: {produto.Nome} - Preço: {produto.Preco}");
                    }
                }
                else if (opcao == 3)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente.");
                }
            }
        }
    }
}

class Produto
{
    public string Nome { get; set; }
    public double Preco { get; set; }

    public Produto(string nome, double preco)
    {
        Nome = nome;
        Preco = preco;
    }
}