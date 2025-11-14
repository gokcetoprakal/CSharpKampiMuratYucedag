using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DongulerForWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region DÖNGÜLER
            #region FOR
            /*Console.Write("Herhangi bir kelime girin: ");
            string isim = Console.ReadLine();
            for (int i = 0; i < isim.Length; i++) {
                Console.WriteLine("Selam");
            }*/
            #endregion

            #region WHILE - DOWHILE
            /*int i = 10;
            while (i > 0)
            {
                i--;
                Console.WriteLine(i);
            }
            do
            { 
                Console.WriteLine(i);
                i--;
            } while (i > 0);*/
            #endregion

            #endregion

            #region SAYI TAHMİN OYUNU
            int sayi = 38;
            Console.WriteLine("0 ile 50 arasında bir sayı tahmin edin");
            for (int i = 0; i <= 10; i++)
            {
                Console.Write("Tahmininizi girin: ");
                int tahmin = int.Parse(Console.ReadLine());

                if (tahmin < sayi)
                {
                    Console.WriteLine("Daha büyük bir sayı deneyin.");
                }
                else if (tahmin > sayi)
                {
                    Console.WriteLine("Daha küçük bir sayı deneyin.");
                }
                else
                {
                    Console.WriteLine($"Tebrikler! {i+1}. tahmininizde doğru sayıyı buldunuz.");
                    break;
                }

                if (i == 10)
                {
                    Console.WriteLine($"Tahmin hakkınız bitti. Doğru sayı: {sayi}");
                }
            }
            #endregion
        }
    }
}
