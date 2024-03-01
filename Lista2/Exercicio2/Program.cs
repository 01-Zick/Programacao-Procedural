using System;
class Program
{
    static void Main(string[] args)
   {
    Console.WriteLine("Digite a nota1: ");
      double nota1 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota2: ");
    double nota2 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota3: ");
    double nota3 = double.Parse(Console.ReadLine());

    Console.WriteLine("Digite a nota4: ");
    double nota4 = double.Parse(Console.ReadLine());

    double media = (nota1 + nota2 + nota3 + nota4) / 4;
      Console.WriteLine("A media eh: " + media);
    
    if (media >= 5)
    {
      Console.WriteLine("Aluno aprovado!");
    }
      else if (media < 5 && media >= 3)
      {
        Console.WriteLine("Aluno em recuperação");
      }
       else if (media < 3)
      {
        Console.WriteLine("Aluno reprovado");
      }
        
  }
}
  