//Calcular o salário mensal de um vendedor de uma revendedora de carros. Utiliza declaração de variáveis e manipulação de dados entrada/saída.

using System;

namespace Salario_Vendedor
{
    public class MyClass
    {
        static void Main(string[] args)
        {
            int id, carrosVendidos;
            double salarioFixo, totalVendaCarros, comissaoPercentual, valorComissao, salarioMensal;

            System.Console.Write("Qual o ID: ");
            id = Int32.Parse(Console.ReadLine());
            System.Console.Write("Quantos carros forma vendidos: ");
            carrosVendidos = Int32.Parse(Console.ReadLine());
            System.Console.Write("Valor dos carros vendidos total: R$ ");
            totalVendaCarros = double.Parse(Console.ReadLine());
            salarioFixo = 1500;
            comissaoPercentual = 0.05;
            valorComissao = (totalVendaCarros * comissaoPercentual);
            salarioMensal = salarioFixo + valorComissao;

            System.Console.Write($"Neste mês voce {id} vendeu {carrosVendidos} carros faturou um total de R$ {totalVendaCarros.ToString("N2")}. Portanto seu salario fixo de {salarioFixo.ToString("N2")} mais comissão de 5% é de R$ {salarioMensal.ToString("N2")}");
        }
    }
}