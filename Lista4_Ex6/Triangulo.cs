using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Crie uma classe base "FiguraGeometrica" com atributo "Nome". Em seguida, crie uma
classe derivada "Triangulo" que acrescenta atributos "Base" e "Altura". Implemente
métodos para calcular a área do triângulo e exibir informações.*/

namespace Lista4_Ex6
{
    public class Triangulo : FiguraGeometrica
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(string nome, double @base, double altura) : base(nome)
        {
            Base = @base;
            Altura = altura;
        }

        public void CalcularArea()
        {
            double area = Base * Altura / 2;
            Console.WriteLine($"A área do triângulo é: {area}");
        }
    }
}
