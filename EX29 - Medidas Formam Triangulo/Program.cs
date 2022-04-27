//Verificar se as medidas informadas formam um triângulo e se for, qual o seu tipo.
//(A < B + C) ou (B < A + C) ou (C < A + B) * (A = B) ou (A = C) ou (B = C) ---> Triângulo Isósceles 
//(A ? B) e (B ? C) ---> Triângulo Escaleno 
//(A = B) e (B = C) ---> Triângulo Equilátero

using System;

namespace Medidas_Triangulo
{
    public class MyClass
    {
        static void Main(String[] args)
        {
            double A, B, C;
            System.Console.Write("QUal a medida do primeiro lado: ");
            A = double.Parse(Console.ReadLine());
            System.Console.Write("Qual a medida do segundo lado: ");
            B = double.Parse(Console.ReadLine());
            System.Console.Write("Qual a medida do terceiro lado: ");
            C = double.Parse(Console.ReadLine());

            if ((A < B + C)&&(B < A + C)&&(C < A + B))
            {
                if ((A == B)&&(B==C)){
                    System.Console.WriteLine("Triangulo Equilatero!!");
                }
                else if ((A == B)&&(A == C)&&(B == C))
                {
                    System.Console.WriteLine("Triangulo Isósceles!");
                }
                else{
                    System.Console.WriteLine("Triangulo Escaleno!");
                }
            }
            else{
                System.Console.WriteLine("As medidas fornecidas não formam um triangulo!!");
            }
        }
    }
}