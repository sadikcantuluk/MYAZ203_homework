using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_NesneLAB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee employee1 = new Employee();
            //employee1.ID = 1;
            //employee1.firstNmae = "SADIK";
            //employee1.lastName = "TULUK";
            //employee1.Age = 20;


            var employee6 = new Employee();

            employee6.AddRange(
                new Employee() { ID = 1, firstNmae = "MURAT", lastName = "TURAN", Age = 35 },
                new Employee() { ID = 2, firstNmae = "YUSUF", lastName = "TULUK", Age = 65 },
                new Employee() { ID = 3, firstNmae = "ÖZCAN", lastName = "AĞIRBAŞLI", Age = 20 },
                new Employee() { ID = 4, firstNmae = "SEFA", lastName = "TIKAÇ", Age = 21 }

            );

            employee6.Remove(3);

            var list = employee6.ListDon();
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }




            Console.ReadLine();

        }
    }
}
