using System;
class Program
{
    static void Main(string[] args)
    {
        for (int progressivo = 0; progressivo <= 100; progressivo++)
        {
            if(progressivo  % 2 == 0)
            {
                int regressivo = 200;

                Console.WriteLine($"{progressivo} - {regressivo - (progressivo * 2)}");
            } 
        }
    }
}