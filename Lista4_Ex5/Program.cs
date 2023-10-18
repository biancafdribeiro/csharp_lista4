using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Crie uma classe base "Conta" com atributos "Numero" e "Saldo". Em seguida, crie uma
classe derivada "ContaPoupanca" que acrescenta atributos "TaxaJuros" e
"RendimentoMensal". Implemente métodos para calcular o rendimento mensal e
exibir informações da conta.*/

namespace Lista4_Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bem vindo! Digite suas informações.");
            Console.WriteLine("___________________________________________");

            Console.Write("Número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Saldo da conta: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Taxa de juros: ");
            double taxaJuros = double.Parse(Console.ReadLine());

            ContaPoupanca contapoupanca = new ContaPoupanca(numero, saldo, taxaJuros);
            contapoupanca.Calcular();

            Conta conta = new Conta(numero, saldo);
            conta.MostrarInformacoes();

            Console.ReadKey();
        }
    }
}
