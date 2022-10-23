using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H2_NesneLAB
{
    internal class Employee
    {
        private List<Employee> employeeList = new List<Employee>();

        public Employee()
        {

        }

        public Employee(int ıD, string firstNmae, string lastName, int age)
        {
            ID = ıD;
            this.firstNmae = firstNmae;
            this.lastName = lastName;
            Age = age;
        }

        public int ID { get; set; }
        public string firstNmae { get; set; }
        public string lastName { get; set; }
        public int Age { get; set; }



        public void AddRange(params Employee[] employee)
        {
            employeeList.AddRange(employee);
        }

        public void Remove(int ID)
        {
            employeeList.RemoveAt(ID-1);
            
        }

        public List<Employee> ListDon()
        {
            return employeeList;
        }

        public override string ToString()
        {
            return $"{ID,-10} {firstNmae,-10} {lastName,-10} {Age,10}";
        }
    }
}
