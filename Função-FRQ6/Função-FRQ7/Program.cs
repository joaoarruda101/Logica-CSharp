using System;

namespace Função_FRQ7
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec01
            //Program prog = new Program();
            //int entrada1, entrada2, resultado;
            //Console.WriteLine("Insira 2 números");
            //entrada1 = Convert.ToInt32(Console.ReadLine());
            //entrada2 = Convert.ToInt32(Console.ReadLine());

            //resultado = prog.Compara(entrada1, entrada2);
            //Console.WriteLine(resultado);

            //exec02
            //Program prog = new Program();
            //Console.WriteLine("Insira um número");
            ////int x = Convert.ToInt32(Console.ReadLine());
            //int x = prog.CRI();
            //x = prog.ParOuImpar(x);
            //Console.WriteLine(x);

            //exec03
            //Program prog = new Program();
            //Console.WriteLine("Insira um valor qualquer!");
            //int x = prog.CRI();
            //x = prog.Verifica(x);
            //Console.WriteLine(x);

            //exec04
            //Program prog = new Program();
            //Console.WriteLine("Insira um valor em Celsius, Iremos converter para Fahrenheit");
            //double valor = prog.CRD();
            //valor = prog.Convercao(valor);
            //Console.WriteLine(valor);

            //exec05
            //Program prog = new Program();
            //Console.WriteLine("Insira as 3 notas");
            //double n1, n2, n3;
            //string escolha;
            //n1 = prog.CRD();
            //n2 = prog.CRD();
            //n3 = prog.CRD();
            //Console.WriteLine("O que deseja fazer ?");
            //Console.WriteLine("A > média aritmética das notas");
            //Console.WriteLine("P > média ponderada das notas");
            //Console.WriteLine("M > mediana das notas");
            //escolha = prog.CR();
            //double devolucao = prog.Escola(n1, n2, n3, escolha);
            //Console.WriteLine("-------------------------------");
            //if(devolucao == -1)
            //{
            //    Console.WriteLine("Deu ruim, Opção invalida");
            //}
            //else
            //{
            //    Console.WriteLine(devolucao);
            //}

            //exec06
            //Program prog = new Program();
            //Console.WriteLine("Insira um valor! FOUMA UTILIZADA (a + b + c) / d * e ");
            //double a, b, c, d, e;
            //double valorA = prog.CRD();
            //double valorB = prog.CRD();
            //double valorC = prog.CRD();
            //double valorD = prog.CRD();
            //double valorE = prog.CRD();
            //double allNumb = prog.Valores(valorA, valorB, valorC, valorD, valorE);
            //Console.WriteLine("Resultado = " + allNumb);

            //exec07
            //Program prog = new Program();
            //Console.WriteLine("Insira os valores para retornarmos a reta da hipotenusa de um triângulo retângulo!");
            //double a, b;
            //a = prog.CRD();
            //b = prog.CRD();
            //double resultado = prog.TrianguloRetagulo(a, b);
            //Console.WriteLine("Resultado > " + resultado);


            //exec08
            //Program prog = new Program();
            //Console.WriteLine("Insira o tamanho do vetor");
            //int tamanho = prog.CRI();
            //int[] numeros = new int[tamanho];
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    numeros[i] = prog.CRI();
            //}

            //numeros = prog.SortManual(numeros);
            //Console.WriteLine("----------------------");
            ////mostra o vetor
            //for (int i = 0; i < numeros.Length; i++)
            //{
            //    Console.WriteLine(numeros[i]);
            //}



        }

        public string CR()
        {
            return Console.ReadLine();
        }
        public int CRI()
        {
            return Convert.ToInt32(Console.ReadLine());
        }
        public double CRD()
        {
            return Convert.ToDouble(Console.ReadLine());
        }

        //exec01
        public int Compara(int x, int y)
        {
            if(x > y)
            {
                return y;
            }
            else
            {
                return x;
            }
        }


        //exec02
        public int ParOuImpar(int entrada)
        {
            if(entrada % 2 == 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        //exec03
        public int Verifica(int x)
        {
            if(x == 0)
            {
                return 0;
            }
            if(x > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        //exec04
        public double Convercao(double celsius)
        {
            celsius = (celsius * 9 / 5) + 32;
            return celsius;
        }

        //exec05
        public double Escola(double nota1, double nota2, double nota3, string opc)
        {
            double resultado;
            switch (opc)
            {
                case "A":
                case "a":
                    resultado = (nota1 + nota2 + nota3) / 3;
                    return resultado;

                case "P":
                case "p":
                    resultado = (nota1 * 5 + nota2 * 3 + nota3 * 2) / 5 + 3 + 2;
                    return resultado;

                case "M":
                case "m":
                    double[] notas = new double[3];
                    notas[0] = nota1;
                    notas[1] = nota2;
                    notas[2] = nota3;
                    Array.Sort(notas);
                    resultado = notas[1];
                    return resultado;

                default:
                    return -1;
                
            }
        }

        //exec06
        public double Valores(double a, double b, double c, double d, double e)
        {
            double formula = (a + b + c) / d * e;
            return formula;
           
        }

        //exec07
        public double TrianguloRetagulo(double a, double b)
        {

            double hipotenusa;
            hipotenusa = a * a + b * b;
            hipotenusa = Math.Sqrt(hipotenusa);
            return hipotenusa;
        }

        //exec08
        public int[] SortManual(int[] vetor)
        {
            //laço que percorre o vetor do inicio ao fim
            for(int i = 0; i < vetor.Length; i++)
            {
                //laço que volta organizando
                for (int j = i; j > 0; j--)
                {
                    if(vetor[j-1] > vetor[j])
                    {
                        int temp = vetor[j];
                        vetor[j] = vetor[j - 1];
                        vetor[j - 1] = temp;
                    }
                }
            }

            return vetor;
        }

    }
}
