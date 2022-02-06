using System;

namespace sınıf_kavramı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Söz Dizimi
            // class SinifAdi
            // {    
            //      [Erişim Belirleyici] [Veri Tipi] ÖzellikAdi;
            //      [Erişim Belirleyici] [Geri DÖnüş Tipi] MetotAdi ([Parametre Listesi])
            //      {
            //          Metot Komutları
            //      }
            // } 

            //Erişim Belirleyiciler 
            // * public
            // * private
            // * Internal
            // * Protected

            Calisan calisan1 = new Calisan();
            calisan1.Ad="Naci";
            calisan1.Soyad ="Kaysı";
            calisan1.No=12345678;
            calisan1.Departman="Bilgi İşlem";

            calisan1.CalisanBilgileri();
            
            Console.WriteLine("************************");
            Calisan calisan2 = new Calisan();
            calisan2.Ad="Ahmet";
            calisan2.Soyad ="Arda";
            calisan2.No=87654321;
            calisan2.Departman="İnsan Kaynakları";

            calisan2.CalisanBilgileri();

        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışanın Adı:{0}",Ad);
                Console.WriteLine("Çalışanın Soyad:{0}",Soyad);
                Console.WriteLine("Çalışanın Numarası:{0}", No);
                Console.WriteLine("Çalışanın Departmanı:{0}", Departman);
            }
        }
    }
}