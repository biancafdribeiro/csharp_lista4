using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe base "Animal" com atributos "Nome" e "Especie". Em seguida, crie
uma classe derivada "Mamifero" que acrescenta atributos "Genero" e
"QuantidadeMamas". Implemente métodos para exibir informações do animal e do
mamífero.*/

namespace Lista4_Ex4
{
    public class Animal
    {
        public string Nome { get; set; }
        public string Especie { get; set; }

        public Animal(string nome, string especie)
        {
            Nome = nome;
            Especie = especie;
        }

        public void MostrarInformacoesAnimal()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Espécie: {Especie}");
        }
    }
}
