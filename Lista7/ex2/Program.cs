using System;
class Program
{
    static int ReceberNumeros(int num1, int num2, int num3)
    {
        int resultado = 0;
        
        if (num1 > resultado)
        {
            resultado = num1;
        }

        if (num2 > resultado)
        {
            resultado = num2;
        }

        if (num3 > resultado)
        {
            resultado = num3;
        }
        return resultado;
    }
    static void Main(string[] args)
    {
        int maiorValor = ReceberNumeros(7, 12, 47);
        System.Console.WriteLine(maiorValor);
    }
}
