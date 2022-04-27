//Efetuar a conversão de temperatura da escala Celsius para a escala Fahrenheit.
//Demonstra de forma simples como declarar variáveis e utilizar uma console com o
//framework ou VS.NET.
//FORMULA: (0 °C × 9/5) + 32 = 32 °F

using System;

namespace Converter_Temperatura
{
    class Converter_Temperatura
    {
        public static void Main(string[] args)
        {
            double celsius, fahrenheit;

            System.Console.Write("Qual a temperatura em Celsius: ");
            celsius = double.Parse(Console.ReadLine());

            //fahrenheit = (celsius * 9 / 5) + 32;
            fahrenheit = (((9 * celsius)+ 160)/5);

            System.Console.Write("A temperatura {0} em Celsius é de {1} Fahrenheit", celsius, fahrenheit);
        }        
    }
}
