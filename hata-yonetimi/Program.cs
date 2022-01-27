using System;

namespace hata_yonetimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try{
                Console.WriteLine("Bir Sayı Giriniz:");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş Olduğunuz Sayı:"+ sayi );

            }
            catch(Exception ex){
                Console.WriteLine("Hata:"+ ex.Message.ToString());
            }

            finally{
                Console.Write("işlem Tamamlandı");
            }

            //Örnek 2
            Console.WriteLine("Örnek 2");
            try{
                Console.WriteLine("Bir Sayı Giriniz:");
                //int a = int.Parse(null);
                //int a = int.Parse("test");
                int a = int.Parse("-20000000000000");
            }


            catch(ArgumentException ex){
                Console.WriteLine("Veri Tipi Uygun Değil");
                Console.WriteLine(ex);
            }
            catch(FormatException ex){
                Console.WriteLine("Veri Tipi Uygun Değil");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex){
                Console.WriteLine("Veri Tipi Uygun Değil");
                Console.WriteLine(ex);
            }
            

            finally{
                Console.Write("işlem Tamamlandı");
            }




        }
    }
}