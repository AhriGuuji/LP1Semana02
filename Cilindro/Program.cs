using System;

namespace Cilindro
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Pedir o input ao user
            Console.WriteLine("Insira a altura do cilindro");
            string a = Console.ReadLine();
            Console.WriteLine("Insira o raio do cilindro");
            string r = Console.ReadLine();
            
            //Traduzir de string para double
            double aTranslated = double.Parse(a);
            double rTranslated = double.Parse(r);

            //Realizar os cálculos do Volume e da Surface
            double V = (Math.PI*(rTranslated*rTranslated)*aTranslated);
            double S = (2*Math.PI*rTranslated*(rTranslated+aTranslated));

            //Traduzir e arredondar o valor de double para string
            string resultV = $"{V:f3}";
            string resultS = $"{S:f3}";
            
            //Apresentar os resultados
            Console.WriteLine($"O volume do cilindro é: {resultV}");
            Console.WriteLine($"A área da superfífcie do cilindro é: {resultS}");
        }
    }
}
