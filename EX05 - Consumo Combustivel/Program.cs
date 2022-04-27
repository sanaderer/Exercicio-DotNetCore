//Calcular o consumo de combustível por Km. Mostra de forma simples conceitos de entrada e saída de dados e declaração de variáveis:



using System;

namespace EX05___Consumo_Combustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            double consumo;
            double kmPercorrido;
            double mediaConsumo;

            System.Console.Write("Qual o km percorrido: ");
            kmPercorrido = double.Parse(Console.ReadLine());

            System.Console.Write("Quanto voce gastou de combustivel: ");
            consumo = double.Parse(Console.ReadLine());

            mediaConsumo = consumo / kmPercorrido;

            Console.WriteLine("Você percorreu {0} Kms e gastou {1} litros, fez uma média de {2} por Km percorrido!", kmPercorrido, consumo, mediaConsumo.ToString("F"));
        }
    }
}
