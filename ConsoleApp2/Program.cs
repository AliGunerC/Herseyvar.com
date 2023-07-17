using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Bu e-ticaret sitemiz, sanal market olsun. Yani hem gıda hem de elektronik ürünleri satabilecek bir portal. Site kullanıcısı, 
              satın almak istediği ürünü sepete ekler. Siparişi vermeden önce, sepetteki tüm ürünlerin fiyatları toplanır ve ödenmesi gereken miktar belirlenir.  
              bu ürünlerin KDV oranları da farklı olacak ve elbette fiyat ona göre hesaplanacak.*/
            User user = new User();
            GirisSorgu grs = new GirisSorgu();
            Urunekle urunekle = new Urunekle();
            //giriş kısmı
            Console.WriteLine("HERŞEYVAR'A HOŞGELDİNİZ");
            Console.Write("Müşteri Girişi İçin 1 \n Satıcı Girişi İçin 2 \n Seçiminiz : ");
            string giris_secim = Console.ReadLine();
            if (giris_secim == "1")
            {
                Console.WriteLine("musteri");

            }
            else if (giris_secim == "2")
            {
               int basarili_giris_test = grs.girissorgu();
                if (basarili_giris_test == 1)
                {
                    Console.Write("Ürün Eklemek İçin 1 \nÜrün Kaldirmak İçin 2 \nÜrünleri Görmek İçin 3 \nSeçiminiz : ");
                    string Satici_islem = Console.ReadLine();
                    if (Satici_islem == "1")
                    {
                       
                         urunekle.UrunEkle();
                           
                    }
                    else if (Satici_islem == "3")
                    {
                        urunekle.urungoster();
                    }

                }
            }
            else
            {
                Console.WriteLine("hatalı tuşlama");
            }
            Console.ReadLine();

        }
    }
 
}
