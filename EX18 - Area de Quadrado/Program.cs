//Calcular a área de um quadrado. Demonstra a simples utilização de entrada e saída de dados
//FORMULA: lado X lado

using System;

namespace Area_Quadrado
{
    public class Area_Quadrado
    {
        public static void Main(string[] args)
        {
            double lado, area;

            System.Console.Write("Qual o comprimento do primeiro lado: ");
            lado = double.Parse(Console.ReadLine());

            area = (lado * lado);

            System.Console.WriteLine("A area de um quadrado de lados de {0} é de: {1}", lado, area.ToString("F"));
        }
    }
}