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
    internal class Program
    {
        static void Main(string[] args)
        {
            //cria uma instância da classe Carro com base no construtor da mesma classe
            Carro meuCarro = new Carro("Ford", 2022, "Mustang");
            Console.WriteLine($"Meu carro: {meuCarro.Marca} {meuCarro.Modelo} ({meuCarro.Ano})");

            meuCarro.Acelerar(100);
            meuCarro.Frear(0);

            Console.ReadKey();
        }
    }
}
