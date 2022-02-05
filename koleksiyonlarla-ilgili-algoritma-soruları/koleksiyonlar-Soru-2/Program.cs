using System;
using System.Collections;
using System.Collections.Generic;

namespace koleksiyonlar_soru_2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Soru - 2: Klavyeden girilen 20 adet sayının en büyük 3 tanesi ve en küçük 3 tanesi bulan, her iki grubun kendi içerisinde ortalamalarını alan ve bu ortalamaları ve ortalama toplamlarını console'a yazdıran programı yazınız. (Array sınıfını kullanarak yazınız.)

            Console.WriteLine("20 Adet Sayı Giriniz:");
            ArrayList sayilar = new ArrayList();

            for (int i = 1; i <=20; i++)
            {
                Console.WriteLine(i+". Sayı Giriniz:");
                int a = Convert.ToInt32(Console.ReadLine());
                sayilar.Add(a);
            }

            sayilar.Sort();
            ArrayList enkucuk = sayilar.GetRange(0, 3);
            ArrayList enbüyük = sayilar.GetRange(17, 3);
            int toplamb=0;
            int toplamk=0;
            
            Console.WriteLine("****** En Küçük 3 Sayı *****");
            foreach (int item in enkucuk)
            {
                Console.WriteLine(item);
                toplamb+=item;
            }
            Console.WriteLine("****** En Büyük 3 Sayı *****");
            foreach (int item in enbüyük)
            {
                Console.WriteLine(item);
                toplamk+=item;
            }
            
            Console.WriteLine("Ortalama 3 Küçük Sayı: " + toplamk/3 );
            Console.WriteLine("Ortalama 3 büyük Sayı: " + toplamb/3 );


        }
    }
}

