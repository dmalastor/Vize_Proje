using System;
using Kitaplık;

namespace Vize_Proje
{
    class Program
    {
        static void Main(string[] args)
        {
            char cevap;
            try
            {
                
                
                do
                {
                    
                    Console.WriteLine("Kitap Eklemek için ' 1 ' Kitap Listesini Görmek İçin ' 2 ' Yazınız.");
                    char secenek =char.Parse(Console.ReadLine());
                    if (secenek=='1')
                    {
                        Kitap_Ekle.KitapEkle();
                    }
                    else if (secenek=='2')
                    {
                        Kitap_Yazdır.ListeyiGöster();
                    }
                    else
                    {
                        Console.WriteLine("Lüften işlem için 1 veya 2 yazınız.");
                    }
                    Console.WriteLine("---------------------------------------\nBaşka işlem yapmak istiyor musunuz ? (e-h)");
                    cevap =char.Parse(Console.ReadLine().ToLower());
                    Console.Clear();
                } while (cevap == 'e');
            }
            catch (FormatException)
            {
                Console.WriteLine("Lütfen örnekte ki gibi bir kullanım gerçekleştiriniz.'1' - '2'");
            }
        }
    }
}
