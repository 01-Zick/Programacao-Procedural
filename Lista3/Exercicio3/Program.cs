using System;
class Program
{
    static void Main(string[] args)
    {
        int contador = 0;
        string loginEntrada = "admin";
        string loginSenha = "123senha";

        do
        {
            Console.WriteLine("Digite seu Login: ");
            string Loginusuario = Console.ReadLine();

            Console.WriteLine("Digite sua senha: ");
            string senhaUsuario = Console.ReadLine();

            if (loginEntrada == Loginusuario && loginSenha == senhaUsuario)
            {
                Console.WriteLine("Login realizado com sucesso!");
                break;
            }
            else
            {
               contador++;
               if (contador != 3)
               {
                   Console.WriteLine("Usuario e/ou senha incorreto. Tente outra vez:");
               }
            }
        }
        while (contador < 3);

        if (contador >= 3)
        {
            Console.WriteLine("Sua conta foi bloqueada.");
        }
    }
}