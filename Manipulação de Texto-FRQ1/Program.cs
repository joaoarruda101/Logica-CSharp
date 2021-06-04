using System;

namespace Aula01_Exer
{
    class Program
    {
        static void Main(string[] args)
        {
            string A = Console.ReadLine();
            Console.WriteLine("Você escreveu : " + A);

            int n1;
            int n2;
            int n3;

            Console.WriteLine("Escreva três números");
            n1 = Convert.ToInt32(Console.ReadLine());
            n2 = Convert.ToInt32(Console.ReadLine());
            n3 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();

            int R = n1 + n2 + n3;

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Resultado1 : " + R);
            Console.WriteLine("Resultado2 :" + (n1 + n2 / n3));
            Console.WriteLine("Priemro número > " + n1);
            Console.WriteLine("Segundo número > " + n2);
            Console.WriteLine("Terceiro número > " + n3);


        }
    }
}
