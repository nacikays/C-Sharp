using System;
using System.Collections.Generic; //Array List

namespace rehber_proje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Rehber> RehberListesi = new List<Rehber>(); //RehberListesi Oluşturuldu 
            RehberListesi.Add(new Rehber ("Naci", "Kaysı", "5124789694"));
            RehberListesi.Add(new Rehber ("Mahmut","Elma","7989356261"));
            RehberListesi.Add(new Rehber ("Hulki","Taş","1236585217"));
            RehberListesi.Add(new Rehber ("Ali","Kara","6565656532"));
            RehberListesi.Add(new Rehber ("Ahmet","Kurt","5923555545"));

            RehberYönetimPaneli rehberYönetimPaneli = new RehberYönetimPaneli(); //Eklenecek Yeni Kişi İçin Ortamı Oluşturduk 


            int ekranoku = 0;
            while(ekranoku != 6)
            {
                Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz: ");
                Console.WriteLine("******************************************");
                Console.WriteLine("(1) Yeni Numara Kaydetme");
                Console.WriteLine("(2) Varolan Numarayı Silme");
                Console.WriteLine("(3) Varolan Numarayı Güncelleme");
                Console.WriteLine("(4) Rehberi Listeleme");
                Console.WriteLine("(5) Rehberde Arama Yapma");
                Console.WriteLine("(6) Consoldan Çıkış");
                ekranoku = Convert.ToInt16(Console.ReadLine());

                if(ekranoku==1){
                    Console.WriteLine("---Yeni Numara Kaydetme Alanı---");
                    rehberYönetimPaneli.RehbereEkleme(RehberListesi);
                }
                
                else if(ekranoku==2){
                    Console.WriteLine("---Varolan Numarayı Silme Alanı---");
                    rehberYönetimPaneli.RehberdenSilme(RehberListesi);
                }
                
                else if(ekranoku==3){
                    Console.WriteLine("---Varolan Numarayı Güncelleme Alanı---");
                    rehberYönetimPaneli.KayıtGüncelleme(RehberListesi);
                }
                
                else if(ekranoku==4){
                    Console.WriteLine("---Rehberi Listeleme Alanı---");
                    rehberYönetimPaneli.KisileriListele(RehberListesi);                   
                }
                
                else if(ekranoku==5){
                    Console.WriteLine("---Rehberde Arama Yapma Alanı---");
                    rehberYönetimPaneli.KisiArama(RehberListesi);
                }

                else if(ekranoku==6){
                    
                    Console.WriteLine("Çıkış Tuşlandı \nSonlandırılıyor...");
                    break;
                }
            }
        }
    }
}