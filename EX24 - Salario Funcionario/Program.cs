//Calcular o salário de um funcionário. Mostra como declarar variáveis, e utilizar a console com entrada e saída de dados.

using System;

namespace Salario_Funcionario
{
    public class Myclass
    {
        static void Main(string[] args)
        {
            double numHoras, valorHora, salarioFamilia, salarioFinal; 
            int numeroFuncionario, numFilhos;

            System.Console.Write("Qual o numero de matricula: ");
            numeroFuncionario = Int32.Parse(Console.ReadLine());
            System.Console.Write("Quantas horas trabalhou: ");
            numHoras = double.Parse(Console.ReadLine());
            System.Console.Write("Qual o valor da hora de trabalho: ");
            valorHora = double.Parse(Console.ReadLine());
            System.Console.Write("Quantos filhos menores de 14 anos o funcionario tem: ");
            numFilhos = Int32.Parse(Console.ReadLine());
            System.Console.Write("Qual o salario familia por filho menor:  ");
            salarioFamilia = double.Parse(Console.ReadLine());
            
            salarioFinal = (numHoras * valorHora) + (salarioFamilia * numFilhos);

            System.Console.WriteLine("O funcionario de ID: {0} trabalhou {1} horas, o mesmo tem {2} filhos, seu pagamento é de R$ {3}", numeroFuncionario, numHoras, numFilhos, salarioFinal.ToString("0.00"));

        }
    }
}