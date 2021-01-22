using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    public class Sepetmanager
    {
        public void Ekle(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Adi);
        }

        public void Ekle2(string productAdi, string aciklama, double fiyat, int stockAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + productAdi);
        }
    }
}
