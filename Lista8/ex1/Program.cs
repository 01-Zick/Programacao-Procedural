using System;
struct Pizza
{
    public int comanda;
    public string sabor;
    public double preco;
}
class Program
{
    static void Main(string[] args)
    {
        Pizza pedido1;
        pedido1.comanda = Convert.ToInt32(Console.ReadLine());
        pedido1.sabor = Console.ReadLine();
        pedido1.preco = Convert.ToDouble(Console.ReadLine());

        System.Console.WriteLine(pedido1.comanda);
        System.Console.WriteLine(pedido1.sabor);
        System.Console.WriteLine(pedido1.preco);
    }
}