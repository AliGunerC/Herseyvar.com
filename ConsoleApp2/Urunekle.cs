using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Urunekle
    {
        
        List<Urunler> uruns = new List<Urunler>();
        Urunler urn = new Urunler();
        int id_kayit = 0;
        public void UrunEkle()
        {
            
            

            Urunler urn = new Urunler();
            Console.WriteLine("Urun Adı Nedir?");
            urn.UrunAdi = Console.ReadLine();
            Console.WriteLine("Urun Fiyatı Nedir?");
            urn.UrunFiyat = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Urun Açıklaması Nedir?");
            urn.UrunAcıklama = Console.ReadLine();
            Console.WriteLine("Urunden Kaç Adet Mevcut?");
            urn.UrunStok = Convert.ToInt32(Console.ReadLine());
            urn.UrunId = id_kayit += 1;
            id_kayit += 1;
            uruns.Add(urn);

            
            Console.WriteLine("İşlem Başarılı");
        }
        public void urungoster()
        {
            Console.Clear();
            foreach (Urunler item in uruns)
            {
                Console.WriteLine(item.UrunAdi);
                Console.WriteLine(item.UrunFiyat);
                Console.WriteLine(item.UrunStok);
                Console.WriteLine(item.UrunId);
                Console.WriteLine(item.UrunAcıklama);

            }
            
        }





    }
}
