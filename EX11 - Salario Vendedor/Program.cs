//Calcular o salário total de um vendedor. 
//Define pontos importantes de como se utilizar console de entrada e saída de dados

using System;

namespace Salario_Vendedor
{
    public class Salario_Vendedor
    {
        static void Main(string[] args)
        {
            int idFuncionario;
            double salarioFixo, totalVendas, percentualGanho, salarioTotal, comissão;

            System.Console.Write("Informe o ID do funcionário: ");
            idFuncionario = int.Parse(Console.ReadLine());

            System.Console.Write("Qual o valor do salário fixo R$ ");
            salarioFixo = double.Parse(Console.ReadLine());

            System.Console.Write("Quanto foi o total de vendas no mês R$ ");
            totalVendas = double.Parse(Console.ReadLine());

            System.Console.Write("Qual o percentual de comissão nas vendas ");
            percentualGanho = double.Parse(Console.ReadLine());

            comissão = totalVendas * percentualGanho / 100;

            salarioTotal = comissão + salarioFixo;

            System.Console.WriteLine("Funcionário ID: {0} vendeu R$ {1} deu uma comissão de R$ {2} seu salário total é de R$ {3}", idFuncionario, totalVendas.ToString("C"), comissão.ToString("C"), salarioTotal.ToString("C"));
        }
    }
}
