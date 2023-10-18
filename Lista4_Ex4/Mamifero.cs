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
    public class Mamifero : Animal
    {
        public string Genero { get; set; }
        public int QuantidadeMamas { get; set; }

        public Mamifero(string nome, string especie, string genero, int quantidademamas) : base(nome, especie)
        {
            Genero = genero;
            QuantidadeMamas = quantidademamas;
        }

        public void MostrarInformacoesMamifero()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Espécie: {Especie}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Quantidade de mamas: {QuantidadeMamas}");

        }
    }
}
