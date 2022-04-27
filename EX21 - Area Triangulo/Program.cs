//Apresentar conceitos de entrada e saída de dados. Realizar o cálculo da área de um triângulo.
//FORMULA: (B x H) / 2

using System;

namespace Area_Triangulo
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            double baseT, altura, areaTriangulo;

            System.Console.Write("Qual a base do triangulo: ");
            baseT = double.Parse(Console.ReadLine());

            System.Console.Write("Qual a altura do triangulo: ");
            altura = double.Parse(Console.ReadLine());

            areaTriangulo = (baseT * altura) / 2;

            System.Console.WriteLine("Um triangulo com base {0} e altura de {1} tem uma area de {2}", baseT, altura, areaTriangulo);
        }
    }
}