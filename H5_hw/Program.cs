using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H5_hw
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book=new Book();
            var car=new Car();
            var computer=new Computer();

            book.Poster();
            car.Poster();
            computer.Poster();

            Console.ReadLine();
        }
    }
}
