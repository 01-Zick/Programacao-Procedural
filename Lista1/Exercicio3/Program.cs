
using System;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine();
        Console.Write("Digite os centavos: ");
 
        int centavos = int.Parse(Console.ReadLine());
  
        Console.WriteLine();

        int real =  centavos / 100;
        int resto =  centavos % 100;
  
        Console.WriteLine("O total em dinheiro é: " + real + " Real(is) e " + resto + " centavo(s).");
  
        Console.WriteLine();
    }

}
