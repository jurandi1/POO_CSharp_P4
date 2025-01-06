using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace POO_CSharp_P4
{
    internal class Produto
    {
        private string _nome;
        private double _preco;
        private int _quantidade;

        //Adicionando construtores
        //sobrecarga oferecendo mais de uma operação com o mesmo nome , porém com diferentes listas de
        //parâmetros.
        public Produto()
        {
            _quantidade = 10;
        }
        //sobrecarga oferecendo mais de uma operação com o mesmo nome , porém com diferentes listas de
        //parâmetros.
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            _preco = preco;
        }
        //sobrecarga oferecendo mais de uma operação com o mesmo nome , porém com diferentes listas de
        //parâmetros.
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        // Properties
        // Propriedades
        //• https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/classes-and-structs/properties
        //• São definições de métodos encapsulados, porém expondo uma
        //sintaxe similar à de atributos e não de métodos
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (value != "" && value.Length > 1)
                {
                    _nome = value;
                }
            }
        }

        public double Preco
        {
            get { return _preco; }
        }
        public int Quantidade
        {
            get { return _quantidade; }
        }

        //implementando métodos get e set(encapsulamento)
        //public string GetNome()
        //{
        //    return _nome;
        //}

        //public void SetNome(string nome)
        //{
        //    //Vantagens do encapsulamento aplicando lógica
        //    if (nome != "" && nome.Length > 1)
        //    {
        //        _nome = nome;
        //    }
        //}

        //public double GetPreco()
        //{
        //    return _preco;
        //}

        //public int GetQuantidade()
        //{
        //    return _quantidade;
        //}

        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }

        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
