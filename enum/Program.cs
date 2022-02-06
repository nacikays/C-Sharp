using System;

namespace enum_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Çarşamba);
            Console.WriteLine((int)Gunler.Cumartesi);

            int Sıcaklık = 32;
        
            if(Sıcaklık<=(int)HavaSıcaklıgı.Normal)
                    Console.WriteLine("Dışarıya Çıkmak İçin Havanın Biraz Daha Isınmasını Bekle!");
            else if(Sıcaklık>=(int)HavaSıcaklıgı.CokSıcak)
                Console.WriteLine("Dışarı Çıkmak İçin Sıcak Bir Gün!");
            else if(Sıcaklık<(int)HavaSıcaklıgı.CokSıcak && Sıcaklık>=(int)HavaSıcaklıgı.Normal)
                Console.WriteLine("Dışarı Çıkalım");
        }           
    }

    enum Gunler{
        Pazartesi =1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma=23,
        Cumartesi,
        Pazar
    }

    enum HavaSıcaklıgı{
        Soguk = 5,
        Normal=20,
        Sıcak =25,
        CokSıcak=30

    }
}