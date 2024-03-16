using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        for (int contador = 1; contador <=10; contador++)
        {
            Console.WriteLine("\nTabuada no numero - " + contador + "\n"); 

            for (int multiplicador = 1; multiplicador <= 10; multiplicador++)
            {
                Console.WriteLine(contador + " X " + multiplicador + " = " + contador * multiplicador);
            }
        }
    }
}