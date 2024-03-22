using System;
class Program
{
    static void Main(string[] args)
    {
        for (int contador = 10; contador >= 1; contador--)
        {
            Console.WriteLine();

            for (int multiplicador = 10; multiplicador >= 1; multiplicador--)
            {
                Console.WriteLine($"{contador} X {multiplicador} = {contador * multiplicador}");
            }
        }
    }
}