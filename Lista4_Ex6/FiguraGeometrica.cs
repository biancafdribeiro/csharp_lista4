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
    public class FiguraGeometrica
    {
        public string Nome { get; set; }

        public FiguraGeometrica(string nome) 
        {
            Nome = nome;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
        }

    }
}
