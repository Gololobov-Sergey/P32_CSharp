using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public class Student
    {
        public int id;
        static string name;
        public const int count = 999;
        public readonly int count2 = 0;

        public Student()
        {

        }

        public Student(int count2)
        {
            this.count2 = count2;
        }

        static Student() 
        {
            name = "Ivan";
        }



        public void Print()
        {
            
            System.Console.WriteLine($"ID : {id}, Name : {name}, Count2 : {count2}");
        }

        public static string GetName()
        {
            //id = 888;
            return name;
        }
    }
}
