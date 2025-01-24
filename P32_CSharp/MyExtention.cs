using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public static class MyExtention
    {
        public static void Print(this Array arr)
        {
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }


        public static string PadCenter(this string str, int totalWidth)
        {
            StringBuilder sb = new StringBuilder();
            int lenL = (totalWidth - str.Length) / 2;
            for (int i = 0; i < lenL; i++)
            {
                sb.Append(' ');
            }
            sb.Append(str);
            for (int i = 0; i < totalWidth - lenL - str.Length; i++)
            {
                sb.Append(' ');
            }
            return sb.ToString();
        }
    }
}
