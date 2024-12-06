using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public class Human
    {
        protected int id;

        public string Name { get; set; }

        public int Age { get; set; }


        public Human(int id, string name, int age)
        {
            this.id = id;
            Name = name;
            Age = age;
        }

        public void Info()
        {
            Console.WriteLine($"Id : {id}\nName : {Name}\nAge : {Age}");
        }
    }


    public class Employee : Human
    {
        new int id;
        int salary;

        public Employee(int id, string name, int age, int salary) : base(id, name, age)
        {
            this.salary = salary;
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine($"Salary : {salary}");
        }
    }
}
