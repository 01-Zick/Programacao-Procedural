using System;
using System.Diagnostics.Contracts;

class Program
{
    static void Main(string[] args)
    {
        int alturaDoTriangulo = 0;
        do
        {
            Console.WriteLine("Digite a altura do triangulo: ");
            alturaDoTriangulo = int.Parse(Console.ReadLine());

            if (alturaDoTriangulo >= 1 && alturaDoTriangulo <= 9)
            {
                break;
            }
            Console.WriteLine("Altura invalida. Insire um numero entre 1 e 9.");
        }
        while (alturaDoTriangulo < 1 || alturaDoTriangulo > 9);        
    
        for (int altura = 1; altura <= alturaDoTriangulo; altura++)
        {   
            for (int coluna = 1; coluna <= altura; coluna++)
            {
                Console.Write(coluna);    
            }
            Console.WriteLine();
        }    
    }        
}