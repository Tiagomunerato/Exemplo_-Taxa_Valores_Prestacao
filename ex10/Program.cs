using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, taxa, tempo, prestacao;

            Console.Write("Informe o valor da Prestação: ");
            valor = double.Parse(Console.ReadLine());

            Console.Write("Informe a taxa de juros: ");
            taxa = double.Parse(Console.ReadLine());

            Console.Write("Informe a qtde de dias em atraso: ");
            tempo = double.Parse(Console.ReadLine());

            prestacao = valor + (valor * (taxa / 100.0) * tempo);

            Console.WriteLine("Valor da Prestação para os dias em atraso R$ {0:N}", prestacao);
            Console.ReadKey();


        }
    }
}
