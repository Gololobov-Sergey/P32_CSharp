using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{

    public delegate int CalcDelegate(int a, int b);

    public class Calc
    {
        public int Add(int a, int b) => a + b;
        public int Diff(int a, int b) => a - b;
        public static int Mult(int a, int b) => a * b;
        public int Div(int a, int b) => a / b;
    }
}
