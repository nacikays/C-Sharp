using System;

namespace kurucu_metotlar
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

            Console.WriteLine("********** Çalışan 1 **********");
            Calisan calisan1 = new Calisan("Naci", "Kaysı",12345678,"Bilgi işlem");
            calisan1.CalisanBilgileri();



            Console.WriteLine("********** Çalışan 2 **********");
            Calisan calisan2 = new Calisan("Ahmet", "Arda",87654321,"İnsan Kaynakları");
            calisan2.CalisanBilgileri();
            
            Console.WriteLine("********** Çalışan 3 **********");
            Calisan calisan3 = new Calisan("Ali", "Veli",0,"");
            calisan3.CalisanBilgileri();



        }

        class Calisan
        {
            public string Ad;
            public string Soyad;
            public int No;
            public string Departman;

            public Calisan(string ad, string soyad, int no, string departman)
            {
                this.Ad = ad;
                this.Soyad= soyad;
                this.No=no;
                this.Departman=departman;
            }

            public void CalisanBilgileri()
            {
                Console.WriteLine("Çalışanın  Adı:{0}", Ad);
                Console.WriteLine("Çalışanın Soyadı:{0}", Soyad);
                Console.WriteLine("Çalışanın Numarası:{0}", No);
                Console.WriteLine("Çalışan Departmanı:{0}", Departman);
            }
        }


    }
}