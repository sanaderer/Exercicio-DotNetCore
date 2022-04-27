//Ler dois reais e efetuar as quatro operações entre eles. Demonstra de forma simples como efetuar cálculos, declarar variáveis e utilizar a console para manipular dados

using System;

namespace Numeros_Operacoes
{
    public class Numeros_Operacoes
    {
        public static void Main(string[] args)
        {
            double num1, num2, soma, subtracao, multiplicacao, divisao;

            System.Console.Write("Digite o primeiro numero: ");
            num1 = double.Parse(Console.ReadLine());
            System.Console.Write("Digite o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            soma = (num1 + num2);
            subtracao = (num1 - num2);
            multiplicacao = (num1 * num2);
            divisao = (num1 / num2);

            System.Console.WriteLine("Os resultados são: Soma = {0} ; Subtração = {1} ; Multiplicação = {2} ; Divisão = {3} .", soma, subtracao, multiplicacao, divisao);
        }
    }
}