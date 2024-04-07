using System;
class Program
{
    static String ClassificarNadador(int idadeNadador)
    {

        if (idadeNadador < 12)
        {
            return "Infantil";
        }
        else if (idadeNadador == 12 && idadeNadador <= 14)
        {
            return "Juvenil A";
        }
        else if (idadeNadador == 15 || idadeNadador <= 17)
        {
            return "Juvenil B";
        }
        else
        {
            return "Adulto";
        }
    }
    static void Main(string[] args)
    {
        System.Console.WriteLine("Digite sua idade: ");
        int idadeDigitada = Convert.ToInt32(Console.ReadLine());

        String resultado = ClassificarNadador(idadeDigitada);

        System.Console.WriteLine(resultado);
    }
}