using System;

namespace DesafioDaEscada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sir. Pedreiro, por ventura terias a altura da");

            Console.WriteLine("escada?");

            double altura = Convert.ToDouble(Console.ReadLine());

            double volume = 0;

            int qtdDegraus = 0;

            bool meioDegrau = false;

            while (true)

            {

                if (altura > 0 && altura < 18)

                {

                    meioDegrau = true;

                    volume += altura * 30 * 50;

                    qtdDegraus++;

                }

                else if (altura >= 18)

                {

                    qtdDegraus++;

                }

                else

                {

                    break;

                }

                altura -= 18;//altura = altura - 18;

            }

            Console.WriteLine("Qtd degraus");

            Console.WriteLine(qtdDegraus);

            Console.WriteLine("Comprimento");

            Console.WriteLine(qtdDegraus * 30);

            Console.WriteLine("----------//---------");

            for (int i = qtdDegraus; i > 0; i--)

            {

                if (meioDegrau)

                {

                    volume += (i - 1) * (18 * 30 * 50);// = 27000

                    meioDegrau = false;

                }

                else

                {

                    volume += i * (18 * 30 * 50);// = 27000

                }

            }

            Console.WriteLine("Volume");

            Console.WriteLine(volume * 1.3246);
        }
    }
}
