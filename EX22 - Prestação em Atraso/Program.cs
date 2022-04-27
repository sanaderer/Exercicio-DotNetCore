//Calcular o valor de uma prestação em atraso. Mostra de forma simples como utilizar uma console com entrada e saída de dados e declarar variáveis.

using System;

namespace Prestacao_Atraso
{
    public class MyClass
    {
        static public void Main(string[] args)
        {
            int dias;
            double prestação, taxaJuros, prestaçãoAtual;

            System.Console.Write("Esta atrado a quantos dias a prestação: ");
            dias = int.Parse(Console.ReadLine());
            System.Console.Write("Qual o valor da prestação R$ ");
            prestação = double.Parse(Console.ReadLine());
            System.Console.Write("Qual a taxa de juros: ");
            taxaJuros = double.Parse(Console.ReadLine());

            prestaçãoAtual = ((prestação * taxaJuros / 100) * dias) + prestação;

            System.Console.WriteLine("Devido o atraso de {0} dias no pagamento da prestação, sua nova parcela com juros é de R$ {1}", dias, prestaçãoAtual.ToString("C"));

        }
    }   
}