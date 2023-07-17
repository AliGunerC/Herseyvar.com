using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class GirisSorgu
    {
        //List<Ogrenci> ogrenciler = new List<Ogrenci>();

        //// INSTANCE => Örneklem
        //Ogrenci o = new Ogrenci();
        //o.ad = "Altan";
        //o.soyad = "Demirci";
        //o.yas = 33;
        public int girissorgu()
        {
            int sorgu = 0;
            List<User> users = new List<User>();
            User user = new User();
            user.Username = "1";
            user.Password = "1";
            users.Add(user);
            

            Console.WriteLine("Username giriniz");
            string girs_username = Console.ReadLine();
            Console.WriteLine("password giriniz");
            string giris_password = Console.ReadLine();
            if (girs_username == user.Username && giris_password == user.Password)
            {
                sorgu++;
                Console.WriteLine("giriş başarılı");

                foreach (User item in users)
                {
                    Console.WriteLine(item.Username);
                    Console.WriteLine(item.Password);
                }
            }
            else
            {
                Console.WriteLine("username yada password hatalı");
            }
            return sorgu;
        }
    }
}
