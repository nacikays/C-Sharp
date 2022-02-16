using System;

namespace ToDo_Uygulaması
{
    class Program
    {   
        public static int MenüYaz()
        {
            Console.WriteLine();
            Console.WriteLine("Lutfen yapmak istediginiz islemi secin");
            Console.WriteLine("************************************");
            Console.WriteLine("(1) Kart Eklemek");
            Console.WriteLine("(2) Kart Güncelleme");
            Console.WriteLine("(3) Kart Silmek");
            Console.WriteLine("(4) Kart Tasımak");
            Console.WriteLine("(5) Board Listelemek");
            Console.WriteLine("(6) Çıkış Yapmak");
            return int.Parse(Console.ReadLine());
        }
        static void Main(string[] args)
        {
            Board board = new Board();
            int input = MenüYaz();

            while (true)
            {
                switch (input)
                {
                    case 1: 
                        Console.WriteLine("Kart Ekleme Alanı");
                        board.KartEkle();
                        input = MenüYaz();
                        break;
                    case 2: 
                        Console.WriteLine("Kart Güncelleme Alanı");
                        board.KartGuncelle();
                        input = MenüYaz();
                        break;
                    case 3:
                        Console.WriteLine("Kart Silme Alanı");
                        board.KartSil();
                        input = MenüYaz();
                        break;
                    case 4: 
                        Console.WriteLine("Kart Silme Alanı");
                        board.KartTasi();
                        input = MenüYaz();
                        break;
                    case 5: 
                        Console.WriteLine("Kart Listeleme Alanı");
                        board.BoardListele();
                        input = MenüYaz();
                        break;
                    case 6:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Yanlış Tuşlama. Çıkış Yapılıyor.");
                        Environment.Exit(0);
                        break;
                }
            }            
        } 
    }
}