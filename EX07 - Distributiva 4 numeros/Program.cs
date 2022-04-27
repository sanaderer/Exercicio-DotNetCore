//Utilizar a propriedade distributiva entre 4 números nos quais devem ser somados e multiplicados entre si. 
//Simples utilização de entrada, saída e declaração de variáveis:
//Para entender a propriedade distributiva, porém, é mais fácil observar os factores numa expressão algébrica:
//A x (B + C) = A x B + A x C

using System;

namespace Distributiva
{
    class Atributos
    
    {
        static void Main(string[] args)
        {
            double A, B, C, D;//Numeros
            double S_AB, S_AC, S_AD, S_BC, S_BD, S_CD;//Somas
            double M_AB, M_AC, M_AD, M_BC, M_BD, M_CD;//Multiplicações

            System.Console.Write("Qual o primeiro numero: ");
            A = double.Parse(Console.ReadLine());

            System.Console.Write("Qual o segundo numero: ");
            B = double.Parse(Console.ReadLine());

            System.Console.Write("Qual o terceiro numero: ");
            C = double.Parse(Console.ReadLine());

            System.Console.Write("Qual o quarto numero: ");
            D = double.Parse(Console.ReadLine());
            System.Console.WriteLine(" ");
            //Efetuar a distributiva
            S_AB = A + B; S_AC = A + C; S_AD = A + D; S_BC = B + C; S_BD = B + D; S_CD = C + D;

            M_AB = A * B; M_AC = A * C; M_AD = A * D; M_BC = B * C; M_BD = B * D; M_CD = C * D;
            // Exibe o resultado da Propriedade distributiva da Soma e Multiplicação Console.WriteLine(); Console.WriteLine("\t\tO valor da soma {0} + {1} = {2}",A, B, S_AB); Console.WriteLine(); Console.WriteLine("\t\tO valor da soma {0} + {1} = {2}",A, C, S_AC); Console.WriteLine(); Console.WriteLine("\t\tO valor da soma {0} + {1} = {2}",A, D, S_AD); Console.WriteLine(); Console.WriteLine("\t\tO valor da soma {0} + {1} = {2}",B, C, S_BC); Console.WriteLine();
            Console.WriteLine("\t\tO valor da soma {0} + {1} = {2}",B, D, S_BD); 
            Console.WriteLine(); Console.WriteLine("\t\tO valor da soma {0} + {1} = {2}",C, D, S_CD); 
            Console.WriteLine(); Console.WriteLine("\t\tO valor da multiplicação {0} * {1} = {2}",A, B, M_AB); 
            Console.WriteLine(); Console.WriteLine("\t\tO valor da multiplicação {0} * {1} = {2}",A, C, M_AC); 
            Console.WriteLine(); Console.WriteLine("\t\tO valor da multiplicação {0} * {1} = {2}",A, D, M_AD); 
            Console.WriteLine(); Console.WriteLine("\t\tO valor da multiplicação {0} * {1} = {2}",B, C, M_BC); 
            Console.WriteLine(); Console.WriteLine("\t\tO valor da multiplicação {0} * {1} = {2}",B, D, M_BD); 
            Console.WriteLine(); Console.WriteLine("\t\tO valor da multiplicação {0} * {1} = {2}",C, D, M_CD); 
            Console.WriteLine();
        }
    }
}
