//Calcular a Média Ponderada de duas provas realizadas por um aluno. Mostra de forma simples como declarar variáveis e manipular dados de entrada e saída
//A média ponderada é utilizada quando precisamos considerar pesos para as diferentes medidas.

//FORMULA: Mp = [(N1 x P1) + (N2 x P2) + (N3 x P3) + ... (Nx x Px)] ÷ (P1 + P2 + P3 + ... Px)
// Mp é a média ponderada (o resultado que você quer descobrir)
// N é cada valor do conjunto
// P é o peso correspondente de cada valor do conjunto.

using System;

namespace Media_Ponderada
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            double mediaPonderada, nota1, nota2, peso1, peso2;

            System.Console.Write("Qual a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            System.Console.Write("Qual o peso da primeira nota: ");
            peso1 = double.Parse(Console.ReadLine());

            System.Console.Write("Qual a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            System.Console.WriteLine("Qual o peso da segunda nota: ");
            peso2 = double.Parse(Console.ReadLine());

            mediaPonderada = (nota1 * peso1 + nota2 * peso2) / (peso1 + peso2);
            System.Console.WriteLine("A média ponderada de suas provas foi de: " + mediaPonderada);
        }
    }
}