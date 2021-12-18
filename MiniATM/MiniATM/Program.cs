using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniATM
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1- Bakiye Görüntüle
            // 2- Para Çekme
            // 3- Para Yatırma
            // 4- Çıkış

            int bakiye = 1000; 

            Console.WriteLine("ATM'ye Hoşgeldiniz");
            Console.WriteLine("Lütfen Yapmak İstediğiniz İşlemi Seçiniz:");
            Console.WriteLine("1- Bakiyenizi Görüntüleyin");
            Console.WriteLine("2- Para Çekme");
            Console.WriteLine("3- Para Yatırma");
            Console.WriteLine("4- Çıkış");
            Console.WriteLine("Toplam Bakiyeniz 1000 TL");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Şuanki Bakiyeniz: " + bakiye);
            }


            else if (secim == "2")
            {
                Console.WriteLine("Çekmek İstediğiniz Tutarı Giriniz:");

                int tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kalan Tutarınız: " + (bakiye - tutar));

                if (bakiye - tutar == 31)
                {
                    Console.WriteLine("31 Liran Kaldı GMDSAGONDSPVFDASNP");
                }
                else;

            }


            else if (secim == "3")
            {
                Console.WriteLine("Lütfen Yatırmak İstediğiniz Tutarı Giriniz:");

                int tutar = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Kalan Tutarınız: " + (bakiye + tutar));
            }


            else if (secim == "4") 
            {
                Console.WriteLine("ATM'den Çıkış yaptınız.");
            }

            
            else
            {
                Console.WriteLine("Lütfen Geçerli Seçim Yapınız.");
            }



            Console.ReadLine();



        }
    }
}
