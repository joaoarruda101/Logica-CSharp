using System;

namespace Matrizes_FRQ5
{
    class Program
    {
        static void Main(string[] args)
        {
            exec01
            int[][] matriz = new int[4][]; // gera uma matriz com 4 linhas
            for (int i = 0; i < matriz.Length; i++) // percorre todas as linhas
            {
               matriz[i] = new int[4]; // gera minhas colunas
            }
            for (int i = 0; i < matriz.Length; i++) // percorre todas as linhas
            {
               for (int j = 0; j < matriz[i].Length; j++) // percorre todas as colunas da linha i
               {
                   Console.WriteLine("insira o elemento -> " + i + " " + j);
                   matriz[i][j] = Convert.ToInt32(Console.ReadLine());
               }
            }
            int contador = 0;
            for (int i = 0; i < matriz.Length; i++)
            {
               for (int j = 0; j < matriz[i].Length; j++)
               {
                   if (matriz[i][j] > 10)
                   {
                       contador++;
                   }
                   Console.Write(matriz[i][j] + "  ");
               }
               Console.WriteLine();
            }
            Console.WriteLine(contador);



            //exec02
            int x = 5, y = 5;
            int[,] diagonal = new int[x,y];
            for (int i = 0; i < x; i++)
            {
               for (int j = 0; j < y; j++)
               {
                   if (i == j)
                   {
                       diagonal[i, j] = 1;
                   }
                   else
                   {
                       diagonal[i, j] = 0;
                   }
               }
            }
            for (int i = 0; i < x; i++)
            {
               for (int j = 0; j < y; j++)
               {
                   Console.Write(diagonal[i, j] + " ");
               }
               Console.WriteLine();
            }

            //exec 03
            int[][] matriz = new int[4][];
            for (int i = 0; i < matriz.Length; i++)
            {
               matriz[i] = new int[4];
            }
            for (int i = 0; i < matriz.Length; i++)
            {
               for (int j = 0; j < matriz[i].Length; j++)
               {
                   matriz[i][j] = i * j;
                   Console.Write(matriz[i][j] + " ");
               }
               Console.WriteLine();
            }

            extra , copiando matriz
            int[][] matriz = new int[4][];
            for (int i = 0; i < matriz.Length; i++)
            {
               matriz[i] = new int[4];
            }
            int[][] matrizCopia = matriz;
            int[][] matrizCopia2 = new int[1][];
            ...
            matrizCopia2 = matriz;

            exec04
            int[][] mtrz = new int[5][];
            for (int i = 0; i < mtrz.Length; i++)
            {
               mtrz[i] = new int[5];
            }
            for (int i = 0; i < mtrz.Length; i++)
            {
               for (int j = 0; j < mtrz[i].Length; j++)
               {
                   Console.WriteLine("Insira um valor " + i + " " + j);
                   mtrz[i][j] = Convert.ToInt32(Console.ReadLine());
               }
            }
            Console.WriteLine("Insira um valor que iremos verificar na matriz!");
            int x = Convert.ToInt32(Console.ReadLine());
            bool falhou = true;
            for (int i = 0; i < mtrz.Length; i++)
            {
               for (int j = 0; j < mtrz[i].Length; j++)
               {
                   if(x == mtrz[i][j])
                   {
                       Console.WriteLine("//LOCALIZADO EM " + i + " " + j + "//");
                       falhou = false;
                   }
               }
            }
            if (falhou)
            {
               Console.WriteLine("----!não localizado!----");
            }

            exec05
            Random rdn = new Random();
            int[][] matriz01 = new int[4][];
            int[][] matriz02 = new int[4][];
            int[][] resultado = new int[4][];
            for (int i = 0; i < matriz01.Length; i++)
            {
               matriz01[i] = new int[4];
               matriz02[i] = new int[4];
               resultado[i] = new int[4];
            }
            for (int i = 0; i < matriz01.Length; i++)
            {
               for (int j = 0; j < matriz01[i].Length; j++)
               {
                   matriz01[i][j] = rdn.Next(0, 10);
                   Console.Write(matriz01[i][j] + " ");
               }
               Console.WriteLine();
            }
            Console.WriteLine("--------------ZZ--------------");
            for (int i = 0; i < matriz02.Length; i++)
            {
               for (int j = 0; j < matriz02[i].Length; j++)
               {
                   matriz02[i][j] = rdn.Next(0, 10);
                   Console.Write(matriz02[i][j] + " ");
               }
               Console.WriteLine();
            }
            Console.WriteLine("----------------XX---------------");
            for (int i = 0; i < resultado.Length; i++)
            {
               for (int j = 0; j < resultado[i].Length; j++)
               {
                   if (matriz01[i][j] > matriz02[i][j])
                   {
                       resultado[i][j] = matriz01[i][j];
                   }
                   else
                   {
                       resultado[i][j] = matriz02[i][j];
                   }
                   Console.Write(resultado[i][j] + " ");
               }
               Console.WriteLine();
            }

            exec06
            Random rdn = new Random();
            int[][] matriz = new int[10][];
            for (int i = 0; i < matriz.Length; i++)
            {
               matriz[i] = new int[10];
            }
            for (int i = 0; i < matriz.Length; i++)
            {
               for (int j = 0; j < matriz[i].Length; j++)
               {
                   matriz[i][j] = rdn.Next(0, 10);
                   if (i < j)
                   {
                       matriz[i][j] = 2 * i + 7 * j - 2;
                       Console.Write(matriz[i][j]);
                   }
                   if (i == j)
                   {
                       matriz[i][j] = 3 * i - 1;
                       Console.Write(matriz[i][j]);
                   }
                   if ( i > j)
                   {
                       matriz[i][j] = 4 * i - 5 * j + 1;
                       Console.Write(matriz[i][j]);
                   }

               }
               Console.WriteLine();
            }

            exec07
            Random rdn = new Random();
            int[][] matriz = new int[3][];
            for (int i = 0; i < matriz.Length; i++)
            {
               matriz[i] = new int[3];
            }
            for (int i = 0; i < matriz.Length; i++)
            {
               for (int j = 0; j < matriz[i].Length; j++)
               {
                   matriz[i][j] = rdn.Next(0, 10);
                   Console.Write(matriz[i][j] + " ");
               }
               Console.WriteLine();
            }
            int vf = 0;
            for (int i = 0; i < matriz.Length; i++)
            {
               for (int j = 0; j < matriz[i].Length; j++)
               {
                   if(i < j)
                   {
                       vf = vf + matriz[i][j];
                       Console.WriteLine("Somando/Resultado : " + vf);
                   }
               }
            }

            exec08
            Random rdn = new Random();
            int[][] matriz = new int[3][];

            for (int i = 0; i < matriz.Length; i++)
            {
               for (int j = 0; j < matriz.Length; j++)
               {
                   matriz[i] = new int[3];
               }
            }
            for (int i = 0; i < matriz.Length; i++)
            {
               for (int j = 0; j < matriz[i].Length; j++)
               {
                   matriz[i][j] = rdn.Next(0, 10);
                   Console.Write(matriz[i][j] + " ");
               }
               Console.WriteLine();
            }
            int vf = 0;
            for (int i = 0; i < matriz.Length; i++)
            {
               for (int j = 0; j < matriz[i].Length; j++)
               {
                   if (i > j)
                   {
                       vf = vf + matriz[i][j];
                       Console.WriteLine("Somando/ Resultado : " + vf);
                   }
               }
            }

            exec09
            int[][] matriz = new int[4][];
            Random ran = new Random();
            for (int i = 0; i < matriz.Length; i++)
            {
                  matriz[i] = new int[4];             
            }
            for (int i = 0; i < matriz.Length; i++)
            {
               for (int j = 0; j < matriz[i].Length; j++)
               {
                   matriz[i][j] = ran.Next(1, 20);
                   Console.Write(matriz[i][j] + " ");
               }
               Console.WriteLine();
            }
            Console.WriteLine("----- Matriz Transformada -----");
            for (int i = 0; i < matriz.Length; i++)
            {
               for (int j = 0; j < matriz[i].Length; j++)
               {
                   if (i < j)
                   {
                       matriz[i][j] = 0;
                   }
                   else
                   {
                       matriz[i][j] = matriz[i][j];
                   }
                   Console.Write(matriz[i][j] + " ");
               }
               Console.WriteLine();
            }

            //exec 10
            Random ran = new Random();
            int[,] matriz = new int[5, 5];
            // preenche a matriz
            // 0 = linhas | 1 = colunas
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
            matriz[i, j] = ran.Next(0, 25);
            // faz a busca por elementos repetidos
            for (int k = 0; k < matriz.GetLength(0); k++)
            {
            for (int l = 0; l < matriz.GetLength(1); l++)
            {
            if (matriz[i, j] == matriz[k, l] && (i != k || j != l))
            {
            //Console.WriteLine("Achou " + k + l);
            k = matriz.GetLength(0);
            j--;
            break;
            }
            }
            }
            }
            }
            for (int i = 0; i < matriz.GetLength(0); i++)
            {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
            if (matriz[i, j] < 10)
            {
            Console.Write("0" + matriz[i, j] + " ");
            }
            else
            {
            Console.Write(matriz[i, j] + " ");
            }
            }
            Console.WriteLine();
            }
        }
    }
}
