using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe base "Produto" com atributos "Nome" e "Preco". Em seguida, crie uma
classe derivada "ProdutoDesconto" que acrescenta atributos "DescontoPercentual" e
"PrecoComDesconto". Implemente métodos para calcular o preço com desconto e
exibir informações do produto.*/

namespace Lista4_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProdutoDesconto produto1 = new ProdutoDesconto("Produto A", 100, 10);
            produto1.ExibirInformacoes();

            Console.WriteLine("_______________________");

            ProdutoDesconto produto2 = new ProdutoDesconto("Produto B", 50, 0);
            produto2.ExibirInformacoes();

            Console.ReadKey();
        }
    }
}
