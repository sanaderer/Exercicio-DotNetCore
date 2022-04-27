//Calcular o volume de uma esfera. 
//Mostra como declarar variáveis e utilizar console e o método pow.
//FORMULA: V = 4/3 πr³

using System;

namespace Volume_Esfera
{
    class Volume_Esfera
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;
            double raio;
            double volume;

            System.Console.Write("Qual o raio: ");
            raio = double.Parse(Console.ReadLine());

            volume = (( 4 * pi * Math.Pow(raio,3)/3));

            System.Console.WriteLine("O volume dessa esfera é de: " + volume.ToString("F"));
        }
    }
}