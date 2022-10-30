using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5_hw
{
    internal class Book : About
    {
        public override void Poster()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Adı: Gurur ve Önyargı");
            Console.WriteLine("İlk Yayınlanma Tarihi: 28 Ocak 1813");
            Console.WriteLine("Yazarı: Jane Austen");
            Console.WriteLine("*****************");
        }
    }
}
