home();

static double formula1(int pista, int voltas, int reabastecimentos, double kmPorLitro)
{
    return (((pista * voltas) / 1000 / (reabastecimentos + 1) / kmPorLitro));
}

static void home()
{
    Console.Clear();
    Console.WriteLine("Qual o tamanho da pista em m?");
    var pista = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Qual o número de voltas da corrida?");
    var voltas = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Quantos reabastecimentos devem ocorrer durante a corrida?");
    var reabastecimentos = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Quantos KMs é possível percorrer por litro?");
    var kmPorLitro = Console.ReadLine();
    var a = int.Parse(pista);
    var b = int.Parse(voltas);
    var c = int.Parse(reabastecimentos);
    var d = double.Parse(kmPorLitro);
    Console.Clear();
    Console.WriteLine("Resultado: " + formula1(a, b, c, d));
    Console.ReadKey();
}