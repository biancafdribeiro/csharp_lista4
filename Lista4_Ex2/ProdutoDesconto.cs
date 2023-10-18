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
    public class ProdutoDesconto : Produto
    {
        public double DescontoPercentual { get; set; }
        public double PrecoComDesconto { get; set; }

        public ProdutoDesconto(string nome, double preco, double descontoPercentual) : base(nome, preco)
        {
            DescontoPercentual = descontoPercentual;
            PrecoComDesconto = 0;
            Calcular();
        }

        public void Calcular()
        {
            if (DescontoPercentual <= 0)
            {
                Console.WriteLine("O produto não tem desconto.");
                PrecoComDesconto = Preco;
            }

            else
            {
                PrecoComDesconto = Preco - (Preco * DescontoPercentual / 100);
                Console.WriteLine("O preço com desconto é {0}", PrecoComDesconto);
            }

        }
        public void ExibirInformacoes()

        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Preço: {Preco:C}");
            Console.WriteLine($"Desconto: {DescontoPercentual}%");
            Console.WriteLine($"Preço com Desconto: {PrecoComDesconto:C}");
        }
        
    }
}
