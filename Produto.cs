using System.Globalization;
using System.Runtime.Intrinsics.X86;

namespace POO_CSharp_P4
{
    internal class Produto
    {
        //Possui lógica particular
        private string _nome;
        //Propriedades autoimplementadas
        //• É uma forma simplificada de se declarar propriedades que não
        //necessitam lógicas particulares para as operações get e set.
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        //Adicionando construtores
        //sobrecarga oferecendo mais de uma operação com o mesmo nome , porém com diferentes listas de
        //parâmetros.
        public Produto()
        {
            Quantidade = 10;
        }
        //sobrecarga oferecendo mais de uma operação com o mesmo nome , porém com diferentes listas de
        //parâmetros.
        public Produto(string nome, double preco) : this()
        {
            _nome = nome;
            Preco = preco;
        }
        //sobrecarga oferecendo mais de uma operação com o mesmo nome , porém com diferentes listas de
        //parâmetros.
        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            Quantidade = quantidade;
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
                //lógica particular
                if (value != "" && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
