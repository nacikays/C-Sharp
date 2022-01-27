using System;

namespace donguler_while_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1 den başlayıp konsola girilen sayıya kadar ortalama hesaplayan program
            Console.WriteLine("Lütfen Bir Sayı Giriniz:");
            int sayi = int.Parse(Console.ReadLine());
            int toplam=0;
            int sayac=1;

            while (sayac<=sayi)
            {
                toplam += sayac;
                sayac++;
            }
            Console.WriteLine(toplam/sayi);
            // a dan z ye kadar olan tüm harfleri ekrana yazdır

            char character='a';
            while (character <'z')
            {
                Console.Write(character);
                character++;
            }

            //Foreach
            Console.WriteLine("\n"+"****Foreach****");
            string[] arabalar = {"BMW", "Ford", "Toyota", "Nissan"};
            foreach (var araba in arabalar){
                Console.WriteLine(araba);
            }
        }
    }
}