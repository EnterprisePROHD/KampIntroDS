#pragma warning disable IDE0005 // Using-Direktive ist unnötig.
using System;
#pragma warning restore IDE0005 // Using-Direktive ist unnötig.

namespace Matematik
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(5, 6);

            dortIslem.Topla(6, 9);
        }
    }
}
