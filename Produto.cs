using System.Globalization;

namespace POO_CSharp_P4
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        //Adicionando construtores
        //sobrecarga oferecendo mais de uma operação com o mesmo nome , porém com diferentes listas de
        //parâmetros.
        public Produto() { }
        //sobrecarga oferecendo mais de uma operação com o mesmo nome , porém com diferentes listas de
        //parâmetros.
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        //sobrecarga oferecendo mais de uma operação com o mesmo nome , porém com diferentes listas de
        //parâmetros.
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 1;
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
