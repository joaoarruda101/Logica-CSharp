using System;

namespace Aula02_Exec
{
    class Program
    {
        static void Main(string[] args)
        {
            //double numero;
            //numero = Convert.ToDouble(Console.ReadLine());

            //if (numero > 10)
            //{
            //    Console.WriteLine(numero);
            //}
            //else
            //{
            //    Console.WriteLine("Não é maior que 10!");
            //}

            //double numero1, numero2;
            //numero1 = Convert.ToDouble(Console.ReadLine());
            //numero2 = Convert.ToDouble(Console.ReadLine());
            //if (numero1 == numero2)
            //{
            //    Console.WriteLine("São Iguais");
            //}
            //else if (numero1 != numero2)
            //{
            //    Console.WriteLine("São Diferentes");
            //}

            //Console.WriteLine("Me de dois valores!");

            //double valor1;
            //double valor2;
            //valor1 = Convert.ToDouble(Console.ReadLine());
            //valor2 = Convert.ToDouble(Console.ReadLine());

            //if (valor1 > valor2)
            //{
            //    Console.WriteLine("Maior número : " + valor1);
            //}
            //else
            //{
            //    Console.WriteLine("Maior número : " + valor2);
            //}

            //Console.WriteLine("Escreve 3 três valores");
            //double val1;
            //double val2;
            //double val3;

            //val1 = Convert.ToDouble(Console.ReadLine());
            //val2 = Convert.ToDouble(Console.ReadLine());
            //val3 = Convert.ToDouble(Console.ReadLine());

            //if (val1 > val2 && val1 > val3)
            //{
            //    Console.WriteLine("Maior Número :" + val1);
            //}
            //else if (val2 > val1 && val2 > val3)
            //{
            //    Console.WriteLine("Maior Número :" + val2);
            //}
            //else if (val3 > val2 && val3 > val1)
            //{
            //    Console.WriteLine("Maior Número :" + val3);
            //}

            //Console.WriteLine("Me dê um valor!");
            //double v1;
            //v1 = Convert.ToDouble(Console.ReadLine());
            //switch (v1)
            //{
            //    case 1:
            //        Console.WriteLine("O valor é 1");
            //        break;
            //    case 2:
            //        Console.WriteLine("O valor é 2");
            //        break;
            //    case 3:
            //        Console.WriteLine("O valor é 3");
            //        break;
            //    default:
            //        Console.WriteLine("Só aceitamos valores de 1 a 3");
            //        break;
            //}

            //Random rnd = new Random();
            //int L = rnd.Next(1, 4);
            //if (L >= 3)
            //{
            //    Console.WriteLine(L + " Você Venceu");
            //}
            //else
            //{
            //    Console.WriteLine("Você perdeu!");
            //}

            //Console.WriteLine("Me informe um número e eu direi se é par ou impar");
            //int vlr = Convert.ToInt32(Console.ReadLine());
            //if (vlr % 2 == 0)
            //{
            //    Console.WriteLine("PAR");
            //}
            //else
            //{
            //    Console.WriteLine("IMPAR");
            //}

            //Console.WriteLine("Dígite seu preço, Vamos ver se terá desconto!");
            //double vlrd = Convert.ToDouble(Console.ReadLine());
            //double percentual = 28.0 / 100.0;
            //if (percentual < 254.50)
            //{
            //    double desconto = vlrd - (percentual * vlrd);
            //    Console.WriteLine("Seu desconto é : $" + desconto);
            //}
            //else
            //{
            //    Console.WriteLine("Você não tem desconto!");
            //}

            ////exec08
            //double vlrp;
            //vlrp = Convert.ToDouble(Console.ReadLine());
            //if(vlrp > 254.50)
            //{
            //    double vlrPdesconto = vlrp * 28.0 / 100;
            //    Console.WriteLine("Valor original : " + vlrp);
            //    Console.WriteLine("Valor com desconto : " + vlrPdesconto);
            //}
            //else if(vlrp < 254.50)
            //{
            //    double vlrPdesconto2 = vlrp * 21.0 / 100;
            //    Console.WriteLine("Valor original : " + vlrp);
            //    Console.WriteLine("Valor com desconto : " + vlrPdesconto2);
            //}

            ////exec09
            //double salario;
            //Console.WriteLine("Me informe seu salário!");
            //salario = Convert.ToDouble(Console.ReadLine());
            //if (salario == 600)
            //{
            //    double Aumento1 = salario * 30.0 / 100;
            //    Console.WriteLine("Seu aumento é de 30% = " + Aumento1 +"+"+ salario +" = " + (Aumento1 + salario));
            //}
            //else if (salario >= 600.01 && salario <= 1100)
            //{
            //    double Aumento2 = salario * 25.0 / 100;
            //    Console.WriteLine("Seu aumento é de 25% = " + Aumento2 + "+" + salario + " = " + (Aumento2 + salario));

            //}
            //else if (salario >= 1100.01 && salario <= 2400)
            //{
            //    double Aumento3 = salario * 20.0 / 100;
            //    Console.WriteLine("Seu aumento é de 20% = " + Aumento3 + "+" + salario + " = " + (Aumento3 + salario));

            //}
            //else if (salario > 2400.01 && salario <= 3550)
            //{
            //    double Aumento4 = salario * 15.0 / 100;
            //    Console.WriteLine("Seu aumento é de 15% = " + Aumento4 + "+" + salario + " = " + (Aumento4 + salario));

            //}
            //else if (salario > 3550)
            //{
            //    double Aumento5 = salario * 10.0 / 100;
            //    Console.WriteLine("Seu aumento é de 10% = " + Aumento5 + "+" + salario + " = " + (Aumento5 + salario));

            //}
            //else
            //{
            //    Console.WriteLine("Você não tem aumento");
            //

            //exec10MyActivity

            //double valorPagar;
            //string cartao, quinta;
            //Console.WriteLine("Insira o valor que deseja pagar");
            //valorPagar = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine("Você tem cartão fidelidade?");
            //Console.WriteLine("(s)Sim | (n)Não");
            //cartao = Console.ReadLine();
            //Console.WriteLine("É a sua quinta comprar ?");
            //Console.WriteLine("(s)Sim | (n)Não");
            //quinta = Console.ReadLine();
            
            //if(valorPagar > 200.01 && valorPagar < 400)
            //{
            //    valorPagar = valorPagar - valorPagar * 0.10;
                
            //}
            //else if(valorPagar > 400)
            //{
            //    valorPagar = valorPagar - valorPagar * 0.20;
               
            //}
            //switch (cartao)
            //{
            //    case "s":
            //        valorPagar = valorPagar - valorPagar * 0.10;
            //        break;
            //}
            //if(quinta == "s")
            //{
            //    valorPagar = valorPagar - valorPagar * 0.15;
            //}
            //Console.WriteLine("Valor com desconto é");
            //Console.WriteLine("{0:c}", valorPagar);

        }
    }
}
