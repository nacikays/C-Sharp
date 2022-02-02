using System;

namespace algoritma_sorulari
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
            Console.WriteLine("Lütfen 2 Adet Sayı Giriniz!");
            Console.WriteLine("1.Sayı:");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("2.Sayı:");
            int m = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(n+" adet sayı giriniz: ");
            int[] dizi = new int[n+1];
            for (int i = 1; i<n+1; i++)
            {
                Console.WriteLine(i + ". sayı:");
                dizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("********2.Sayıya Eşit Ya da Tam Bölünen Sayılar********");
            for (int i=1; i<n+1; i++)
            {
                if(dizi[i]%m==0 || dizi[i]==m)
                {
                Console.WriteLine(dizi[i]);
                }
            }


            
        }
    }
}