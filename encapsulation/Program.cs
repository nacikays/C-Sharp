using System;

namespace encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci();
            ogrenci.Isim="Naci";
            ogrenci.Soyisim="KAYSI";
            ogrenci.OgrenciNo=123;
            ogrenci.Sinif=4;
            ogrenci.OgrenciBilgileriniGetir();
            
            Console.WriteLine("-------------------------");
            Ogrenci ogrenci1 = new Ogrenci();
            ogrenci1.Isim="Ali";
            ogrenci1.Soyisim="Veli";
            ogrenci1.OgrenciNo=123;
            ogrenci1.Sinif=1;
            ogrenci1.SinifDusur();
            ogrenci1.OgrenciBilgileriniGetir();



        }
    }

    class Ogrenci
    {
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;


        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get => sinif; 
            set 
            {
                if(value<1)
                {
                    Console.WriteLine("Öğrenci Sınıfı 1 den Düşük Olamaz!");
                    sinif=1;
                }
                else{

                 sinif = value; }
            }   
        }

        public Ogrenci(string ısim, string soyisim, int ogrenciNo, int sinif)
        {
            Isim = isim;
            Soyisim = soyisim;
            OgrenciNo = ogrenciNo;
            Sinif = sinif;
        }

        public Ogrenci(){}

        public void OgrenciBilgileriniGetir()
        {
            Console.WriteLine("******* Öğrenci Bilgileri ********* ");
            Console.WriteLine("Öğrenci Adı    :{0}", this.Isim);
            Console.WriteLine("Öğrenci Soyadı :{0}", this.Soyisim);
            Console.WriteLine("Öğrenci No     :{0}", this.OgrenciNo);
            Console.WriteLine("Öğrenci Sınıfı :{0}", this.Sinif);
        }

        public void SinifAtlat()
        {
            this.Sinif = this.Sinif +1;
        }

        public void SinifDusur()
        {
            this.Sinif = this.Sinif -1;
        }



    }
}