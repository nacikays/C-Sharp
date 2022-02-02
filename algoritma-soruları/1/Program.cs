using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace algoritma_sorulari 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.

            Console.WriteLine("Bir Sayı Giriniz: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(b+" adet sayı giriniz: ");
            int[] dizi = new int[b+1];
            for (int i = 1; i<b+1; i++)
            {
                Console.WriteLine(i + ". sayı:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("********Çiftler********");
            for (int i=1; i<b+1; i++)
            {
                if(dizi[i]%2==0)
                {
                Console.WriteLine(dizi[i]);
                }
            }
        }
    }
}