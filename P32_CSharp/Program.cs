using System.Collections.Concurrent;
using System.Text;

namespace P32_CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = "P32 C# - Слава Україні!";
            Console.Clear();

            //int a = Convert.ToInt32(Console.ReadLine());
            //int n = 0;
            //while(a > 0)
            //{
            //    n = n * 10 + a % 10;
            //    a /= 10;
            //}
            //Console.WriteLine(n);


            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(random.NextDouble());
            }


            //DateTime d = DateTime.Now;
            //Console.WriteLine(d);
            //Console.WriteLine(d.DayOfYear);
            //Console.WriteLine(d.ToShortDateString());  
            //Console.WriteLine(d.ToLongTimeString());  
            //Console.WriteLine(d.ToLongDateString());  
            //Console.WriteLine(d.ToUniversalTime()); 
            
            //DateTime dd = Convert.ToDateTime(Console.ReadLine());
            //Console.WriteLine(dd);
            //Console.WriteLine(dd.ToString("yyyy-mm-dd"));


            //int a = 1;

            //bool b = false;

            //float f = 2.2f;

            //decimal d = 2.3M;


            //int a = Convert.ToInt32(Console.ReadLine());

            //int a = Int32.Parse(Console.ReadLine());


            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = a + b;
            //Console.WriteLine($"c = {c}");



            //if ( a == 0 )
            //{

            //}
            //else if( a == 1 ) 
            //{

            //}
            //else
            //{

            //}

            //String s = Console.ReadLine();
            //switch (s)
            //{
            //    case "mama": 
            //        Console.WriteLine("Hello"); 
            //        break;
            //    case "papa": 
            //        Console.WriteLine("Hello"); 
            //        break;
            //    default:
            //        break;
            //}

            //int m = (a > 0) ? 3 : 5;


            //for (int i = 0; i < m; i++)
            //{
            //    Console.WriteLine("mama");
            //}

            //while (true)
            //{

            //}

            //do
            //{

            //} while (true);



            Console.Write("> ");
            Console.Read();
        }
    }
}
