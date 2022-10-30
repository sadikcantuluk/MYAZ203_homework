using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5_hw
{
    internal class Car : About
    {
        public override void Poster()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Model: Renault Symbol");
            Console.WriteLine("Çıkı Tarihi: 28 Ocak 2022");
            Console.WriteLine("Fiyatı: 240.000 TL");
            Console.WriteLine("*****************");
        }
    }
}
