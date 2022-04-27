//Calcular o produto e a adição de duas frações. 
//Mostra de forma simples como utilizar variáveis e manipular dados via console

using System;

namespace Produto_Adicao_Fracoes
{
    public class Produto_Adicao_Fracoes 
    {
        public static void Main(string[] args)
        {
            double num1, num2, den1, den2, frac1, frac2, soma, produto;

            System.Console.Write("Informe o 1° Numerador da fração: ");
            num1 = double.Parse(Console.ReadLine());

            System.Console.Write("Informe o 1° Denominador da fração: ");
            den1 = double.Parse(Console.ReadLine());

            System.Console.Write("Informe o 2° Numerador da fração: ");
            num2 = double.Parse(Console.ReadLine());

            System.Console.Write("Informe o 2° Denominador da fração: ");
            den2 = double.Parse(Console.ReadLine());

            frac1 = (num1 / den1);
            frac2 = (num2 / den2);

            soma = frac1 + frac2;
            produto = frac1 * frac2;

            System.Console.WriteLine("A soma das frações {0} e {1} é de: {2}", frac1, frac2, soma);

            System.Console.WriteLine("O produto das frações {0} e {1} é de: {2}", frac1, frac2, produto);

        }
    }
}