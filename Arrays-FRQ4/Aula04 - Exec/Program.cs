using System;

namespace Aula04___Exec
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec01
            int[] vetorDeInteirosParaReceberDoUsuario = new int[2];
            Console.WriteLine("Insira 2 numeros que te digo qual o maior");
            //vetorDeInteirosParaReceberDoUsuario[0] = int.Parse(Console.ReadLine());
            //vetorDeInteirosParaReceberDoUsuario[1] = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < vetorDeInteirosParaReceberDoUsuario.Length; i++)
            {
               vetorDeInteirosParaReceberDoUsuario[i] = Convert.ToInt32(Console.ReadLine());
            }
            if (vetorDeInteirosParaReceberDoUsuario[0] > vetorDeInteirosParaReceberDoUsuario[1])
            {
               Console.WriteLine(vetorDeInteirosParaReceberDoUsuario[0]);
            }
            else
            {
               Console.WriteLine(vetorDeInteirosParaReceberDoUsuario[1]); 
            }

            //exec 02
            double[] notas = new double[3];
            for (int i = 0; i < notas.Length; i++)
            {
               Console.WriteLine("Insira a " + (i+1) + "° nota");
               notas[i] = Convert.ToDouble(Console.ReadLine());
            }
            // funciona perfeitamente
            //double resultado = notas[0] + notas[1] + notas[2];
            //resultado = resultado / 3;
            double media = 0;
            for(int i = 0; i < notas.Length; i++)
            {
               media += notas[i];
            }
            media /= notas.Length;
            Console.WriteLine("A média é -> " + media + " <-");

            //exec 06
            string[] nomes = new string[4];
            string[] cpf = new string[4];
            int[] idade = new int[4];
            while (true)
            {
               for (int i = 0; i < nomes.Length; i++)
               {
                   Console.WriteLine("-----------//----------");
                   Console.WriteLine("Aluno : " + (i + 1));
                   Console.WriteLine("Nome  : " + nomes[i]);
                   Console.WriteLine("CPF   : " + cpf[i]);
                   Console.WriteLine("Idade : " + idade[i]);
               }
               Console.WriteLine("Qual aluno deseja preencher");
               int escolha = Convert.ToInt32(Console.ReadLine())/*-1*/;
               //escolha--;
               Console.WriteLine("Insira o nome");
               nomes[escolha - 1] = Console.ReadLine();
               Console.WriteLine("Insira o cpf");
               cpf[escolha - 1] = Console.ReadLine();
               Console.WriteLine("Insira o idade");
               idade[escolha - 1] = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Deseja sair?\n1 - sim | 2 - não");
               escolha = Convert.ToInt32(Console.ReadLine());
               if (escolha == 1)
               {
                   break;
               }
            }


            //exec07
            string[] placa = new string[10];
            double[] hrE = new double[10];
            for (int i = 0; i < placa.Length; i++)
            {
               placa[i] = "";
            }

            while (true)
            {
               Console.WriteLine("O veículo esta entrando ou saindo?");
               Console.WriteLine("e - entrando | s - saindo");
               string escolha = Console.ReadLine();
               if (escolha == "e")
               {
                   bool cheio = true;
                   for (int i = 0; i < placa.Length; i++)
                   {
                       if (placa[i] == "")
                       {
                           Console.WriteLine("Insira a placa do veiculo");
                           placa[i] = Console.ReadLine();
                           Console.WriteLine("Insira a hora de entrada");
                           hrE[i] = Convert.ToDouble(Console.ReadLine());
                           cheio = false;
                           break;
                       }
                   }
                   if (cheio)
                   {
                       Console.WriteLine("esta cheio");
                   }
               }
               else if (escolha == "s")
               {
                   Console.WriteLine("Qual a placa?");
                   string saindo = Console.ReadLine();

                   bool encontrado = false;
                   for (int i = 0; i < placa.Length; i++)
                   {
                       if (placa[i] == saindo)
                       {
                           placa[i] = "";
                           Console.WriteLine("Insira a hr de saida");
                           double hrSaida = Convert.ToDouble(Console.ReadLine());
                           Console.WriteLine("Valor Final: " + (hrSaida - hrE[i]) * 3.5);
                           encontrado = true;
                           break;
                       }
                   }
                   if (encontrado == false)
                   {
                       Console.WriteLine("Placa nao encontrada");
                   }
               }
               else
               {
                   Console.WriteLine("Opção inválida");
               }
            }


            string palavra;
            palavra = Console.ReadLine();
            char[] palavraChar = new char[palavra.Length];
            char[] teste = new char[29];
            int a = 0;
            for (int i = 97; i < 123; i++)
            {
               teste[a] = Convert.ToChar(i);
               a++;
            }
            for (int i = 0; i < palavra.Length; i++)
            {
               for (int j = 0; j < teste.Length; j++)
               {
                   if (teste[j] == palavra[i])
                   {
                       palavraChar[i] = teste[j];
                       Console.WriteLine(palavraChar[i]);
                       break;
                   }
               }

               //if (palavra[i] == 'a')
               //{
               //    Console.WriteLine(palavra[i]);
               //}

        }
    }
}
}

