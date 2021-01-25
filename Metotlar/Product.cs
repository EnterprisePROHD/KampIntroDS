#pragma warning disable IDE0005 // Using-Direktive ist unnötig.
using System;
using System.Collections.Generic;
using System.Text;
#pragma warning restore IDE0005 // Using-Direktive ist unnötig.

namespace Metotlar
{
    public class Product
    {
        public int Id { get; set; }

        public string Adi { get; set; }

        public double Fiyati { get; set; }

        public string Aciklama { get; set; }

        public int StokAdedi { get; set; }
    }
}
