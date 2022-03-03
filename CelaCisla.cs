using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metody04_08GitHub
{
    class CelaCisla
    {
        public static double Mocnina(double zaklad, int exponent)
        {
            double vysledek = 1;

            if (exponent < 0)
            {
                for (int i = 1; i <= exponent * (-1); ++i)
                {
                    vysledek /= zaklad;
                }
            }
            else
            {
                for (int i = 1; i <= exponent; i++)
                {
                    vysledek *= zaklad;
                }
            }
            return vysledek;
        }
    }
}
