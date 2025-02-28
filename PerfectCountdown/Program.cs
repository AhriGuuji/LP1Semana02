using System;

namespace PerfectCountdown
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int startNumberInt = 1;

            while (startNumberInt >= 0)
            {
                //Pede ao user um número inicial maior que 1 e um número de passo maior que 1 até o inicial.
                Console.WriteLine("Start Number: ");
                string start = Console.ReadLine();
                Console.WriteLine("Start Step: ");
                string step = Console.ReadLine();

                //Tradução do Input para int
                startNumberInt = int.Parse(start);
                int stepNumberInt = int.Parse(step);

                //Definição de intervalos e comportamentos
                if (startNumberInt <= 1 || stepNumberInt <= 1)
                {
                    Console.WriteLine("Out-of-range start or step. Try again.");
                    startNumberInt = 0;
                    stepNumberInt = 0;
                }
                else if ( stepNumberInt >= startNumberInt)
                {
                    Console.WriteLine("Start must be higher than step. Try again.");
                    startNumberInt = 0;
                    stepNumberInt = 0;
                }
                else if (startNumberInt % stepNumberInt != 0)
                {
                    Console.WriteLine("Start not divisible by step. Try again.");
                    startNumberInt = 0;
                    stepNumberInt = 0;
                }
                //Se for o pretendido, irá correr o programa e finalizar
                else
                {
                    while(startNumberInt>=0)
                    {
                        Console.WriteLine($"{startNumberInt}");
                        startNumberInt -= stepNumberInt;
                    }
                }
            }
        }
    }
}
