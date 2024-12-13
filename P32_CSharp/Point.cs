using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point()
        {
            X = 0;
            Y = 0;
        }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Print()
        {
            Console.WriteLine($"X = {X}, Y = {Y}");
        }

        public static Point operator -(Point p)
        {
            return new Point() { X = -p.X, Y = -p.Y };
        }


        public static Point operator ++(Point p)
        {
            p.X++;
            p.Y++;
            return p;
        }

        public static Point operator --(Point p)
        {
            p.X--;
            p.Y--;
            return p;
        }

        public static Point operator +(Point p1, Point p2)
        {
            return new Point() { X = p1.X + p2.X, Y = p1.Y + p2.Y };
        }

        public static Point operator +(Point p1, int n)
        {
            return new Point() { X = p1.X + n, Y = p1.Y + n };
        }

        public static Point operator +(int n, Point p1)
        {
            return new Point() { X = p1.X + n, Y = p1.Y + n };
        }

        public static bool operator ==(Point p1, Point p2)
        {
            return p1.X == p2.X && p1.Y == p2.Y;
        }

        public static bool operator !=(Point p1, Point p2)
        {
            return p1.X != p2.X || p1.Y != p2.Y;
        }

        public static bool operator true(Point p)
        {
            return p.X != 0 && p.Y != 0;
        }

        public static bool operator false(Point p)
        {
            return p.X == 0 && p.Y == 0;
        }

        public static implicit /*explicit*/ operator float(Point p)
        {
            return (float)Math.Sqrt(p.X * p.X + p.Y * p.Y);
        }


        public int this[string attr]
        {
            set 
            {
                if (attr == "X")
                {
                    X = value;
                }
                else if (attr == "Y")
                {
                    Y = value;
                }
            }
            get 
            { 
                if(attr == "X")
                    return X;
                else if (attr == "Y")
                    return Y;
                return 0;
            }
        }
    }
}
