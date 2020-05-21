using System;
using Kitaplık;

namespace Vize_Proje
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string cevap = "";
                do
                {
                    Console.WriteLine("Kitap Eklemek için ' 1 ' Kitap Listesini Görmek İçin ' 2 ' Yazınız.");
                    char ch =char.Parse(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            Kitap_Ekle.KitapEkle();
                            break;
                        case '2':
                            Kitap_Yazdır.ListeyiGöster();
                            break;
                        default:
                            Console.WriteLine("Menüde sadece 2 seçenek bulunmaktadır , 1 veya 2 seçeneğini kullanınız.");
                            break;
                    }
                    Console.WriteLine("---------------------------------------\nBaşka işlem yapmak istiyor musunuz ? (e-h)");
                    cevap = Console.ReadLine();
                    Console.Clear();
                } while (cevap == "e");
            }
            catch (Exception hata)
            {
                Console.WriteLine("Lütfen örnekte ki gibi bir kullanım gerçekleştiriniz.'1' - '2'");
            }
        }
    }
}
