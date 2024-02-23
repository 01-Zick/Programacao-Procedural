
using System;

class Program
{  

    public static void Main(string[] args)
    {

        Console.WriteLine();
        Console.Write("Digite a base do triangulo: ");
        double basedotriangulo = double.Parse(Console.ReadLine());

    
        Console.WriteLine();
        Console.Write("Digite a altura do triangulo: ");
        double alturadotriangulo = double.Parse(Console.ReadLine());

        Console.WriteLine();
        double area  = (basedotriangulo * alturadotriangulo) / 2;
        Console.Write("Resultado: ");
        Console.WriteLine(area);

        Console.WriteLine();
        bool areadotriangulo =  area >20;

        Console.WriteLine("A área do triangulo é maior que 20? - " + areadotriangulo);
        Console.WriteLine();
    }
}
