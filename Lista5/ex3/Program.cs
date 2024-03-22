using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite a altura do retangulo: ");
        int alturaDoRetangulo = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite a base do retangulo: ");
        int baseDigitada = int.Parse(Console.ReadLine());

        for (int linha = 0; linha < alturaDoRetangulo; linha++)
        {
            for (int coluna = 0; coluna < baseDigitada; coluna++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}