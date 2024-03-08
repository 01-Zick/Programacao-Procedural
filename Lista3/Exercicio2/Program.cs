using System;
class Program
{
    static void Main(string[] args)
    {
        int contador = 1;
        double valorTotalDeItens = 0.0;

        Console.Write("Digite a quantidade de itens da sacola: ");
        int numeroDeItensDaSacola = int.Parse(Console.ReadLine());

        while (contador <= numeroDeItensDaSacola)
        {
            Console.Write("Digite o valor do item: R$ ");
            double valorDoItem = double.Parse(Console.ReadLine());
            valorTotalDeItens = valorTotalDeItens + valorDoItem;
            contador++;
        }
        if (valorTotalDeItens >= 150)
        {
            Console.WriteLine("Parabens! Voce ganhou frete gratis em sua compra no valor de: R$ " + Math.Round(valorTotalDeItens, 2));
        }
        else
        {
            Console.WriteLine("Valor total da sacola eh de: R$ " + Math.Round(valorTotalDeItens, 2));
            Console.WriteLine("Que pena! A compra nao possui frete gratis.");
        }
    }
}