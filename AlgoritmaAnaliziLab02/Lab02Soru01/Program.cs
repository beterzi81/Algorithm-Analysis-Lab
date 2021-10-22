using System;

namespace Lab02Soru01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = -5;

            float sonuc = Power(a, -2);
            Console.WriteLine(a + " sayısının istediğiniz sonucu:  " + sonuc);
        }

        private static float Power(int a, int v)
        {
            float sonuc = a;
            float ilkA = a;
            if (v == 0)
            {
                return 1;
            }
            else if (v < 0)
            {
                int vMutlak = -v;
                ilkA = 1 / ilkA;
                int i = 0;

                do
                {
                    sonuc = ilkA * sonuc;
                    i++;
                } while (i <= vMutlak);

                return sonuc;
            }
            else
            {
                for (int i = 1; i < v; i++)
                {
                    sonuc = ilkA * sonuc;
                }
                return sonuc;
            }
        }
    }
}
