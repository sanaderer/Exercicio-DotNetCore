//Este programa utiliza conceitos de estruturas de seleção, operadores relacionais e utilização de blocos de instruções. Verificar em que faixa está localizada um número informado pelo usuário.
//Verificar se um numero esta entre 20 e 90


using System;

namespace Verifica_Numero
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            double num;
            System.Console.Write("Informe um numero: ");
            num = double.Parse(Console.ReadLine());
            System.Console.WriteLine("x-x-x-x-x-x-x-x-x-x-x-x-x--x-x-x-x");

            if ((num >= 20) && (num <= 90))
            {
                System.Console.WriteLine("O numero esta na faixa de 20 a 90.");
            }
            else
            {
                System.Console.WriteLine("O numero esta fora da faixa!!");
            }
            System.Console.WriteLine("x-x-x-x-x-x-x-x-x-x-x-x-x--x-x-x-x");
        }
    }
}