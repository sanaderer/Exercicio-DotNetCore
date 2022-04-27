//Aceitar quatro números do usuário e verificar quais são divisíveis por 2 ou 3.
using System;

namespace Numeros_Divisores
{
    class MyClass
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.Write("Qual o primeiro numero: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Qual o segundo numero: ");
            num2 = Int32.Parse(Console.ReadLine());
            Console.Write("Qual o terceiro numero: ");
            num3 = Int32.Parse(Console.ReadLine());
            Console.Write("Qual o quarot numero: ");
            num4 = Int32.Parse(Console.ReadLine());

            if (num1 % 2 == 0)
            {
                Console.WriteLine("O numero {0} é divisivel por 2!", num1);
            }
            if (num1 % 3 == 0)
            {
                Console.WriteLine("O numero {0} é divisivel por 3!", num1);
            }
            if (num2 % 2 == 0)
            {
                Console.WriteLine("O numero {0} é divisivel por 2!", num2);
            }
            if (num2 % 3 == 0)
            {
                Console.WriteLine("O numero {0} é divisivel por 2!", num2);
            }
            if (num3 % 2 == 0)
            {
                Console.WriteLine("O numero {0} é divisivel por 2!", num3);
            }
            if (num3 % 3 == 0)
            {
                Console.WriteLine("O numero {0} é divisivel por 2!", num3);
            }
            if (num4 % 2 == 0)
            {
                Console.WriteLine("O numero {0} é divisivel por 2!", num4);
            }
            if (num4 % 3 == 0)
            {
                Console.WriteLine("O numero {0} é divisivel por 2!", num4);
            }
        }
    }
}
