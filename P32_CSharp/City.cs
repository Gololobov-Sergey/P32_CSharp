﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public class City
    {
        string name;
        string country;
        int population;
        readonly string phoneCode;
        readonly string[] districts;


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
    }
}
