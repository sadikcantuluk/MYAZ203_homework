using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5_hw
{
    internal class Computer : About
    {
        public override void Poster()
        {
            Console.WriteLine("*****************");
            Console.WriteLine("Marka: MSI");
            Console.WriteLine("Model: GF63 THIN SERIES");
            Console.WriteLine("FİYAT: 20.000");
            Console.WriteLine("*****************");
        }
    }
}
