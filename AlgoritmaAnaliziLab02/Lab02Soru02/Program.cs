using System;

namespace Lab02Soru02
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[] { 65, 22, 73, 78, 24, 3, 77, 23, 84, 42 };//Soru 2 burada yapıldı.
            //Soru 3 burada başlıyor.
            int temp = dizi[0];
            dizi[0] = dizi[dizi.Length - 1];
            dizi[dizi.Length - 1] = temp;
            //Soru 3 burada bitiyor.


            Swap(dizi, 0, 5);//4. sorunun fonksiyonu


            BubbleSort(dizi);//5. sorunun fonksiyonu
            foreach (var item in dizi)
            {
                Console.Write(item + ", ");
            }
        }

        private static void BubbleSort(int[] dizi)//5. sorunun fonksiyonu
        {
            int controllerDegisken = 0;

            while (controllerDegisken != dizi.Length - 1)
            {
                controllerDegisken = 0;

                for (int i = dizi.Length - 1; i > 0; i--)
                {

                    if (dizi[i] < dizi[i - 1])
                    {
                        Swap(dizi, i, i - 1);

                    }
                    else
                    {
                        controllerDegisken += 1;
                    }
                }
            }

        }

        private static void Swap(int[] dizi, int v1, int v2)//4. sorunun fonksiyonu
        {
            int temporary = dizi[v1];
            dizi[v1] = dizi[v2];
            dizi[v2] = temporary;
        }
    }
}
