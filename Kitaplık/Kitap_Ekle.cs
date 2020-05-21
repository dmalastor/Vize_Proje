using System;
using System.Collections.Generic;
using System.Text;


namespace Kitaplık
{
    public class Kitap_Ekle:Kitap_Özellikler
    {
        public static int ks;
        public Kitap_Ekle(string kitapadi, string kitapyazar, DateTime kitaptarih, string kitaptur)
        {
            Kitapadi = kitapadi;
            Kitapyazar = kitapyazar;
            Kitaptarih = kitaptarih;
            Kitaptur = kitaptur;
        }
        public static void KitapEkle()
        {
            int tarih;
            Console.WriteLine("Kaç kitap eklemek istiyorsunuz ?");
            ks = int.Parse(Console.ReadLine());
            Kitap_Ekle[] kitapdizisi = new Kitap_Ekle[ks];
            
            for (int i = 0; i < ks; i++)
            {
                Console.Write("Kitap Adını Giriniz : ");
                Kitapadi = Console.ReadLine();
                Console.Write("Kitap Yazarını Giriniz : ");
                Kitapyazar = Console.ReadLine();
                Console.Write ("Kitap Basım Yılını Giriniz : ");
                do
                {
                     tarih = int.Parse(Console.ReadLine());
                    if (tarih < 1650 || tarih > 2020)
                    {
                        Console.WriteLine("Basım Yılını 2020'den Büyük 1650'den Küçük Girmemelisiniz.");
                        Console.Write("Kitap Basım Yılını Giriniz: ");
                    }
                } while (tarih < 1650 || tarih > 2020);
                Kitaptarih = new DateTime(tarih, 1, 1);
                Console.Write("Kitap Tur Giriniz : ");
                Kitaptur = Console.ReadLine();
                Kitap_Ekle kitap = new Kitap_Ekle(Kitapadi, Kitapyazar, Kitaptarih, Kitaptur);
                kitapdizisi[i] = kitap;
                Kitap_Yazdır.KYazdırma(kitapdizisi, i);
            }
        }
        public string YazdırmaDizisi()
        {
            return $"Kitap Adı= {Kitapadi}\nYazar Adı= {Kitapyazar}\nBasım Tarihi= {Kitaptarih.Year}\nKitap Türü= {Kitaptur}\n---------------------";
        }
    }
}
