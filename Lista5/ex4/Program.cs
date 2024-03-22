using System;
class Program
{
    static void Main(string[] args)
    {
        int somatorio = 0;

        while (true)
        {
            System.Console.WriteLine("Digite um numero: ");
            int numeroDigitado = int.Parse(Console.ReadLine());

            if (numeroDigitado % 2 == 1)
            {
                somatorio = somatorio + numeroDigitado;
            }
            else if (numeroDigitado < 0)
            {
                System.Console.WriteLine("O resultado do somatório de ímpares eh: " + somatorio);
                break;
            }
        }
    }
}