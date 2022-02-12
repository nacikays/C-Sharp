using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rehber_proje1
{
    class RehberYönetimPaneli
    {
        public void RehbereEkleme(List<Rehber> RehberListesi)//"RehbereEkleme" kelimesi kullanılarak diğer alanlardan buraya erişim sağlanılacak. 
        {
            Console.WriteLine("Numara Kaydetmek İçin Lütfen; \nİsim Giriniz:");
            String isim = Console.ReadLine();
            
            Console.WriteLine("Soyisim Giriniz:");
            String soyisim = Console.ReadLine();

            Console.WriteLine("Telefon Numarası Giriniz:");
            String tel = Console.ReadLine();

            Rehber YeniKisi = new Rehber(isim,soyisim,tel);
            RehberListesi.Add(YeniKisi);

            Console.WriteLine("Kişi Rehbere Eklendi...");
        }


        public void RehberdenSilme(List <Rehber> RehberListesi)//"RehberdenSilme" kelimesi kullanılarak diğer alanlardan buraya erişim sağlanılacak. 
        {
            Console.WriteLine("Silmek İstediğiniz Kişinin Adını ve Soyadını Girmelisiniz!\nİsim Giriniz:");
            String isim = Console.ReadLine();
            
            Console.WriteLine("Soyisim Giriniz:");
            String soyisim = Console.ReadLine();


            int kontrol = 0;
            foreach (var item in RehberListesi)
            {
                if(item.Ad == isim || item.Soyad ==soyisim)
                {
                    kontrol++;//bu şekilde girilen kişinin olup olmadığını kontrol ettik
                }
            }

            if(kontrol==1){
                Console.WriteLine(isim+" "+soyisim+" Rehberden Silinmek Üzere Onaylıyor musunuz? y/n" );
                char secim = Convert.ToChar(Console.ReadLine());
                if(secim == 'y')
                {
                    foreach (var item in RehberListesi)
                    {
                        if(item.Ad==isim || item.Soyad==soyisim)
                        {
                            RehberListesi.Remove(item);
                            Console.WriteLine(item.Ad +" "+ item.Soyad + " Kişi Rehberden Silinmiştir");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Silme İşlemi Sonlandırıldı.");
                }
            }
            else
            {
                Console.WriteLine("Aradığınız Kişi Listede Bulunamadı... Lütfen Bir Seçim Yapınız!");
                Console.WriteLine("* Silme işlemini sonlandırmak için: (1) ");
                Console.WriteLine("* Yeniden denemek için: (2) ");

                int secim = Convert.ToInt16(Console.ReadLine());
                if(secim == 2)
                {
                    RehberdenSilme(RehberListesi);
                }
                else
                {
                    Console.WriteLine("Silme İşlemi Sonlandırıldı");
                }
            }
        }



        public void KayıtGüncelleme(List <Rehber> RehberListesi)//KayıtGüncelleme Kelimesi Kullanılarak Diğer Alanlardan Buraya Erişim Sağlanacak
        {
            Console.WriteLine("Numarasını Güncellemek İstediğiniz Kişinin Adını ve Soyadını Girmelisiniz!\nİsim Giriniz:");
            String isim = Console.ReadLine();
            
            Console.WriteLine("Soyisim Giriniz:");
            String soyisim = Console.ReadLine();
            
            int kontrol=0;
            foreach (var item in RehberListesi)
            {
                if(item.Ad==isim || item.Soyad==soyisim)
                {   
                    kontrol++;
                }
            }
            
            if(kontrol==1)
            {
                Console.WriteLine(isim+" "+soyisim+" Numarasını Değiştirmeyi Onaylıyor musunuz? y/n");
                char secim = Convert.ToChar(Console.ReadLine());
                if(secim=='y')
                {
                    foreach (var item in RehberListesi)
                    {
                        if(item.Ad==isim || item.Soyad==soyisim)
                        {
                            Console.WriteLine(isim+" "+ soyisim+" Kişisinin Yeni Numarasını Giriniz:");
                            string yeniNo = Console.ReadLine();
                            item.Numara=yeniNo;
                            Console.WriteLine(isim+" "+soyisim +" Numarası "+item.Numara+" Olarak Güncellenmiştir..");
                            break;
                        }
                    }
                }
                else{
                    Console.WriteLine("Güncelleme İşlemi Sonlandırılıyor");
                }
            }

            else
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız");

                Console.WriteLine("* Silme işlemini sonlandırmak için: (1) ");
                Console.WriteLine("* Yeniden denemek için: (2) ");      
                
                int secim = Convert.ToInt16(Console.ReadLine());
                if(secim==2)
                {
                    KayıtGüncelleme(RehberListesi);
                }
                else
                {
                    Console.WriteLine("Güncelleme İşlemi Sonlandırıldı..");
                }
            }
        }


        public void KisileriListele (List <Rehber> RehberListesi) //KisileriListele Kelimesi Kullanılarak Diğer Alanlardan Buraya Erişim Sağlanacak.
        {
           Console.WriteLine("Telefon Rehberi\n*********************");
           foreach (var item in RehberListesi)
           {
            Console.WriteLine("İsim            : "+item.Ad);
            Console.WriteLine("Soyisim         : "+item.Soyad);
            Console.WriteLine("Telefon Numarası: "+item.Numara);
            Console.WriteLine("-");              
           }
        }


        public void KisiArama (List <Rehber> RehberListesi)//KisiArama Kelimesi Kullanılarak Diğer Alanlardan Buraya Erişim Sağlanacak
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz.");
            Console.WriteLine("**************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int secim = Convert.ToInt16(Console.ReadLine());
            
            if(secim==1)
            {
                Console.WriteLine("Aranacak İsimi Giriniz: ");
                string isim = Console.ReadLine();
                
                Console.WriteLine("Aranacak Soyisimi Giriniz: ");
                string soyisim = Console.ReadLine();
                
                int kontrol = 0;
                foreach (var item in RehberListesi)
                {
                    if(item.Ad==isim || item.Soyad==soyisim)
                    {
                        kontrol++;
                    }
                }

                if(kontrol==1)
                {
                    foreach (var item in RehberListesi)
                    {
                        if(item.Ad==isim || item.Soyad==soyisim)
                        {
                            Console.WriteLine("İsim            : "+item.Ad);
                            Console.WriteLine("Soyisim         : "+item.Soyad);
                            Console.WriteLine("Telefon Numarası: "+item.Numara);
                            Console.WriteLine("-");
                            break;
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Kişi Bulunamadı.");
                }
            }

            else
            {   
                Console.WriteLine("Lütfen Aranacak Kişinin Numarasını Giriniz: ");
                string tel = Console.ReadLine();
               
                int kontrol=0;
                foreach (var item in RehberListesi)
                {
                    if(item.Numara == tel)
                    {
                        kontrol++;
                    }
                }

                if(kontrol==1)
                {
                    foreach (var item in RehberListesi)
                    {
                        if(item.Numara == tel)
                        {
                            Console.WriteLine("İsim            : "+item.Ad);
                            Console.WriteLine("Soyisim         : "+item.Soyad);
                            Console.WriteLine("Telefon Numarası: "+item.Numara);
                            Console.WriteLine("-");
                        }
                    }
                }

                else
                {
                    Console.WriteLine("Bu numara ve bu numaraya ait kişi bulunamadı.");
                }
            }
        }
    }
}
