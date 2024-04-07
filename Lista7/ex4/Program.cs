using System;
using System.Collections.Specialized;
using System.Diagnostics.Contracts;
class Program
{
    static void PreencherVetor(int[] vetor)
    {
        for (int contador = 0; contador < vetor.Length; contador++)
        {
            System.Console.WriteLine($"Digite a quantidade em toneladas do {contador + 1}º vagão: ");
            int numeroDigitado = Convert.ToInt32(Console.ReadLine());
            vetor[contador] = numeroDigitado;
        }
    }
    static void VerificarPesoMaximo(int[] vetor)
    {
        for (int i = 0; i < vetor.Length; i++)
        {
            if (vetor[i] > 50)
            {
                System.Console.WriteLine($"{i + 1}º vagao excede o peso maximo permitido");
            }
        }
    }
    static void Main(string[] args)
    {
        const int QUANTIDADE_DE_VAGOES = 12;
        int[] vetor = new int[QUANTIDADE_DE_VAGOES];
        PreencherVetor(vetor);
        VerificarPesoMaximo(vetor);
    }
}
