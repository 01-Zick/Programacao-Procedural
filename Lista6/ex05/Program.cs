using System;
using System.Data;
using System.Diagnostics.Contracts;
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 10;
        int[] vetor = new int[TAMANHO_VETOR];
        int numeroDigitado = 0;

        for (int contador = 0; contador < TAMANHO_VETOR; contador++)
        {
            do
            {
                numeroDigitado = Convert.ToInt32(Console.ReadLine());
                vetor[contador] = numeroDigitado;
            } while (numeroDigitado < 10 || numeroDigitado > 50);
        }

        for (int contador = 0; contador < TAMANHO_VETOR; contador++)
        {
            System.Console.WriteLine(vetor[contador]);
        }
    }
}
