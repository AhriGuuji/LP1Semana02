using System;

namespace ValoresEspeciais
{
    public class Program
    {
        private static void Main(string[] args)
        {
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

            Console.WriteLine($"{sbMax}\n{sbMin}\n{bMax}\n{bMin}\n{dbMax}\n{dbMin}\n{fMax}\n{fMin}\n{ulMax}\n{ulMin}\n{lMax}\n{lMin}\n{iMax}\n{iMin}\n{uiMax}\n{uiMin}");
        }
    }
}
