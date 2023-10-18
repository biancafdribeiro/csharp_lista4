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
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo! Digite as informações:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.Write("Você é um aluno (S/N)? ");
            string resposta = Console.ReadLine();

            if (resposta.ToLower() == "s")
            {
                Console.Write("Matrícula: ");
                string matricula = Console.ReadLine();

                Console.Write("Curso: ");
                string curso = Console.ReadLine();

                Aluno aluno = new Aluno(nome, idade, matricula, curso);
                aluno.ExibirInformacoesAluno();
            }
            else
            {
                Pessoa pessoa = new Pessoa(nome, idade);
                pessoa.ExibirInformacoesPessoa();
            }

            /*Pessoa pessoa = new Pessoa("Bianca", 20);
            pessoa.ExibirInformacoesPessoa();

            Aluno aluno = new Aluno("Bianca", 20, "CB30", "ADS");
            aluno.ExibirInformacoesAluno();*/

            Console.ReadKey();
        }
    }
}
