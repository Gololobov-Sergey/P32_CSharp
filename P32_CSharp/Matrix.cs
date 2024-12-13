using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public class Matrix
    {
        int[,] arr;

        int countDigits = 3; 

        public int Rows { get; }
        public int Column { get; }

        public Matrix(int row, int col)
        {
            Rows = row;
            Column = col;
            arr = new int[row, col];
        }

        public void SetMatrix(int minValue = 0, int maxValue = 9)
        {
            countDigits = Convert.ToString(maxValue).Length + 1;
            Random random = new Random();
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = random.Next(minValue, maxValue);
                }
            }
        }

        //public void Print()
        //{
        //    for(int i = 0; i < arr.GetLength(0);i++)
        //    {
        //        for(int j = 0; j < arr.GetLength(1); j++)
        //        {
        //            Console.Write($"{arr[i,j]}".PadLeft(countDigits));
        //        }
        //        Console.WriteLine();
        //    }
        //}

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    builder.Append($"{arr[i, j]}".PadLeft(countDigits));
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }

        public int this[int r, int c]
        {
            get
            {
                return arr[r, c];
            }
            set
            {
                arr[r, c] = value;
            }
        }
    }
}
