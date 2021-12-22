using System;

namespace miniatm2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atm'ye Hoşgeldiniz");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz");
            string secim = Console.ReadLine();

            int bakiye = 1000;

            if (secim=="1")
            {
                Console.WriteLine("Bakiyeniz :" +bakiye);
            }
            else if (secim=="2")
            {
                Console.WriteLine("Çekilecek tutarı giriniz");
                int cekilecekTutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Kalan bakiyeniz :" + (bakiye - cekilecekTutar));
                Console.ReadLine();
            }
            else if (secim == "3") 
            {
                Console.WriteLine("Yatırılacak tutarı giriniz");
                int yatirilacakTutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz :"+(bakiye+yatirilacakTutar));
                Console.ReadLine();           
            }
            else if (secim=="Çıkış")
            {
                Console.WriteLine("Çıkış yapılıyor");
                Console.WriteLine("İyi günler dileriz");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen bir işlem seçiniz");
            }




        }
    }
}
