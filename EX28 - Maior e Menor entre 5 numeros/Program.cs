//Identificar o maior e o menor número dentre 5 números fornecidos pelo usuário

using System;

namespace Maior_Numero
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            int num1, num2, num3, num4, num5, maior, menor;
            System.Console.Write("Informe o primeiro numero: ");
            num1 = Int32.Parse(Console.ReadLine());
            System.Console.Write("Informe o segundo numero: ");
            num2 = Int32.Parse(Console.ReadLine());
            System.Console.Write("Informe o terceiro numero: ");
            num3 = Int32.Parse(Console.ReadLine());
            System.Console.Write("Informe o quarto numero: ");
            num4 = Int32.Parse(Console.ReadLine());
            System.Console.Write("Informe o quinto numero: ");
            num5 = Int32.Parse(Console.ReadLine());
            System.Console.WriteLine("-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-");

            if ((num1>=num2)&&(num1>=num3)&&(num1>=num4)&&(num1>=num5)){
                maior = num1;
                System.Console.Write("O primeiro numero é maior: " + maior);
            }
            else if ((num2>=num1)&&(num2>=num3)&&(num2>=num4)&&(num2>=num5)){
                maior = num2;
                System.Console.Write("O segundo numero é o maior: " + maior);
            }
            else if ((num3>=num1)&&(num3>=num2)&&(num3>=num4)&&(num3>=num5)){
                maior = num3;
                System.Console.Write("O terceiro numero é o maior: " + maior);
            }
            else if ((num4>=num1)&&(num4>=num2)&&(num4>=num3)&&(num4>=num5)){
                maior = num4;
                System.Console.Write("O quarto numero é  maior: " + maior);
            }
            else {
                maior = num5;
                System.Console.WriteLine("O quinto numero é o maior: " + maior);
            }
            System.Console.WriteLine("\n-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-");
            if ((num1<=num2)&&(num1<=num3)&&(num1<=num4)&&(num1<=num5)){
                menor = num1;
                System.Console.WriteLine("O primeiro é o menor numero: " + menor);
            }
            else if ((num2<=num1)&&(num2<=num3)&&(num2<=num4)&&(num2<=num5)){
                menor = num2;
                System.Console.WriteLine("O segundo é o menor numero: " + menor);
            }
            else if ((num3<=num1)&&(num3<=num2)&&(num3<=num4)&&(num3<=num5)){
                menor = num3;
                System.Console.WriteLine("O terceiro numero é o menor: " + menor);
            }
            else if ((num4<=num1)&&(num4<=num2)&&(num4<=num3)&&num4<=num5){
                menor = num4;
                System.Console.WriteLine("O quarto numero é o menor: " + menor);
            }
            else {
                menor = num5;
                System.Console.WriteLine("O quinto numero é o menor: " + menor);
            }
            System.Console.WriteLine("-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-x-");
        }
    }
}