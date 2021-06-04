using System;

namespace Função_FRQ7._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //exec 02 - 2
            //Program prog = new Program();
            //int[] vektor = new int[10];
            //Random ran = new Random();
            //int escolha;
            //for (int i = 0; i <  vektor.Length; i++)
            //{
            //    vektor[i] = ran.Next(0, 9 + 1);
            //    Console.Write(vektor[i] + " ");
            //}
            //Console.WriteLine("\n\n\n");
            //Console.WriteLine("Sr.Usuário, qual elemento dseja ver? 0 a 10");
            //escolha = Convert.ToInt32(Console.ReadLine());
            //escolha--;
            //int resultado = prog.Escolhe(vektor, escolha);
            //Console.WriteLine(resultado);

            //exec 04 - 2
            //Program prog = new Program();
            //int n1, n2;
            //string soma;
            //Console.WriteLine("Insira 2 números inteiros");
            //n1 = prog.CRI();
            //n2 = prog.CRI();
            //Console.WriteLine("Insira ( + ) para soma ou ( - ) para subtração");
            //soma = Console.ReadLine();
            //int resultado = prog.Numeros(n1, n2, soma);
            //Console.WriteLine(resultado);


            //exec 05 -2
            //Program prog = new Program();
            //string[] logins = { "a", "b", "c", "d", "e" };
            //string[] senhas = {"A", "B","C","D","E"};
            //Console.WriteLine("Login");
            //string login = Console.ReadLine();
            //Console.WriteLine("Senha");
            //string senha = Console.ReadLine();
            //string resposta = prog.Login(logins, senhas, login, senha);
            //Console.WriteLine(resposta);

        }

        public string CR()
        {
            return Console.ReadLine();
        }
        public int CRI()
        {
            return Convert.ToInt32(CR());
        }
        public double CRD()
        {
            return Convert.ToDouble(CR());
        }

        //exec 02-1
        public int Escolhe(int[] vetor, int n)
        {
            return vetor[n];
        }

        //exec 05 -2
        public string Login(string[] logins, string[] senhas, string login, string senha)
        {
            for (int i = 0; i < logins.Length; i++)
            {
                if (logins[i] == login && senhas[i] == senha)
                {
                    return "Login Efetuado";
                }
            }
            return "Login Invalido";
        }

        public int Numeros(int x,int y, string soma)
        {
            switch (soma)
            {
                case "+":
                    int resultadoSoma = x + y;
                    return resultadoSoma;

                case "-":
                    int resultadoSubtração = x - y;
                    return resultadoSubtração;

                default:
                    Console.WriteLine("Não foi possivel efetuar a conta!");
                    return 0;
            }     
        }

        public int Quest3(int[] vetor10, int valores)
        {
            for (int i = 0; i < vetor10.Length; i++)
            {
                vetor10[0] = valores++;
                return vetor10[0];
            }
        }
    }
}
