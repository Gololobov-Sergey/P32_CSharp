using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public partial class City
    {
        string name;
        string country;
        int population;
        readonly string phoneCode;
        readonly string[] districts;

        public string this[int index]
        {
            get
            {
                if (index >= districts.Length)
                {
                    return "None";
                }
                return districts[index];
            }

            set
            {
                if (index >= districts.Length)
                    return;
                districts[index] = value;
            }
        }

        //private string? myVar;

        //public string MyProperty
        //{
        //    get 
        //    {
        //        if (myVar == null)
        //            return "No name";
        //        return myVar; 
        //    }
        //    set 
        //    {
        //        if (value == null)
        //        {
        //            return;
        //        }
        //        myVar = value; 
        //    }
        //}

        //private int age;

        //public int Age
        //{
        //    get { return age; }
        //    set { age = value; }
        //}


        //public int MyProperty1 { get; set; }

        public City(string name, string country, int population, string phoneCode, string[] districts)
        {
            this.name = name;
            this.country = country;
            this.population = population;
            this.phoneCode = phoneCode;
            this.districts = districts;
        }

        public void Info()
        {
            Console.WriteLine(name);
            Console.WriteLine(country);
            Console.WriteLine(population);
            Console.WriteLine(phoneCode);
            Console.WriteLine("Districts:");
            foreach (var district in districts)
            {
                Console.WriteLine(district);
            }
        }

        public void SetNewDistrict(string oldDistr,  string newDistr)
        {
            for (int i = 0; i < districts.Length; i++)
            {
                if (oldDistr == districts[i])
                {
                    districts[i] = newDistr;
                }
            }
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public static City operator+(City city, int delta)
        {
            city.population += delta;
            return city;
        }
    }
}
