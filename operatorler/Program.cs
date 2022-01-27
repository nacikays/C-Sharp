using System;

namespace operatorler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Atama ve işlemli Atama

            int x = 3;
            int y = 3; 

            y=y+2;
            Console.WriteLine(y);
            y+=2;
            Console.WriteLine(y);
            y/=1;
            Console.WriteLine(y);
            y*=2;
            Console.WriteLine(x);

            Console.WriteLine("*******Mantıksal Opertörler*******");
            //Mantıksal Operatörler
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if (isSuccess && isCompleted){
                Console.WriteLine("Perfect!");
            }
              if (isSuccess || isCompleted){
                Console.WriteLine("Great!");
            }
              if (isSuccess && !isCompleted){
                Console.WriteLine("Fine");
            }
            
            Console.WriteLine("*******İlişkisel Opertörler*******");
            //İlişkisel Operatörler
            // <, >, <=, >=, ==, !=
            
            int a = 4;
            int b = 3;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);

            sonuc = a>b;
            Console.WriteLine(sonuc);

            sonuc = a>=b;
            Console.WriteLine(sonuc);

            sonuc = a<=b;
            Console.WriteLine(sonuc);

            sonuc = a==b;
            Console.WriteLine(sonuc);

            sonuc = a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("*******Aritmatiksel Opertörler*******");
            //Aritmatiksel Operatörler
            // +,-,*,/

            int sayi1 = 10;
            int sayi2 = 5;

            int sonuc1 = sayi1/sayi2;
            Console.WriteLine(sonuc1);

            sonuc1 = sayi1*sayi2;
            Console.WriteLine(sonuc1);
            
            sonuc1 = sayi1++;
            Console.WriteLine(sonuc1);

            // % : Mod alır
            int sonuc2 = 100 % 2;
            Console.WriteLine(sonuc2);

        }
    }
}