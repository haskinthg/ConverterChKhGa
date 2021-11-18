using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTemperature
{
    public class ConvertationTemp
    {
        public static double FtoC(double F)
        {
            return Math.Round(((F - 32) / 1.8), 2, MidpointRounding.AwayFromZero);
        }

        public static double CtoF(double C)
        {
            return Math.Round((C * 1.8 + 32), 2, MidpointRounding.AwayFromZero);
        }
    }
}
