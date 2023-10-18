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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo! Digite as informações sobre seu animal.");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Espécie: ");
            string especie = Console.ReadLine();

            Console.Write("Gênero: ");
            string genero = Console.ReadLine();

            Console.Write("Quantidade de mamas: ");
            int quantidadedemamas = int.Parse(Console.ReadLine());

            if (quantidadedemamas == 0)
            {
                Console.WriteLine("Não é mamífero.");
                Animal animal = new Animal(nome, especie);
                animal.MostrarInformacoesAnimal();
            }

            else
            {
                Console.WriteLine("É mamífero.");
                Mamifero mamifero = new Mamifero(nome, especie, genero, quantidadedemamas);
                mamifero.MostrarInformacoesMamifero();
            }

            Console.ReadKey();
        }
    }
}
