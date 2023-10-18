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
    public class Conta
    {
        public int Numero { get; set; }
        public double Saldo { get; set; }

        public Conta(int numero, double saldo) 
        { 
            Numero = numero;
            Saldo = saldo;
        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Numero: {Numero}");
            Console.WriteLine($"Saldo: {Saldo}");
        }
    }
}
