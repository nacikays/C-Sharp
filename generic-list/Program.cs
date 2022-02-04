using System;
using System.Collections.Generic;

namespace generic_list
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<T> class
            //System.Collections.Generic
            // T-> object türündedir.

            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(10);
            sayiListesi.Add(4);
            sayiListesi.Add(5);
            sayiListesi.Add(92);
            sayiListesi.Add(34);    

            List<string> renkListesi =  new List<string>();
            renkListesi.Add("Kırmızı");
            renkListesi.Add("Mavi");
            renkListesi.Add("Turuncu");
            renkListesi.Add("Sarı");
            renkListesi.Add("Yeşil");

            //Count
            Console.WriteLine(renkListesi.Count);
            Console.WriteLine(sayiListesi.Count);


            //Listeden Eleman Çıkarmak
            sayiListesi.Remove(4);
            renkListesi.Remove("Yeşil");

            sayiListesi.RemoveAt(0);
            renkListesi.RemoveAt(1);

            sayiListesi.ForEach(sayi=>Console.WriteLine(sayi));
            renkListesi.ForEach(renk=>Console.WriteLine(renk));

            //Liste İçerisinde Arama
            if(sayiListesi.Contains(10))
                Console.WriteLine("10 Liste İçersinden Bulundu!");

            //Eleman ile index'e erişme 
            Console.WriteLine(renkListesi.BinarySearch("Sarı"));
            
            //Diziyi List'e çevirme
            string[] hayvanlar ={"Kedi","Köpek","Kuş"};
            List<string> hayvanListesi = new List<string>(hayvanlar);

            //Liste Temizleme
            hayvanListesi.Clear();

            //List içersinde nesne tutmak
            List<Kullanıcılar>KullanıcıListesi = new List<Kullanıcılar>();

            Kullanıcılar kullanıcı1 = new Kullanıcılar();
            kullanıcı1.Isim="Naci";
            kullanıcı1.Soyisim="Kaysı";
            kullanıcı1.Yas=123;

            Kullanıcılar kullanıcı2 = new Kullanıcılar();
            kullanıcı2.Isim="Özcan";
            kullanıcı2.Soyisim="Çalışkan";
            kullanıcı2.Yas=124;

            KullanıcıListesi.Add(kullanıcı1);
            KullanıcıListesi.Add(kullanıcı2);

            List<Kullanıcılar> yeniListe = new List<Kullanıcılar>();
            yeniListe.Add(new Kullanıcılar(){
                    Isim="Yunus",
                    Soyisim="Kaysı",
                    Yas=125
            });

            foreach (var kullanıcı in KullanıcıListesi)
            {
                Console.WriteLine("Kullanıcı Adı:" + kullanıcı.Isim);
                Console.WriteLine("Kullanıcı Soyadı:" + kullanıcı.Soyisim);
                Console.WriteLine("Kullanıcı Yaş:" + kullanıcı.Yas);
            }

            yeniListe.Clear();
            

        }
    }
}


public class Kullanıcılar{
    private string isim;

    private string soyisim;

    private int yas;

    public string Isim {get => isim; set=>isim=value;}
    public string Soyisim{get => soyisim; set=> soyisim=value;}
    public int Yas{get => yas; set=> yas=value;}
}