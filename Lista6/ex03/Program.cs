using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.InteropServices;
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 3;
        int somatorio = 0;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];
        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                matriz[linha, coluna] = int.Parse(Console.ReadLine());
            }
        }
        for (int linha = 0; linha < TAMANHO_MATRIZ; linha++)
        {
            for (int coluna = 0; coluna < TAMANHO_MATRIZ; coluna++)
            {
                if (linha == coluna)
                {
                    somatorio += matriz[linha, coluna];
                }
            }
        }
        Console.Write($"A soma dos valores da diagonal eh: {somatorio}");
    }
}