//Demonstra como utilizar estruturas de seleção if / else aninhadas, operadores relacionais, blocos de comando. Este programa tem como finalidade calcular o reajuste salarial de um funcionário.
//Condições para Reajuste do Salário do Funcionário * Salário Atual Índice de Aumento R$ 0,00 - R$ 300,00 10% R$ 300,01 - R$ 600,00 11% R$ 600,01 - R$ 900,00 12% R$ 900,01 - R$1500,00 6% R$1500,01 - R$2000,00 3% ACIMA DE R$ 2000,00 sem aumento

using System;

namespace Reajuste_Salario
{
    class MyClass
    {
        static void Main(string[] args)
        {
            double id, salarioAtual, salarioNovo, indiceReajuste;

            Console.Write("Qual o ID: ");
            id = double.Parse(Console.ReadLine());
            Console.Write("Qual o salario atual R$ ");
            salarioAtual = double.Parse(Console.ReadLine());

            if (salarioAtual <= 300)
            {
                indiceReajuste = salarioAtual * 0.10;
                salarioNovo = salarioAtual + indiceReajuste;
                Console.WriteLine($"Funcionario ID: {id} .Seu salario era de R$ {salarioAtual} agora é de R$ {salarioNovo}");
            }
            if ((salarioAtual > 300)&&(salarioAtual <= 600))
            {
                indiceReajuste = salarioAtual * 0.11;
                salarioNovo = salarioAtual + indiceReajuste;
                Console.WriteLine($"Funcionario ID: {id} .Seu salario era de R$ {salarioAtual} agora é de R$ {salarioNovo}");
            }
            if ((salarioAtual > 600)&&(salarioAtual <= 900))
            {
                indiceReajuste = salarioAtual * 0.12;
                salarioNovo = salarioAtual + indiceReajuste;
                Console.WriteLine($"Funcionario ID: {id} .Seu salario era de R$ {salarioAtual} agora é de R$ {salarioNovo}");
            }
            if ((salarioAtual > 900)&&(salarioAtual <= 1500))
            {
                indiceReajuste = salarioAtual * 0.06;
                salarioNovo = salarioAtual + indiceReajuste;
                Console.WriteLine($"Funcionario ID: {id} .Seu salario era de R$ {salarioAtual} agora é de R$ {salarioNovo}");
            }
            if ((salarioAtual > 1500)&&(salarioAtual <= 2000))
            {
                indiceReajuste = salarioAtual * 0.03;
                salarioNovo = salarioAtual + indiceReajuste;
                Console.WriteLine($"Funcionario ID: {id} .Seu salario era de R$ {salarioAtual} agora é de R$ {salarioNovo}");
            }
            else
            {
                Console.WriteLine("Não haverá reajuste");
            }
        }
    }
}
