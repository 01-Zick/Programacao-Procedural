using System;
class Program
{
  static void Main(string[] args)
  {
    Console.WriteLine("digite o nome do usuario: ");
    string usuario = Console.ReadLine();

    Console.WriteLine("digite a senha: ");
    string senha = Console.ReadLine();

    if (usuario == "admin" && senha == "123senha")
    {
      Console.WriteLine("Login realizado com sucesso!");
    }
    else
    {
      Console.WriteLine("Credenciais invalidas");
    }
  }
}