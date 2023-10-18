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
    public class Aluno : Pessoa
    {
        public string Matricula { get; set; }
        public string Curso { get; set; }

        //construtor
        public Aluno(string nome, int idade, string matricula, string curso) : base(nome, idade)
        {
            Matricula = matricula;
            Curso = curso;
        }

        public void ExibirInformacoesAluno()
        {
            Console.WriteLine(($"Nome: {Nome}"));
            Console.WriteLine(($"Idade: {Idade}"));
            Console.WriteLine(($"Curso: {Curso}"));
            Console.WriteLine(($"Matrícula: {Matricula}"));
        }
    }
}
