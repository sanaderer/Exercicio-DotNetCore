//Calcular o volume de uma caixa retangular mostra de forma simples como declarar
//variáveis e manipular dados de entrada e saída via console




using System;

namespace EX01___Volume_Caixa
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, comprimento, largura, altura;

            System.Console.Write("Qual altura da caixa: ");
            altura = double.Parse(Console.ReadLine());

            System.Console.Write("Qual o comprimento: ");
            comprimento = double.Parse(Console.ReadLine());

            System.Console.Write("Qual largura: ");
            largura = double.Parse(Console.ReadLine());

            volume = comprimento * altura * largura;

            System.Console.WriteLine("Uma caixa de largura " + largura + " altura " + altura + " e comprimento " + comprimento + " tem um volume de " + volume);
        }
    }
}
