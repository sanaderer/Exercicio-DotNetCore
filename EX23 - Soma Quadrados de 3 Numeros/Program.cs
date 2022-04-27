//Calcular a soma dos quadrados de 3 números. Usa conceitos simples de entrada e saída de dados e declaração de variáveis.

using System;

namespace Soma_Quadrados
{
    public class MyClass
    {
        static public void Main(string[] args)
        {
            double num1, num2, num3, total;

            System.Console.Write("Informe o primeiro numero: ");
            num1 = double.Parse(Console.ReadLine());
            System.Console.Write("Informe o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());
            System.Console.Write("Informe o terceiro numero: ");
            num3 = double.Parse(Console.ReadLine());

            //total = (num1 * num1) + (num2 * num2) + (num3 * num3);
            total = (Math.Pow(num1, 2) + Math.Pow(num2, 2) + Math.Pow(num3, 2));

            System.Console.WriteLine("A soma dos quadrados dos nummeros é: " + total);
        }
    }
}