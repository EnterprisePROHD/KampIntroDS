using System;
#pragma warning disable IDE0005 // Using-Direktive ist unnötig.
using System.Collections.Generic;
using System.Text;
#pragma warning restore IDE0005 // Using-Direktive ist unnötig.

namespace Matematik
{
    public class DortIslem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuc : " + toplam);
        }
    }
}
