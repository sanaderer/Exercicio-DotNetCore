//Calcular a potência de um número informado. Simples utilização de entrada, saída e declaração de variáveis e o método Math.Pow
//A potência pode ser calculada por meio da notação, isto é, multiplicar o número base por ele mesmo quantas vezes o expoente mandar.

using System;

namespace Potencia_Numero
{
    public class Potencia_Numero
    {
        public static void Main(string[] args)
        {
            double expoente, numBase, potencia; 

            System.Console.Write("Qual o numero da base: ");
            numBase = double.Parse(Console.ReadLine());

            System.Console.Write("Qual o expoente: ");
            expoente = double.Parse(Console.ReadLine());

            potencia = Math.Pow(numBase, expoente);

            System.Console.WriteLine("Para a base {0} e expoente {1} tem resultado de: {2}", numBase, expoente, potencia);
        }
    }
}
