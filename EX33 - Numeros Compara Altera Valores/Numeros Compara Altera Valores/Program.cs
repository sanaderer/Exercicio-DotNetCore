//Efetuar a leitura de 3 números e compara o valor do 1º número com uma tabela
//e conforme a situação altera o novo valor dos outros 2 números conforme as condições
//de existência.

using System;

namespace Numeros_Altera
{
    class MyClass
    {
        static void Main(string[] args)
        {
            double N, X, Y;
            Console.Write("Qual o primeiro numero: ");
            N = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o segundo numero: ");
            X = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual o terceiro numero: ");
            Y = double.Parse(Console.ReadLine());

            // Condições de existência
            /* N
            Valores de X e Y
            * Maior que 15
            x = x * 3 y = y + 2
            * Menor ou igual a 15 e maior que 10 x
            = x * 4 y = y + 1
            * Menor ou igual a 10 e maior que 5 x
            = x * 3 y = y + 3
            * Menor ou igual a 5
            x = 0 y = 0
            */
            // Verifica a condição de Existência
            if (N <= 5) // Estrura de Seleção Composta IF / ELSE
                        // Utilize chaves para mais de uma instrução (blocos de instruções)
            {
                X = 0;
                Console.WriteLine("\t\tO novo valor de X é: {0}", X);
                // O caractere de escape "\t" adiciona tabulações
                Console.WriteLine(); // Adiciona uma linha em branco
                Y = 0;
                Console.WriteLine("\t\tO novo valor de Y é: {0}", Y);
                // O caractere de escape "\t" adiciona tabulações
                Console.WriteLine(); // Adiciona uma linha em branco
            }
            else
            if (N <= 10)
            {
                X = X * 3;
                Console.WriteLine("\t\tO novo valor de X é: {0}", X); // O caractere de escape "\t" adiciona tabulações
                Console.WriteLine(); // Adiciona uma linha em branco
                Y = Y + 3;
                Console.WriteLine("\t\tO novo valor de Y é: {0}", Y); // O caractere de escape "\t" adiciona tabulações Console.WriteLine(); // Adiciona uma linha em branco } else { if (N <= 15) { X = X * 4; Console.WriteLine("\t\tO novo valor de X é: {0}", X); // O caractere de escape "\t" adiciona tabulações Console.WriteLine(); // Adiciona uma linha em branco Y = Y + 1; Console.WriteLine("\t\tO novo valor de Y é: {0}", Y); // O caractere de escape "\t" adiciona tabulações Console.WriteLine(); // Adiciona uma linha em branco } else { X = X * 3; Console.WriteLine("\t\tO novo valor de X é: {0}", X); // O caractere de escape "\t" adiciona tabulações Console.WriteLine(); // Adiciona uma linha em branco Y = Y + 2; Console.WriteLine("\t\tO novo valor de Y é: {0}", Y); // O caractere de escape "\t" adiciona tabulações Console.WriteLine(); // Adiciona uma linha em branco
            }
        }
    }
}