using System;
using System.Collections.Generic;
using System.Text;

namespace Kitaplık
{
    public class Kitap_Özellikler
    {

        private static string kitapadi, kitapyazar, kitaptur;
        private static DateTime kitaptarih;

        public static string Kitapadi { get => kitapadi; set => kitapadi = value; }
        public static string Kitapyazar { get => kitapyazar; set => kitapyazar = value; }
        public static DateTime Kitaptarih { get => kitaptarih; set => kitaptarih = value; }
        public static string Kitaptur { get => kitaptur; set => kitaptur = value; }

    }
}
