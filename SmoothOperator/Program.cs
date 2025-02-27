using System;

namespace SmoothOperator
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Write a int number:");
            string askedNumber = Console.ReadLine();
            sbyte savedNumber = sbyte.Parse(askedNumber);
            
            Console.WriteLine($"Resultado da operação de decremento de {askedNumber} é: {--savedNumber}");
            Console.WriteLine($"Resultado da operação de incremento de {askedNumber} é: {++savedNumber}");
            
        }
    }
}
