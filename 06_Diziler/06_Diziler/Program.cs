using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Diziler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DİZİLER
            /*int[] rakamlar = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(int rak in rakamlar)
            {
                Console.WriteLine(rak);
            }
            int toplam = 0;
            foreach (int rak in rakamlar)
            {
                toplam += rak;
            }
            Console.WriteLine(toplam);
            double ort = toplam/rakamlar.Length;
            Console.WriteLine(ort);*/
            #endregion
            #region ORTALAMA HANGİSİNE YAKIN?
            int[] sayılar = new int[5];
            for (int i = 0; i < sayılar.Length; i++) {
                Console.Write($"{i + 1}. sayıyı girin: ");
                sayılar[i] = int.Parse(Console.ReadLine());
            }
            int toplam = 0;
            foreach (int say in sayılar) {
                toplam += say;
            }
            Console.WriteLine(toplam);
            double ortalama = toplam/sayılar.Length;
            Console.WriteLine(ortalama);

            int enYakin = sayılar[0];
            double minFark = Math.Abs(sayılar[0] - ortalama);

            for (int i = 1; i < sayılar.Length; i++)
            {
                double fark = Math.Abs(sayılar[i] - ortalama);
                if (fark < minFark)
                {
                    minFark = fark;
                    enYakin = sayılar[i];
                }
            }

            Console.WriteLine("Ortalama en yakın sayı: " + enYakin);
            #endregion
        }
    }
}
