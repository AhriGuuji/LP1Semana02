using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura do cilindro");
            string a = Console.ReadLine();
            Console.WriteLine("Insira o raio do cilindro");
            string r = Console.ReadLine();
            double aTranslated = double.Parse(a);
            double rTranslated = double.Parse(r);

            Console.WriteLine($"O volume do cilindro é: {Math.PI*r^2*a}");
            Console.WriteLine($"A área da superfífcie do cilindro é: {2*Math.PI*r(r*a)}");
        }
    }
}
