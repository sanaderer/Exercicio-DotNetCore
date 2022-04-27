//Calcular o quadrado da diferença entre dois números quaisquer. 
//Demonstra de forma simples o uso de consoles, entrada e saída de dados e o método pow:

using System;

namespace Quadrado_Diferenca
{
    class Quadrado_Diferenca
    {
        static void Main(string[] args)
        {

        double num1;
        double num2;
        double dif;

        System.Console.Write("Informe o primeiro numero: ");
        num1 = double.Parse(Console.ReadLine());

        System.Console.Write("Informe o segundo numero: ");
        num2 = double.Parse(Console.ReadLine());

        dif = Math.Pow(num1, 2) - Math.Pow(num2, 2);

        System.Console.WriteLine("O quadrado da diferença entre os números {0} e {1} é de: {2}", num1, num2, dif);
        }
    }
}
