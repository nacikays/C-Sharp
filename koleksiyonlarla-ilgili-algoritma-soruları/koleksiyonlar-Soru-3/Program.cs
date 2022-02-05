using System;
using System.Collections;
using System.Linq;

namespace koleksiyonlar_soru_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Soru - 3: Klavyeden girilen cümle içerisindeki sesli harfleri bir dizi içerisinde saklayan ve dizinin elemanlarını sıralayan programı yazınız.

            Console.WriteLine("Bir Cümle Yazınız: ");
            string cümle = Console.ReadLine();
            string sesli = "aeıioöuü";
            Console.Write("Cümledeki Sesli Harfler: ");
            for (int i = 0; i < cümle.Length; i++)
            {
                if(sesli.Contains(cümle[i]))
                {
                    Console.Write(cümle[i]+" ");
                }
            }            
        }
    }
}