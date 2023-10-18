using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe base "Pessoa" com atributos "Nome" e "Idade". Crie uma classe
derivada "Aluno" que acrescenta atributos "Matricula" e "Curso". Implemente
métodos para exibir informações da pessoa e do aluno.*/

namespace Lista4_Ex3
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        //construtor
        public Pessoa(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public void ExibirInformacoesPessoa()
        {
            Console.WriteLine(($"Nome: {Nome}"));
            Console.WriteLine(($"Idade: {Idade}"));
        }
    }
}
