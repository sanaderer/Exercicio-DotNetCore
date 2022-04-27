//Calcular a média harmônica das notas de um aluno. Define como utilizar uma console manipulando dados de entrada e saída e declarando variáveis
//Utilizamos a média harmônica quando queremos encontrar a média entre grandezas que são inversamente proporcionais. A média harmônica é um dado estatístico.

using System;

namespace Nota_Harmonica_Aluno
{
    public  class Nota_Harmonica_Aluno
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, mediaHarmonica;

            System.Console.Write("Qual a nota da primeira prova: ");
            nota1 = double.Parse(Console.ReadLine());

            System.Console.Write("Qual a nota da segunda prova: ");
            nota2 = double.Parse(Console.ReadLine());

            System.Console.Write("Qual a nota da terceira prova: ");
            nota3 = double.Parse(Console.ReadLine());

            System.Console.Write("Qual a nota da quarta prova: ");
            nota4 = double.Parse(Console.ReadLine());

            mediaHarmonica = (4/((1/nota1) + (1/nota2) + (1/nota3) + (1/nota4)));

            System.Console.WriteLine("Após as 4 provas voce teve uma média de: {0}", mediaHarmonica.ToString("F"));
        }
    }
}
