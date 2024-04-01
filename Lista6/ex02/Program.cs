using System;
class Program
{
    static void Main(string[] args)
    {
        const int ARMAZENAMENTO = 10;
        string[] bancoDeDados = new string[ARMAZENAMENTO];
        for (int contador = 0; contador < ARMAZENAMENTO; contador++)
        {
            System.Console.Write(" ");
            bancoDeDados[contador] = Console.ReadLine();
        }
        System.Console.WriteLine();
        for (int contador = ARMAZENAMENTO - 1; contador >= 0; contador--)
        {
            if (contador % 2 == 0)
            {
                System.Console.WriteLine(bancoDeDados[contador]);
            }
        }
    }
}