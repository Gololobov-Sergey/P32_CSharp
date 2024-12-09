using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public class Apple
    {
        public int Diametr { get; set; }

        public Color Color { get; set; }


        public static Kompot operator+(Apple a1, Apple a2)
        {
            Kompot kompot = new Kompot();
            kompot += a1;
            kompot += a2;
            return kompot;
        }
    }

    public class Kompot
    {
        Apple[] apples = new Apple[0];
        string[] ingadients = new string[0];

        public static Kompot operator+(Kompot k, Apple apple)
        {
            Array.Resize(ref k.apples, k.apples.Length + 1);
            k.apples[k.apples.Length - 1] = apple;
            return k;
        }

        public static Kompot operator +(Kompot k, string ingradient)
        {
            Array.Resize(ref k.ingadients, k.ingadients.Length + 1);
            k.ingadients[k.ingadients.Length - 1] = ingradient;
            return k;
        }

        public void Info()
        {
            foreach (var apple in apples)
            {
                Console.WriteLine(apple.Color);
            }
            foreach (var ingrad in ingadients)
            {
                Console.WriteLine(ingrad);
            }
        }
    }
}
