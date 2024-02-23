
using System;

class Program
{
    public static void Main(string[] args)
    {

        Console.Write("Digite a nota1: ");
        double nota1 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota2: ");
        double nota2 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota3: ");
        double nota3 = double.Parse(Console.ReadLine());

        Console.Write("Digite a nota4: ");
        double nota4 = double.Parse(Console.ReadLine();
        
        double media = (nota1 + nota2 + nota3 + nota4) / 4.0;

        Console.Write("A média do aluno é: ");

        Console.WriteLine(media);


    }
}