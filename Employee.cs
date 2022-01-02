using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office_ConsoleApp
{
    internal class Employee
    {
        public string name;
        public string birthday;
        public string email;
        public int salary;

        public Employee() { }

        public Employee(string _name, string _birthday, string _email, int _salary)
        {
            this.name = _name;
            this.birthday = _birthday;
            this.email = _email;
            this.salary = _salary;
        }
    }
}
