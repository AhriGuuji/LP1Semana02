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

            double V = (Math.PI*(rTranslated*rTranslated)*aTranslated);
            double S = (2*Math.PI*rTranslated*(rTranslated+aTranslated));

            string resultV = $"{V:f3}";
            string resultS = $"{S:f3}";
            
            Console.WriteLine($"O volume do cilindro é: {resultV}");
            Console.WriteLine($"A área da superfífcie do cilindro é: {resultS}");
        }
    }
}
