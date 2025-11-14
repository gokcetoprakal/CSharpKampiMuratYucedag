using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Yazdirmaİslemleri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region WRITE WRITELINE READ READLINE
            /*
            Console.WriteLine("Merhaba Dünya");
            Console.Write("İsim girin:");
            string isim = Console.ReadLine();
            Console.WriteLine(isim);
            Console.Read();*/

            #endregion

            #region KARTVİZİT ÖRNEĞİ
            //Bilgi alma kısmı
            Console.WriteLine("Size uygun bir kartvizit çıkarabilmemiz için aşağıdaki boşluklara bilgilerinizi giriniz.");
            Console.Write("İsim:");
            string isim = Console.ReadLine();
            Console.Write("Soyisim:");
            string soyisim = Console.ReadLine();
            Console.Write("Departman:");
            string departman = Console.ReadLine();
            Console.Write("Unvan:");
            string unvan = Console.ReadLine();
            Console.Write("Telefon Numarası:");
            string telno = Console.ReadLine();
            Console.Clear();
            //Kartvizit kısmı

            Console.WriteLine(isim.ToUpper()+ " " + soyisim.ToUpper());
            Console.WriteLine(" ");
            Console.WriteLine(unvan);
            Console.WriteLine("--------------------------");
            Console.WriteLine($"Departman: {departman}");
            Console.WriteLine($"Telefon Numarası: {telno}");
            Console.WriteLine("--------------------------");
            #endregion

        }
    }
}
