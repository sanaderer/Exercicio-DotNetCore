//Calcular o volume de uma lata de óleo. Demonstra de forma simples como declarar variáveis, expressões e apresentar os dados via console
//FORMULA: VOLUME = 3.14159 * R2 * ALTURA

using System;

namespace Volume_Lata
{
    public class Volume_Lata
    {
        public static void Main(string[] args)
        {
            double volume, raio, altura, pi;

            pi = 3.14159;

            System.Console.Write("Qual o raio da lata: ");
            raio = double.Parse(Console.ReadLine());

            System.Console.Write("Qual a altura da lata: ");
            altura = double.Parse(Console.ReadLine());

            volume = (raio * raio) * pi * altura;

            System.Console.Write("\tO volume da lata de raio {0} e altura {1} é de: {2}", raio, altura, volume.ToString("F"));
        }
    }
}