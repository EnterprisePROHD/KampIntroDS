using System;

namespace Metotlar
{
    class Program
    {
        public static void Main(string[] args)
        {
            string productAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elmasi";

            string[] meyveler = new string[] { "Elma", "Karpuz" };

            Product product1 = new Product();
            product1.Adi = "Elma";
            product1.Fiyati = 15;
            product1.Aciklama = "Amasya elmasi";

            Product product2 = new Product();
            product2.Adi = "Karpuz";
            product2.Fiyati = 80;
            product2.Aciklama = "Diyarbakir karpuzu";

            Product[] products = new Product[] {product1, product2};

            foreach (Product product in products)
            {
                Console.WriteLine(productAdi);
                Console.WriteLine(product.Fiyati);
                Console.WriteLine(product.Aciklama);
                Console.WriteLine("----------------------------------------");
            }

            Console.WriteLine("-----------Metotlar-----------");

            Sepetmanager sepetmanager = new Sepetmanager();
            sepetmanager.Ekle(product1);
            sepetmanager.Ekle(product2);

            sepetmanager.Ekle2("Cilek", "Kirmizi cilek", 7, 10);
            sepetmanager.Ekle2("Armut", "Yesil armut", 12, 9);
            sepetmanager.Ekle2("Muz", "Sari muz", 3, 8);
        }
    }
}
