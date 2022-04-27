//Calcular o custo com a criação de coelhos. 
//Mostra de forma simples como manipular dados via console e declarar variáveis, e expressões algébricas:
//FORMULA: (qtdCoelhos * 0.70) / 28

using System;

namespace EX04_CUSTO_COELHOS
{
    class Coelhos
    {
        static void Main(string[] args)
        {
            double custoCoelhos;
            int qtdCoelhos;
            Console.Write("Quantos coelhos está criando: ");
            qtdCoelhos = Int32.Parse(Console.ReadLine());

            custoCoelhos = (qtdCoelhos * 0.70) / 28;

            System.Console.WriteLine("\n");
            System.Console.WriteLine("O custo para a criação de " + qtdCoelhos + " colehos é de R$ " + custoCoelhos + " por dia!!");
            System.Console.WriteLine("\n");
        }
    }
}


