using System;

namespace miniatm
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atm ye hoşgeldiniz");
            Console.WriteLine("İşleminizi seçiniz");
            string secim = Console.ReadLine();

            int bakiye = 1000;

            if (secim == "1")
            {
                Console.WriteLine("Bakiyeniz  : " + bakiye);
            }
            else if (secim == "2")
            {
                Console.WriteLine("Çekmek istediğiniz tutarı giriniz");
                int cekilecekTutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kalan tutar : " + (bakiye - cekilecekTutar));
            }
            else if (secim == "3")
            {
                Console.WriteLine("Yatırmak istedğiniz tutarı giriniz");
                int yatiralacakTutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Yeni bakiyeniz : " + (bakiye + yatiralacakTutar));
            }
            else if (secim == "Çıkış")
            {
                Console.WriteLine("Çıkış yapılıyor");
                Console.WriteLine("İyi günler dileriz");
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir değer giriniz");
            }
        }
    }
}
