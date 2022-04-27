//Converter a temperatura em graus Fahrenheit para graus Celsius. Utiliza console de entrada e saída de dados.

using System;

namespace EX02___Converter_Temperatura
{
    class Program
    {
        static void Main(string[] args)
        {
            double Celsius;
            double Fahrenheit;

            System.Console.WriteLine("\n");
            System.Console.Write("\tQual a temperatura em Fahrenheit a converter: ");
            Fahrenheit = double.Parse(Console.ReadLine());
            System.Console.WriteLine("\n");

            Celsius = ((Fahrenheit - 32) * 5 / 9);

            System.Console.WriteLine("\tA temperatura em Celsius é: " + Celsius.ToString("F"));
            System.Console.WriteLine("\n");
        }
    }
}
