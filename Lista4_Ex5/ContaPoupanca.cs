using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crie uma classe base "Conta" com atributos "Numero" e "Saldo". Em seguida, crie uma
classe derivada "ContaPoupanca" que acrescenta atributos "TaxaJuros" e
"RendimentoMensal". Implemente métodos para calcular o rendimento mensal e
exibir informações da conta.*/

namespace Lista4_Ex5
{
    public class ContaPoupanca : Conta
    {
        public double TaxaJuros { get; set; }
        public double RendimentoMensal { get; set; }

        public ContaPoupanca(int numero, double saldo, double taxaJuros) : base(numero, saldo)
        {
            TaxaJuros = taxaJuros;
            RendimentoMensal = 0;
        }

        public void Calcular()
        {
            RendimentoMensal = Saldo * TaxaJuros;
            Console.WriteLine($"Seu rendimento mensal é {RendimentoMensal}");
        }
    }
}
