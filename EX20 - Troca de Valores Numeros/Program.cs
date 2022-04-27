//Efetuar a troca dos valores de dois números. Utiliza conceitos de declaração de variáveis, entrada e saída de dados

using System;

namespace Troca_Numeros
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            double num1, num2, troca;

            System.Console.Write("Qual o primeiro numero: ");
            num1 = double.Parse(Console.ReadLine());

            System.Console.Write("Qual o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            troca = num1;
            num1 = num2;
            num2 = troca;

            Console.WriteLine("O número fornecido X = {0}, agora é: {1}", num2, 
            num1); 
            Console.WriteLine("O número fornecido Y = {0}, agora é: {1}", num1, num2);
        }
    }
}