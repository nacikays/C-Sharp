using System;

namespace algoritma_soruları
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
            
            Console.WriteLine("Bir Sayı Giriniz: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n+" adet kelime giriniz: ");

            string[] dizi = new string[n+1];
            for (int i = 1; i<n+1; i++)
            {
                Console.WriteLine(i + ". kelime:");
                dizi[i] =Console.ReadLine();
            }
            
            Console.WriteLine("********Girilen kelimeleri sondan başa doğru yazdırma********");
            while(n!=0)
            {
                if(n!=0)
                {
                    Console.WriteLine(dizi[n]);
                    n--;
                }
            }
        }
    }
}