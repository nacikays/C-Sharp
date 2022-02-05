using System;
using System.Collections;
using System.Collections.Generic;


namespace koleksiyonlar_soru_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Soru - 1: Klavyeden girilen 20 adet pozitif sayının asal ve asal olmayan olarak 2 ayrı listeye atın. (ArrayList sınıfını kullanara yazınız.)
                -Negatif ve numeric olmayan girişleri engelleyin.
                -Her bir dizinin elemanlarını büyükten küçüğe olacak şekilde ekrana yazdırın.
                -Her iki dizinin eleman sayısını ve ortalamasını ekrana yazdırın.*/

            Console.WriteLine("20 Adet Sayı Giriniz:");
            
            ArrayList asalsayilar = new ArrayList();
            int asal_sayisi=0;
            int asal_toplam=0;
            
            ArrayList asalolmayansayilar = new ArrayList();
            int asalolmayan_sayisi=0;
            int asalolmayan_toplam=0;
        
            for (int i = 1; i <=20; i++)
            {
                Console.WriteLine(i+". Sayıyı Giriniz:");
                int a = Convert.ToInt32(Console.ReadLine());
                try
                {
                    if (a<=0)
                    {
                        Console.WriteLine("Lütfen Pozitif Sayı Giriniz!");
                        i--;
                    }
                    else
                    {
                        if (asalmi(a)){
                            asalsayilar.Add(a);
                            asal_sayisi+=1;
                            asal_toplam+=a;
                        }
                        else{
                            asalolmayansayilar.Add(a);
                            asalolmayan_sayisi+=1;
                            asalolmayan_toplam+=a;
                        }
                    }
                }
                catch(Exception)
                {
                    Console.WriteLine("Geçersiz giriş: ");
                    i--;
                }
        }

        
            
            Console.WriteLine("******* Asal Olan Sayılar *********");
            asalsayilar.Sort();
            foreach (var item in asalsayilar)
            {
                Console.WriteLine(item);
            }  
            
            Console.WriteLine("Asal Sayı Adedi: " + asal_sayisi +  " \nAsal Sayılar Toplamı: " + asal_toplam + "\nOrtalama: "+ asal_toplam/asal_sayisi);

            Console.WriteLine("******* Asal Olmayan Sayılar *********");
            asalolmayansayilar.Sort();
            foreach (var item in asalolmayansayilar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal Olmayan Sayı Adedi: " + asalolmayan_sayisi +  "\nAsal Olmayan Sayılar Toplamı: " + asalolmayan_toplam + "\nOrtalama: "+ asalolmayan_toplam/asalolmayan_sayisi);
    }


        public static bool asalmi(int sayi)
        {
            bool durum = false;
            int kontrol = 0;
            
            for (int i = 2; i < sayi; i++)
            {
                
                if (sayi % i == 0) 
                {
                    kontrol = 1;
                    break;
                }
            }
            if (kontrol == 1){
                durum = false;
            }
            else{
                durum = true;
            } 
            return durum;
        } 
    }
}
