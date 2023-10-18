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
    public class Produto
    {
        public string Nome { get; set; }
        public double Preco { get; set; }

        //construtor
        public Produto (string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}
