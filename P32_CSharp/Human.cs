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

        //public void Info()
        //{
        //    Console.WriteLine();
        //}

        public override string ToString()
        {
            return $"Id : {id}\nName : {Name}\nAge : {Age}";
        }
    }


    public /*sealed*/ abstract class Employee : Human
    {
        new int id;
        int salary;

        public Employee(int id, string name, int age, int salary) : base(id, name, age)
        {
            this.salary = salary;
        }

        //public new virtual void Info()
        //{
        //    base.Info();
        //    Console.WriteLine($"Salary : {salary}");
        //}

        public abstract void Proffesion();


        public /*sealed*/ override string ToString()
        {
            return base.ToString() + $"\nSalary : {salary}\"";
        }

    }


    public class Enginer : Employee
    {
        int expirience;

        public Enginer(int id, string name, int age, int salary, int expirience) : base(id, name, age, salary)
        {
            this.expirience = expirience;
        }

        public override void Proffesion()
        {
            Console.WriteLine("Enginer");
        }

        //public override void Info()
        //{
        //    base.Info();
        //    Console.WriteLine($"Exp - {expirience}");
        //}

        public override string ToString()
        {
            return base.ToString() + $"\nExp - {expirience}";
        }
    }


    public class Director : Employee
    {
        int personal;

        public Director(int id, string name, int age, int salary, int personal) : base(id, name, age, salary)
        {
            this.personal = personal;
        }

        public override void Proffesion()
        {
            Console.WriteLine("Director");
        }

        //public override void Info()
        //{
        //    base.Info();
        //    Console.WriteLine($"Personal - {personal}");
        //}

        public override string ToString()
        {
            return base.ToString() + $"\nPersonal - {personal}";
        }
    }


    public class CleanigManager : Employee
    {
        int area;

        public CleanigManager(int id, string name, int age, int salary, int area) : base(id, name, age, salary)
        {
            this.area = area;
        }

        public override void Proffesion()
        {
            Console.WriteLine("CleanigManager");
        }

        //public override void Info()
        //{
        //    base.Info();
        //    Console.WriteLine($"Area - {area}");
        //}

        public override string ToString()
        {
            return base.ToString() + $"\nArea - {area}";
        }
    }

}
