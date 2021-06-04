using System;

namespace Aula3_Exec
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec01
            for(int i = 0; i < 10; i++)
            {
               Console.WriteLine(i + 1);
            }
            Console.WriteLine("--------------------------------");

            int x = 0;
            while (x < 10)
            {
               x++;
               Console.WriteLine(x);
            }

            //exec02
            for(int v = 0; v < 24; v++)
            {
               if(v % 2 == 0)
               {
                   Console.WriteLine(v);
               }
            }
            Console.WriteLine("-----------------------------");
            for (int v = 0; v < 24; v++)
            {
               Console.WriteLine(v++);
            }

            //exec03
            int valor;
            Console.WriteLine("Insira um número!");
            //valor = Convert.ToInt32(Console.Re
            {
               rvlr++;
               Console.WriteLine(rvlr);
            }
            while(rvlr > 0)
            {
               rvlr--;
               Console.WriteLine(rvlr);

            }

            //exec05

            double num1;
            string entrada;

            while (true)
            {
               Console.WriteLine("Insira um número");
               Console.WriteLine("Diigíte SAIR para finalizar o console");
               entrada = Console.ReadLine();
               if ( entrada == "SAIR" || entrada == "sair" || entrada == "Sair")
               {
                   Console.WriteLine("Console Finalizado!!");               
                   break;
               }
               num1 = Convert.ToDouble(entrada);
               if (num1 > 24)
               {
                   Console.WriteLine("É maior que 24");
                   Console.WriteLine("Multiplicado por 2 é = " + (num1 * 2));
               }
               if(num1 > 0)
               {
                   Console.WriteLine("(" + num1 + " É MAIOR QUE 0" + ")");
               }
               if(num1 <= 0)
               {
                   Console.WriteLine("Insira o número novamente!");
                   Console.WriteLine("");
               }
            }

            //xec06 - Quatro Variaveis
            string nome, endereço;
            int cpf;
            string cadastrar;

            while (true)
            {
               Console.WriteLine("Deseja Cadastrar mais um Aluno ? | (S)Sim - (N)Não |");
               cadastrar = Console.ReadLine();

               if (cadastrar == "S" || cadastrar == "s")
               {
                   Console.WriteLine("| Nome do Aluno |");
                   nome = Console.ReadLine();
                   Console.WriteLine("| Endereço do Aluno |");
                   endereço = Console.ReadLine();
                   Console.WriteLine("| CPF do Aluno |");
                   cpf = Convert.ToInt32(Console.ReadLine());

                   Console.Clear();

                   Console.WriteLine("=================/CADASTRO/==================");
                   Console.WriteLine("Nome : " + nome);
                   Console.WriteLine("Endereço : " + endereço);
                   Console.WriteLine("CPF : " + cpf);
                   Console.WriteLine("================/---------/==================");

               }
            }

            while (true)
            {
               //exec06
               string nome, cpf, endereco;
               //string escolha;
               Console.WriteLine("Insira o nome");
               nome = Console.ReadLine();

               Console.WriteLine("Insira o cpf");
               cpf = Console.ReadLine();

               Console.WriteLine("Insira seu endereço");
               endereco = Console.ReadLine();

               Console.WriteLine("============/CADASTRO/==============");
               Console.WriteLine("NOME : " + nome);
               Console.WriteLine("CPF : " + cpf);
               Console.WriteLine("ENDEREÇO : " + endereco);
               Console.WriteLine("============---------==============");
               Console.WriteLine("Deseja cadastrar mias um aluno (s)Sim | (n)Não");
               nome = Console.ReadLine();
               if (nome == "n")
               {
                   break;
               }

            //exec07
            Random rnd = new Random();
            double valorTotal = 0;
            for (int i = 0; i < 30; i++)
            {
               int dado = rnd.Next(1, 7);
               if(dado >= 3)
               {
                   valorTotal = valorTotal + 10;
               }
               else
               {
                   valorTotal += -15;
               }
            }
            if (valorTotal > 0)
            {
               Console.WriteLine("Você venceu : " + valorTotal);
            }
            else
            {
               Console.WriteLine("Você perdeu : " + valorTotal);
            }

            //exec08
            int queijo = 0, macarrao = 0, feijao = 0, presunto = 0, pao = 0, carrinho = 0;

            Console.WriteLine("Bem vindo ao super mercado !");
            while (true)
            {
               Console.WriteLine("Escolha um dos produto para colocar em seu carrinho");
               Console.WriteLine("1 - Queijo");
               Console.WriteLine("2 - Macarrão");
               Console.WriteLine("3 - Feijão");
               Console.WriteLine("4 - Presunto");
               Console.WriteLine("5 - Pão");
               Console.WriteLine("acabou ou fim para encerrar a compra");
               string escolha = Console.ReadLine();

               switch (escolha)
               {
                   case "1":
                       Console.WriteLine("Quantos queijos você deseja?");
                       queijo = queijo + Convert.ToInt32(Console.ReadLine());
                       Console.Clear();
                       break;
                   case "2":
                       Console.WriteLine("Quantos macarrôes você deseja?");
                       macarrao = macarrao + Convert.ToInt32(Console.ReadLine());
                       Console.Clear();
                       break;
                   case "3":
                       Console.WriteLine("Quantos feijões você deseja?");
                       feijao = feijao + Convert.ToInt32(Console.ReadLine());
                       Console.Clear();
                       break;
                   case "4":
                       Console.WriteLine("Quantos presuntos você deseja?");
                       presunto = presunto + Convert.ToInt32(Console.ReadLine());
                       Console.Clear();
                       break;
                   case "5":
                       Console.WriteLine("Quantos pães você deseja?");
                       pao = pao + Convert.ToInt32(Console.ReadLine());
                       Console.Clear();
                       break;
                   case "acabou":
                   case "fim":
                       Console.WriteLine("Obrigado por comprar na loja");
                       Console.Clear();
                       break;
                   default:
                       Console.Clear();
                       Console.WriteLine("          !!!OPÇÃO INVALIDA!!!");
                       break;
               }

               if (escolha == "acabou" || escolha == "fim")
               {
                   break;
               }
            }
            double valorTotal = 0;
            if (queijo > 3)
            {
               valorTotal += (queijo * 4.5) * 0.9;
            }
            else
            {
               valorTotal += queijo * 4.5;
            }
            if (macarrao > 3)
            {
               valorTotal += (macarrao * 5) - (macarrao * 5) * 0.1;
            }
            else
            {
               valorTotal += (macarrao * 5);
            }
            valorTotal += feijao * 4;
            valorTotal += presunto * 5.5;
            valorTotal += pao * 3.75;

            carrinho = queijo + macarrao + feijao + presunto + pao;
            if (carrinho > 7)
            {
               valorTotal *= 0.9;// valorTotal = valorTotal * 0.9
            }
            Console.WriteLine("O preço total é : ");
            Console.WriteLine("{0:c}", valorTotal);


        }
        }
    }
}

