using System;

namespace Aprovado_Reprovado
{
    class MyClass
    {
        static void Main(string[] args)
        {
            double prov1, prov2, prov3, prov4, media;
            Console.Write("Qual a nota da primeira prova: ");
            prov1 = double.Parse(Console.ReadLine());
            Console.Write("Qual a nota da segunda prova: ");
            prov2 = double.Parse(Console.ReadLine());
            Console.Write("Qual a nota da terceira prova: ");
            prov3 = double.Parse(Console.ReadLine());
            Console.Write("Qual a quarta nota: ");
            prov4 = double.Parse(Console.ReadLine());

            media = (prov1 + prov2 + prov3 + prov4) / 4;

            if ((media >= 8)&&(media <= 10))
            {
                Console.WriteLine("Parabéns foi muito bem com média de {0} foi APROVADO!!!", media);
            }
            else if ((media >= 6)&&(media < 8))
            {
                Console.WriteLine("Sua nota foi média de {0}, mas foi APROVADO!!", media);
            }
            else
            {
                Console.WriteLine("Infelizmente voce ficou média de {0} e foi REPROVADO!!", media);
            }
        }
    }
}