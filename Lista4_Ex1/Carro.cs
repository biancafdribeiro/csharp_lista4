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
    public class Carro : Veiculo
    {
        public string Modelo { get; set; }
        public int VelocidadeAtual { get; private set; }

        //construtor
        public Carro(string marca, int ano, string modelo) : base(marca, ano) //chamando o construtor da
                                                                              //classe base Veiculo
                                                                              //e inicializando as
                                                                              //propridades marca e ano
        {
            Modelo = modelo;
            VelocidadeAtual = 0;
        }

        public void Acelerar(int incremento)
        {
            if (incremento > 0)
            {
                VelocidadeAtual += incremento;
                Console.WriteLine($"O carro acelerou para {VelocidadeAtual} km/h.");
            }
            else
            {
                Console.WriteLine("O incremento de velocidade deve ser maior que zero.");
            }
        }

        public void Frear(int decremento)
        {
            if (decremento > 0)
            {
                if (VelocidadeAtual >= decremento)
                {
                    VelocidadeAtual -= decremento;
                    Console.WriteLine($"O carro reduziu a velocidade para {VelocidadeAtual} km/h.");
                }
                else
                {
                    Console.WriteLine("O carro já está parado.");
                }
            }
            else
            {
                Console.WriteLine("O decremento de velocidade deve ser maior que zero.");
            }
        }
    }
}
