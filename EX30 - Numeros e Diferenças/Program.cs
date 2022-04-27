//Ler dois valores numéricos e apresentar a diferença do maior pelo menor.

using System;

namespace Numeros_Diferencas
{
    class MyClass
    {
        static void Main(string[] args)
        {
            double num1, num2, diferenca;
            Console.WriteLine("Qual o primeiro numero: ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo numero: ");
            num2 = double.Parse(Console.ReadLine());

            if (num1 >= num2)
            {
                diferenca = num1 - num2;
                Console.WriteLine("A diferença de {0} - {1} é de {2}", num1, num2, diferenca);
            }
            else
            {
                diferenca = num2 - num1;
                Console.WriteLine("A difereça de {0} - {1} é de {2}", num2, num1, diferenca);
            }

        }
    }
}