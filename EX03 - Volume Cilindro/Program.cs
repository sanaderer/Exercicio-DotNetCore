//Calcular o volume de um Cilindro. Mostra de forma simples a declaração de variáveis e entrada e saída de dados
//FORMULA: π r² h

using System;

public class Ex03_Volume_Cilindro
{
	public static void Main()
	{
	    double pi = 3.14;
	    double altura;
	    double raio;
	    double volume;
	    
	    Console.Write("Qual a altura do cilindro: ");
	    altura = double.Parse(Console.ReadLine());
	    
	    Console.Write("Qual o raio: ");
	    raio = double.Parse(Console.ReadLine());
	    
	    volume = pi * altura * (raio * raio);
	    
	    Console.WriteLine("O volume do cilindro é: " + volume.ToString("F"));
	}
}
