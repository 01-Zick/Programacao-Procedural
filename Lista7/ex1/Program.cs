using System;
class Program
{
    static bool EhPar(int numero)
    {
        if (numero % 2 == 0)
        {
            return true;
        }
        return false;
    }
    static void Main(string[] args)
    {
        int numeroDigitado = Convert.ToInt32(Console.ReadLine());
        bool resultado = EhPar(numeroDigitado);
        System.Console.WriteLine($"O numero {numeroDigitado} eh: {resultado}");
    }
}