using System;

namespace ClassIntro
{
    class Program
    {
        public static void Main(string[] args)
        {
            string adi = "Denizhan";
            int yas = 20;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Denizhan";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "Mathematik";
            kurs2.Egitmen = "Rias";
            kurs2.IzlenmeOrani = 76;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Anime";
            kurs3.Egitmen = "Shion";
            kurs3.IzlenmeOrani = 89;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }

        public string Egitmen { get; set; }

        public int IzlenmeOrani { get; set; }
    }
}
