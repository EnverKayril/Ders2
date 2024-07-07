namespace _20_Thread
{
    public class Program
    {
        static void Main(string[] args)
        {
            // C# Thread dediğimiz iş parçacıklarını yürüterek çalışır. Thread (işletim sistemi düzeyindeki bir iş parçacığı kavramı), bir programın eş zamanlı olarak çalışmasını sağlar.
            bool devamMi = true;
            while (devamMi)
            {
                Console.WriteLine("İşlem seçiniz: ");
                Console.WriteLine("1-Ürünleri Listele, 2-Rapor Yazdır, 3-Çıkış, 4-Tüm İşlemler");
                string islem = Console.ReadLine();
                if (islem == "1")
                {
                    Thread threadUrunleriListele = new Thread(new ThreadStart(UrunListele));
                    threadUrunleriListele.Start();
                }
                else if (islem == "2")
                {
                    RaporYazdir();
                }
                else if (islem == "3")
                {
                    devamMi = false;
                }
                else if (islem == "4")
                {
                    Thread threadUrunleriListele = new Thread(new ThreadStart(UrunListele));
                    Thread threadRaporYazdir = new Thread(new ThreadStart(RaporYazdir));

                    threadUrunleriListele.Start();
                    threadRaporYazdir.Start();
                }
            }

        }

        static void UrunListele()
        {
            Console.WriteLine("Ürünler Listeleniyor...");
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("Ürünler - " + i.ToString());
            }
            Console.WriteLine("Ürünler listelendi. Enter tuşuna basınınz...");
            Console.ReadLine();
        }

        static void RaporYazdir()
        {
            Console.WriteLine("Rapor Yazdırılıyor...");
            for (int i = 0; i <= 1000; i++)
            {
                Console.WriteLine("Rapor - " + i.ToString());
            }
            Console.WriteLine("Rapor yazdırıldı. Enter tuşuna basınız...");
            Console.ReadLine();
        }
    }
}
