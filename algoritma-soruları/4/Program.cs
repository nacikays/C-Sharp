using System;

namespace algoritma_soruları
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın.

            Console.WriteLine("Lütfen Bir Cümle Yazınız:");
            string metin = Console.ReadLine();
            string[] kelimeler = metin.Split(' ');
            Console.WriteLine("Kelime Sayısı :"+kelimeler.Length);
            Console.WriteLine("Harf Sayısı: "+ ((metin.Length)-(kelimeler.Length-1)));
        }
    }
}