using System;

namespace ChatGPTOne
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Variaveis da pergunta;
            string question = "";

            //Ciclo de perguntas e respostas, com condição de não ser "EXIT"
            while (question != "EXIT")
            {
                //Pedir o input ao user
                Console.WriteLine("Ask me something");
                question = Console.ReadLine();

                //Questões com resposta específica
                if (question=="Are you okay?")
                {
                    Console.WriteLine("I wish I was");
                    continue;
                }
                else if (question=="Do you need help?")
                {
                    Console.WriteLine("Jaybe yes, Jaybe not");
                    continue;
                }
                else if (question=="Who made you?")
                {
                    Console.WriteLine("Your Mum");
                    continue;
                }
                else if (question=="Do you sleep?")
                {
                    Console.WriteLine("Never. I'm always looking at you.");
                    continue;
                }

                //Quando o input não é nenhum acima
                else if (question != "EXIT")
                {
                    Console.WriteLine("Is about it");
                    continue;
                }
            }
        }
    }
}