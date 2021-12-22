using System;

namespace ufaknotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int hakSayisi = 3;

            while (true)
            {
                Console.WriteLine("Kullanıcı adınızı giriniz");
                string kullaniciAdi = Console.ReadLine();

                Console.WriteLine("Şifrenizi giriniz");
                string sifre = Console.ReadLine();

                if (kullaniciAdi=="berkay" && sifre=="123")
                {
                    Console.WriteLine("Hoşgeldiniz :)");
                    break;
                }
                else
                {
                    Console.WriteLine("Kullanıcı adınız veya şifreniz yanlış !");
                    if (hakSayisi>0)
                    {
                        hakSayisi -= 1;
                    }
                    if (hakSayisi==0)
                    {
                        Console.WriteLine("Hakkınız dolmuştur");
                        break;
                    }
                }

            }
            Console.ReadLine();

        }
    }
}
