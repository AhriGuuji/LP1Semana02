using System;

namespace VariousOperators
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira um número inteiro não negativo:");
            string askedNumber = Console.ReadLine();
            byte savedNumber = byte.Parse(askedNumber);

            Console.WriteLine($"Divisão por 2: {savedNumber/2}");
            Console.WriteLine($"ShiftLeft por 3: {savedNumber<<3}");
            Console.WriteLine($"XOR por 6: {savedNumber^6}");
            Console.WriteLine($"Verifica se é maior que 10: {savedNumber>10}");
        }
    }
}