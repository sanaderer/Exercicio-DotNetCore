//Calcular a velocidade média de um veículo qualquer. Mostra de forma simples a utilização de entrada e saída de dados via console e como declarar variáveis.

using System;

namespace Velocidade
{
    public class MyClass
    {
        public static void Main(string[] args)
        {
            double distancia, velocidade, tempo;
            System.Console.Write("Qual a distancia percorrida: ");
            distancia = double.Parse(Console.ReadLine());
            System.Console.Write("Quanto tempo demorou: ");
            tempo = double.Parse(Console.ReadLine());

            velocidade = (distancia / tempo);
            System.Console.Write($"A velocidade média do veículo é de {velocidade.ToString("N2")} km/h.");
        }
    }
}