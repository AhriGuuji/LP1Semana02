using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //Adicionar os tipos de números existentes em C# e os seus mínimos e máximos
            sbyte sbMax = sbyte.MaxValue;
            sbyte sbMin = sbyte.MinValue;

            byte bMax = byte.MaxValue;
            byte bMin = byte.MinValue;

            double dbMin = double.MinValue;
            double dbMax = double.MaxValue;

            float fMax = float.MaxValue;
            float fMin = float.MinValue;

            ulong ulMax = ulong.MaxValue;
            ulong ulMin = ulong.MinValue;

            long lMax = long.MaxValue;
            long lMin = long.MinValue;

            int iMax = int.MaxValue;
            int iMin = int.MinValue;

            uint uiMax = uint.MaxValue;
            uint uiMin = uint.MinValue;

            //Print dos valores
            Console.WriteLine($"{sbMax}\n{sbMin}\n{bMax}\n{bMin}\n{dbMax}\n{dbMin}\n{fMax}\n{fMin}\n{ulMax}\n{ulMin}\n{lMax}\n{lMin}\n{iMax}\n{iMin}\n{uiMax}\n{uiMin}");

            //Adicionar variaveis de infinitos e NaN
            double x = double.PositiveInfinity;
            double y = double.NegativeInfinity;

            float x1 = float.PositiveInfinity;
            float y1 = float.NegativeInfinity;

            float x2 = float.NaN;

            //Print dos valores
            Console.WriteLine($"{x}\n{y}\n{x1}\n{y1}\n{x2}");

            //Testar o OverFlow de uint
            uint oF = uint.MaxValue;
            uint sum = oF+1;
            Console.WriteLine(sum);

            //Testar o OverFlow de uint
            float infinityFlow = 2*float.MaxValue;
            float notChangeValue = float.MaxValue+1;
            Console.WriteLine($"{infinityFlow}\n{notChangeValue}");


            //Testar o UnderFlow de float
            float forUnder1, forUnder2;
            forUnder1 = forUnder2 = 10000.0f;
            Console.WriteLine(forUnder1 == forUnder2 + 0.0001f);
        }
    }
}
