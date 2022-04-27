//Calcular o quadrado de um número qualquer. Simples utilização de entrada e saída de dados via console e o método Math.Pow
//O quadrado de um número inteiro é calculado através da potenciação da base inteira em relação ao expoente de número dois. Dessa forma estamos multiplicando o número inteiro por ele mesmo

using System;

namespace Quadrado_Numero
{
    public class Quadrado_Numero
    {
        public static void Main(string[] args)
        {
            double numBase, resultado;

            System.Console.Write("Qual o numero: ");
            numBase = double.Parse(Console.ReadLine());

            resultado = Math.Pow(numBase, 2);

            System.Console.WriteLine("O quadrado o numero {0} é de: {1}", numBase, resultado);
        }
    }
}