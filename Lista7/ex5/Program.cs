using System;
class Program
{
    static void PreecherMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                matriz[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
    }
    static bool TemBalista(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(0); j++)
            {
                if (matriz[i, j] == 0)
                {
                    return true;
                }
            }
        }
        return false;
    }
    static void Main(string[] args)
    {
        const int TAMANHO_MATRIZ = 4;
        int[,] matriz = new int[TAMANHO_MATRIZ, TAMANHO_MATRIZ];

        System.Console.WriteLine("Digite um numero de 0(zero) ah 9(nove): ");
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());

        PreecherMatriz(matriz);
        TemBalista(matriz);
        bool cuidadoBalista = TemBalista(matriz);

        if (cuidadoBalista)
        {
            System.Console.WriteLine("Fique atento! existem balistas no tabuleiro");
        }
    }
}


// 7
// 9
// 6
// 0
// 4
// 2
// 6
// 3
// 1
// 0
// 5
// 2
// 2
// 5
// 3
// 2
















