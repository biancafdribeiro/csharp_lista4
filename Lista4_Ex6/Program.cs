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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo! Digite as informações sobre sua forma geométrica.");
            Console.WriteLine("____________________________________________________________");

            Console.Write("Nome da forma geométrica: ");
            string nome = Console.ReadLine();

            //melhorar
            if (nome == "Triangulo" || nome == "Triângulo" || nome == "TRIANGULO" || nome == "TRIÂNGULO")
            {
                Console.Write("Base do triângulo em centímetros: ");
                double @base = double.Parse(Console.ReadLine());

                Console.Write("Altura do triângulo em centímetros: ");
                double altura = double.Parse(Console.ReadLine());
                
                Triangulo triangulo = new Triangulo(nome, @base, altura);

                triangulo.MostrarInformacoes();
                triangulo.CalcularArea();
            }

            else
            {
                FiguraGeometrica figurageometrica = new FiguraGeometrica(nome);
                figurageometrica.MostrarInformacoes();
            }

            Console.ReadKey();
        }
    }
}
