using System;

namespace hazir_metotlar_string
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz Csharp, Hoş Geldiniz!";
            string degisken2= "CSharp";

            //Length;  --> Karakter sayısını dödürür
            Console.WriteLine(degisken.Length); 

            //ToUpper, ToLower --> Küçük harfleri büyük yapar, tam tersi
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken,"Merhaba!"));

            //Compare ComparaTo --> ifadeleri karşılaştırır büyük küçük harf dizilimine göre 1 0 değerlerini dödürür
            Console.WriteLine(degisken.CompareTo(degisken2)); //0,1,-1
            Console.WriteLine(degisken.Compare(degisken,degisken2,true)); 
            Console.WriteLine(degisken.Compare(degisken,degisken2,false));

            //Contains  --> Var ise true yok is false
            Console.WriteLine(degisken.Contains(degisken2));
            Console.WriteLine(degisken.EndsWith("Hoş Geldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));  

            //IndexOf --> aranan char bulunursa dizide direk characteri döndürür bulunmazsa -1
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Naci"));
            Console.WriteLine(degisken.LastIndexOf("i")); 

            //Insert --> Eklenecek olan verinin numarası girilir sonrasında eklenecek şey yazılır.
            Console.WriteLine(degisken.Insert(0,"Merhaba!"));

            //PadLeft PadRight --> yazılan degerin boşluk vs bırakmak için kullanılır
                Console.WriteLine(degisken+degisken2.PadLeft(30));
                Console.WriteLine(degisken+degisken2.PadLeft(30, '*'));
                Console.WriteLine(degisken.PadRight(50) + degisken2);
                Console.WriteLine(degisken.PadRight(50, '-') + degisken2);

            //Remove --> belirtilen karakterden son karaktere kadar siler
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5,3));
            Console.WriteLine(degisken.Remove(0,1));

            //Replace --> Karakter değiltirilmesini sağlar
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split --> karaterleri temel alarak alt diziye böler.
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring --> Belirtilen karaterden başlar ve sona kadar devam eder.
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,6));


            








        }
    }
}