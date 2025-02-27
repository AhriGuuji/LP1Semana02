using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro:");
            string askedNumber = Console.ReadLine();
            sbyte savedNumber = sbyte.Parse(askedNumber);
            
            Console.WriteLine($"Resultado da operação de decremento de {askedNumber} é: {--savedNumber}");
            Console.WriteLine($"Resultado da operação de incremento de {askedNumber} é: {++savedNumber}");
            
        }
    }
}
