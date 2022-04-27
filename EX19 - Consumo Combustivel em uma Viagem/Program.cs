//Calcular o consumo de combustível, ou seja a quantidade de litros consumidos em uma viagem de veículo. Utiliza de forma simples e clara conceitos de declaração de variáveis e console;

using System;

namespace Consumo_Viagem
{
    public class Consumo_Viagem
    {
        public static void Main(string[] args)
        {
            double tempo, velocidade, kmPorLitro, distancia, consumoCombustivel;

            System.Console.Write("Quanto tempo de viagem em horas: ");
            tempo = double.Parse(Console.ReadLine());

            System.Console.Write("Qual foi a velocidade média em Km/h: ");
            velocidade = double.Parse(Console.ReadLine());

            System.Console.Write("Quantos Kms por litro faz o veiculo: ");
            kmPorLitro = double.Parse(Console.ReadLine());
            distancia = (velocidade * tempo);
            consumoCombustivel = (distancia / kmPorLitro);
            
            System.Console.WriteLine("A distancia percorrida foi de: {0} Kms", distancia);

            System.Console.WriteLine("A quantidade de combustivel gasto na viagem foi de: {0} litros", consumoCombustivel.ToString("F"));
        }
    }
}