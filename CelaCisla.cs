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
        public static int Faktorial(int zaklad)
        {
            if (zaklad < 0) throw new ArgumentException("Faktoriál nelze spočítat");
            else
            {
                int vysledek = 1;
                for (int i = 1; i <= zaklad; ++i)
                {
                    vysledek *= i;
                }

                return vysledek;
            }

        }
        public static int CifLichSoucet(int cislo)
        {
            int Soucifer = 0;
            while (cislo != 0)
            {
                if ((cislo % 10) % 2 != 0)
                {
                    Soucifer += cislo % 10;
                }
                cislo /= 10;
            }
            return Soucifer;
        }
        public static bool JePrvocislo(int cislo)
        {
            bool jePrvo = true;
            if (cislo == 1 || cislo == 2) jePrvo = true;
            else
            {
                for (int i = 2; i <= cislo / 2 && jePrvo; ++i)
                {
                    if (cislo % i == 0) jePrvo = false;
                }
            }
            return jePrvo;
        }
        public static int PocetDeliteluSud(int cislo)
        {
            int pocSudych = 0;
            for (int i = 1; i <= cislo / 2; ++i)
            {
                if (cislo % i == 0) pocSudych++;
            }
            return pocSudych;
        }
    }
}
