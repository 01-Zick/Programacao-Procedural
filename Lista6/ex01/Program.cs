using System;
using System.Diagnostics.Contracts;
class Program
{
    static void Main(string[] args)
    {
        const int CONTADOR_NOMES = 10;
        string[] nomes = new string[CONTADOR_NOMES];
        for (int contador = 0; contador < CONTADOR_NOMES; contador++)
        {
            System.Console.Write($"Digite o {contador + 1}º nome da lista: ");
            nomes[contador] = Console.ReadLine();
        }
        System.Console.WriteLine("Digite o nome a ser procurado na lista: ");
        string nomeAhRastrear = Console.ReadLine();
        for (int contador = 0; contador < CONTADOR_NOMES; contador++)
        {
            nomes[contador] = nomeAhRastrear;
        }
        if (nomeAhRastrear == "Rosa")
        {
            System.Console.WriteLine($"ACHEI! {nomeAhRastrear} esta na lista!");
        }
        else
        {
            System.Console.WriteLine($"NAO ACHEI. {nomeAhRastrear} nao esta na lista.");
        }
    }
}
