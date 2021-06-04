using System;

namespace TratamentoDeExceção_FRQ9
{
    class Program
    {
        static void Main(string[] args)
        {
             //exec1 FOI UMA QUESTÃO CONCEITUAL!

            //exec02
            int a = 0;
            while (true)
            {
               Console.WriteLine("Insira um número");
               try
               {
                   a = int.Parse(Console.ReadLine());
                   Console.WriteLine("Deu certo!!!");
                   break;
               }
               catch (OverflowException)
               {
                   Console.WriteLine("Número gigantesco");
               }
               catch (FormatException)
               {
                   Console.WriteLine("Apenas Números");
               }
               catch (Exception)
               {

                   Console.WriteLine("ERRO");
               }
            }
            string teste = "";
            for (int i = 0; i < 100; i++)
            {
               teste = teste + "a";
            }
            Console.WriteLine(teste);

            //exec03
            double numA, numB, numC;
            while (true)
            {
               Console.WriteLine("Insira 3 números entre 0 e 10!");
               try
               {
                   numA = Convert.ToInt32(Console.ReadLine());
                   numB = Convert.ToInt32(Console.ReadLine());
                   numC = Convert.ToInt32(Console.ReadLine());
                   if (numA <= 10 && numB <= 10 && numC <= 10)
                   {
                       double media = numA + numB + numC / 3;
                       Console.WriteLine("Sua média é > " + media);
                   }
                   else
                   {
                       Console.WriteLine("Esses números são maiores que 10!");
                   }
               }
               catch (OverflowException)
               {
                   Console.WriteLine("Número gigantesco!");
               }
               catch (FormatException)
               {
                   Console.WriteLine("Apenas Números!");
               }
               catch (Exception)
               {
                   Console.WriteLine("ERROR*");
               }
            }

            //exec04
            Console.WriteLine("Insira números para colocar em um vetor!");
            int[] vetor = new int[5];
            int limbo = int.MinValue;
            int limbo2 = int.MaxValue;
            while (true)
            {
               try
               {
                   for (int i = 0; i < vetor.Length; i++)
                   {
                       vetor[i] = Convert.ToInt32(Console.ReadLine());
                       Console.WriteLine("(" + vetor[i] + ")" + " Inserido no vetor");
                   }
                   for (int j = 0; j < vetor.Length; j++)
                   {
                       if (limbo < vetor[j])
                       {
                           limbo = vetor[j];
                       }
                   }
                   for (int j = 0; j < vetor.Length; j++)
                   {
                       if (limbo2 > vetor[j])
                       {//int a = 0;
            while (true)
            {
               Console.WriteLine("Insira um número");
               try
               {
                   a = int.Parse(Console.ReadLine());
                   Console.WriteLine("Deu certo!!!");
                   break;
               }
               catch (OverflowException)
               {
                   Console.WriteLine("Número gigantesco");
               }
               catch (FormatException)
               {
                   Console.WriteLine("Apenas Números");
               }
               catch (Exception)
               {

                   Console.WriteLine("ERRO");
               }
            }
            string teste = "";
            for (int i = 0; i < 100; i++)
            {
               teste = teste + "a";
            }
            Console.WriteLine(teste);

            //exec03
            double numA, numB, numC;
            while (true)
            {
               Console.WriteLine("Insira 3 números entre 0 e 10!");
               try
               {
                   numA = Convert.ToInt32(Console.ReadLine());
                   numB = Convert.ToInt32(Console.ReadLine());
                   numC = Convert.ToInt32(Console.ReadLine());
                   if (numA <= 10 && numB <= 10 && numC <= 10)
                   {
                       double media = numA + numB + numC / 3;
                       Console.WriteLine("Sua média é > " + media);
                   }
                   else
                   {
                       Console.WriteLine("Esses números são maiores que 10!");
                   }
               }
               catch (OverflowException)
               {
                   Console.WriteLine("Número gigantesco!");
               }
               catch (FormatException)
               {
                   Console.WriteLine("Apenas Números!");
               }
               catch (Exception)
               {
                   Console.WriteLine("ERROR*");
               }
            }

            //exec04
            Console.WriteLine("Insira números para colocar em um vetor!");
            int[] vetor = new int[5];
            int limbo = int.MinValue;
            int limbo2 = int.MaxValue;
            while (true)
            {
               try
               {
                   for (int i = 0; i < limbo2.Lenght; i++)
                      {
                           limbo2 = vetor[j];
                       }
                   }
               }

               catch (OverflowException)
               {
                   Console.WriteLine("Número Gigantesco!");
               }
               catch (FormatException)
               {
                   Console.WriteLine("Apenas Números!");
               }
               catch (Exception)
               {
                   Console.WriteLine("*ERROR*");
               }
               Console.WriteLine("O Maior número é = " + limbo);
               Console.WriteLine("O Menor número é = " + limbo2);
            }
        }
    }
}
