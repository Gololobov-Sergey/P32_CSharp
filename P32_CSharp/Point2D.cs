using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{

   
    public class Point2D<T> /*where T :*/ /*class,*/ /*struct,*/ /*Human,*/ /*IWorker,*/ /*new()*/
    {
        public T? X { get; set; }
        public T? Y { get; set; }

        public Point2D()
        {
            X = default;  
            Y = default(T);
        }

        public Point2D(T x, T y)
        {
            X = x;
            Y = y;
        }
    }


    public class Point3D<T> : Point2D<T>
    {

    }

    public class Vector : Point2D<int>
    {

    }

    public class NewPoint<T> : Point
    {

    }
}
