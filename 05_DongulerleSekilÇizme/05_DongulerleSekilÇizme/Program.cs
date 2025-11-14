using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_DongulerleSekilÇizme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ŞEKİL ÇİZME UYGULAMASI
            Console.WriteLine("Bu uygulama seçtiğiniz şekli istediğiniz uzunlukta '*' karakteriyle çizmenize yarar.");
            Console.WriteLine("Çizebileceğiniz şekillerin harf kodları aşağıda verilmiştir.");
            Console.WriteLine("1- Dik Üçgen");
            Console.WriteLine("2-Kare");
            Console.WriteLine("3-Dikdörtgen");
            Console.WriteLine("4- Piramit");
            Console.WriteLine("5- Baklava");
            Console.WriteLine("Çıkış yapmak için ");
            Console.Write("Çizmek istediğiniz şeklin kodunu girin:");
            int kod = int.Parse(Console.ReadLine());
            switch (kod) {
                case 1: //dik üçgen
                    Console.Write("Şeklin boyutunu girin:");
                    int boyut1 = int.Parse(Console.ReadLine());

                    for (int i = 1; i <= boyut1; i++)
                    {
                        for (int j = 1; j <= i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2: //kare
                    Console.Write("Şeklin boyutunu girin:");
                    int boyut2 = int.Parse(Console.ReadLine());
                    for (int i = 1; i<= boyut2; i++)
                    {
                        for (int j = 1; j <= boyut2; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;
                case 3: // dikdörtgen
                    Console.Write("Şeklin enini girin: ");
                    int en = int.Parse(Console.ReadLine());
                    Console.Write("Şeklin boyunun girin: ");
                    int boy = int.Parse(Console.ReadLine());
                    for (int i = 1; i<= boy; i++)
                    {
                        for (int j = 1;j<= en; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    break;

                case 4: //piramit
                    Console.Write("Piramitin taban uzunluğunu seçiniz: ");
                    int taban = int.Parse(Console.ReadLine());
                    Console.Write("Piramitin yüksekliğini seçiniz: ");
                    int yukseklik = int.Parse(Console.ReadLine());
                    for (int i = 1; i <= yukseklik; i++) 
                    {
                        int bosluk = (taban - (taban * i / yukseklik)) / 2;
                        for (int j = 1; j <= bosluk; j++)
                        {
                            Console.Write(" ");
                        }

                        int yildiz = taban * i / yukseklik;
                        if (yildiz % 2 == 0) yildiz++;
                        for (int k = 1; k <= yildiz; k++)
                        {
                            Console.Write("*");
                        }

                        Console.WriteLine();
                    }
                    break;
                case 5://baklava
                    Console.Write("Baklavanın taban uzunluğunu seçiniz: ");
                    int tabanBaklava = int.Parse(Console.ReadLine());

                    Console.Write("Baklavanın yüksekliğini seçiniz: ");
                    int yukseklikBaklava = int.Parse(Console.ReadLine());

                    //Üst dilim
                    for (int i = 1; i <= yukseklikBaklava; i++)
                    {
                        int bosluk = (tabanBaklava - (tabanBaklava * i / yukseklikBaklava)) / 2;
                        for (int j = 1; j <= bosluk; j++)
                            Console.Write(" ");

                        int yildiz = tabanBaklava * i / yukseklikBaklava;
                        if (yildiz % 2 == 0) yildiz++;
                        for (int k = 1; k <= yildiz; k++)
                            Console.Write("*");

                        Console.WriteLine();
                    }
                    //Alt dilim
                    for (int i = yukseklikBaklava - 1; i >= 1; i--)
                    {
                        int bosluk = (tabanBaklava - (tabanBaklava * i / yukseklikBaklava)) / 2;
                        for (int j = 1; j <= bosluk; j++)
                            Console.Write(" ");

                        int yildiz = tabanBaklava * i / yukseklikBaklava;
                        if (yildiz % 2 == 0) yildiz++;
                        for (int k = 1; k <= yildiz; k++)
                            Console.Write("*");

                        Console.WriteLine();
                    }
                    break;
                default:
                    Console.WriteLine("Şekil kodları 1 ile 5 arasındadır. Lütfen geçerli bir kod çiziniz.");
                    break;
            }
        }
    }
}
