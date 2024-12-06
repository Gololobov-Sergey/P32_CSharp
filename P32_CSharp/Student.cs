using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public class Student
    {
        //public int id;
        //static string name;
        //public const int count = 999;
        //public readonly int count2 = 0;

        public int Id { get; set; }

        public string Name { get; set; }

        public int Count2 { get; } = 0;


        private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }

        //public Student()
        //{

        //}

        //public Student(int count2)
        //{
        //    //this.count2 = count2;
        //}

        //static Student() 
        //{
        //    //name = "Ivan";
        //}



        public void Print()
        {
            
            System.Console.WriteLine($"ID : {Id}, Name : {Name}, Count2 : {Count2}");
        }

    }
}
