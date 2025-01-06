using System;
using System.Globalization;

namespace POO_CSharp_P4
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            Produto p = new Produto("TV", 500.00, 10);

            p.Nome = "TV 4K";

            Console.WriteLine(p.Nome);
            Console.WriteLine(p.Preco);


            //Equanto não há encapsulamento a inserção abaixa é permitida, o que não é o ideal. passe o atributo para private 
            //p.Quantidade = -10;
            
            //Console.WriteLine("Entre os dados do produto:");
            //Console.Write("Nome: ");
            //string nome = Console.ReadLine();
            //Console.Write("Preço: ");
            //double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ////Console.Write("Quantidade no estoque: ");
            ////int quantidade = int.Parse(Console.ReadLine());
            ////Adaptado com construtor
            //// Produto p = new Produto(nome, preco, quantidade);

            //Produto p = new Produto(nome, preco);

            //Produto p2 = new Produto();

            ////Sintaxe alternativa para inicializar valores
            //Produto p3 = new Produto { 
            //    Nome = "TV"
            //    , Preco = 500.00
            //    , Quantidade = 10
            //};

            //Console.WriteLine();
            //Console.WriteLine("Dados do produto: " + p);

            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
            //int qte = int.Parse(Console.ReadLine());
            //p.AdicionarProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
            //Console.WriteLine();
            //Console.Write("Digite o número de produtos a ser removido do estoque: ");
            //qte = int.Parse(Console.ReadLine());
            //p.RemoverProdutos(qte);

            //Console.WriteLine();
            //Console.WriteLine("Dados atualizados: " + p);
            

        }
    }
}