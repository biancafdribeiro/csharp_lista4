using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe base chamada "Veiculo" com atributos "Marca" e "Ano". Em seguida,
crie uma classe derivada "Carro" que acrescenta atributos "Modelo" e
"VelocidadeAtual". Implemente métodos para "Acelerar()" e "Frear()", que afetam a
velocidade do carro.*/

namespace Lista4_Ex1
{
    public class Veiculo
    {
        public string Marca { get; set; }
        public int Ano { get; set; }

        //construtor
        public Veiculo(string marca, int ano)
        {
            //atribuindo os valores dos parâmetros marca e ano
            //às propriedades Marca e Ano do objeto que está sendo criado.
            Marca = marca;
            Ano = ano;
        }
    }
}
