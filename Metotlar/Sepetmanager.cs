using System;
#pragma warning disable IDE0005 // Using-Direktive ist unnötig.
using System.Collections.Generic;
using System.Text;
#pragma warning restore IDE0005 // Using-Direktive ist unnötig.

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
