using System;
using System.IO;

namespace Kitaplık
{
    public class Kitap_Yazdır : Kitap_Özellikler
    {
        public Kitap_Yazdır(string kitapadi, string kitapyazar, DateTime kitaptarih, string kitaptur)
        {
            Kitapadi = kitapadi;
            Kitapyazar = kitapyazar;
            Kitaptarih = kitaptarih;
            Kitaptur = kitaptur;
        }
        public static void KYazdırma(Kitap_Ekle[] dizi, int i)
        {
            FileStream fs = new FileStream("D:/Kitap_Listesi.txt", FileMode.Append, FileAccess.Write, FileShare.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(dizi[i].YazdırmaDizisi());
            fs.Flush();
            sw.Close();
            fs.Close();
        }
        public static void ListeyiGöster()
        {
            string line;
            StreamReader file = new StreamReader(@"D:/Kitap_Listesi.txt");
            while ((line = file.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            file.Close();
        }
    }
}
