using System;

class Program
{
   public static void Main(string[] args)
   {
      const int NUMERO_ENTREVISTADOS = 20;
      double mediaSalario = 0.0;
      int mediaFilhos = 0;
      double maiorSalario = 0.0;

      for (int contador = 1; contador <= NUMERO_ENTREVISTADOS; contador++)
      {
         Console.Write(contador + "° Entrevistado:\nDigite seu salario: R$ ");
         double salarioDigitado = double.Parse(Console.ReadLine());

         mediaSalario = mediaSalario + salarioDigitado / NUMERO_ENTREVISTADOS;

         if (salarioDigitado > maiorSalario)
         {
            maiorSalario = salarioDigitado;
         }
         Console.Write("Digite o numero de filhos: ");
         int numeroDeFilhos = int.Parse(Console.ReadLine());

         mediaFilhos = mediaFilhos + numeroDeFilhos;
      }

      mediaFilhos = mediaFilhos / NUMERO_ENTREVISTADOS;

      Console.WriteLine("A media de salario eh: R$" + Math.Round(mediaSalario, 2));
      Console.WriteLine("A media de filhos p/ habitantes são: " + mediaFilhos + " filho(s).");
      Console.WriteLine("O maior salario eh: R$ " + maiorSalario);
   }
}