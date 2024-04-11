using System;
using System.Diagnostics;
using System.Dynamic;
struct Produto
{
    public int codigo;
    public string nome;
    public double preco;
    public bool disponibilidade;
}
class Program
{
    static void Main(string[] args)
    {
        const int TAMANHO_VETOR = 4;
        Produto[] produtos = new Produto[TAMANHO_VETOR];

        for (int i = 0; i < produtos.Length; i++)
        {
            produtos[i].codigo = Convert.ToInt32(Console.ReadLine());
            produtos[i].nome = Console.ReadLine();
            produtos[i].preco = Convert.ToDouble(Console.ReadLine());
            produtos[i].disponibilidade = Convert.ToBoolean(Console.ReadLine());
        }
        for (int i = 0; i < produtos.Length; i++)
        {
            if (produtos[i].disponibilidade == true)
            {
                Console.WriteLine(produtos[i].nome);
                Console.WriteLine(produtos[i].preco);
            }
        }
    }
}