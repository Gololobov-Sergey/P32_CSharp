using System.Collections.Concurrent;
using System.Drawing;
using System.Text;

namespace P32_CSharp
{
    internal class Program
    {
        public enum Planet
        {
            Mars, Venera = 9, Mercury
        }

        static public void Func1(ref int i, ref int[] arr, out int a)
        {
            //Console.WriteLine(i);

            foreach (var item in arr)
                Console.WriteLine(item);

            //i++;

            arr = new int[] { 4, 5, 6 };


            // Console.WriteLine(i);

            foreach (var item in arr)
                Console.WriteLine(item);

            a = 999;
        }


        static public int Sum(int a, params int[] arr)
        {
            int s = 0;
            foreach (int item in arr)
            {
                s += item;
            }
            return s;
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = "P32 C# - Слава Україні!";
            Console.Clear();

            ////Employee dir = new Employee(2, "Petro", 30, 1000);

            Employee dir = new Director(2, "Petro", 30, 1000, 10);
            Employee eng = new Enginer(4, "Vasya", 20, 500, 5);
            Employee cm = new CleanigManager(6, "Maria", 50, 100, 200);

            Employee[] employees = { dir, eng, cm };
            foreach (Employee item in employees)
            {
                item.Proffesion();
                Console.WriteLine(item);
                Console.WriteLine();
                

                //try
                //{
                //    ((Director)item).Info();
                //}
                //catch (Exception)
                //{

                //}


                //Enginer e = item as Enginer;
                //if (e != null)
                //{
                //    e.Info();
                //}
                

                //if(item is CleanigManager)
                //{
                //    (item as CleanigManager)?.Info();
                //}

            }





            Matrix m = new Matrix(4, 5);
            m.SetMatrix(0, 50);
            Console.WriteLine(m);

            //Console.WriteLine(m[1,1]);



            //Point point = new Point() { X = 8, Y = 4 };
            //point["X"] = 555;
            //point.Print();
            //Console.WriteLine(point["Y"]);


            //City city = new("Mykolaiv", "Ukraine", 30000000, "+380512", new string[] { "Ingulsky", "Tcentralny" });
            //city[0] = "Korabelny";
            //city.Info();

            /// 09.12.2024 ////////
            ///


            //City city = new("Mykolaiv", "Ukraine", 30000000, "+380512", new string[] { "Ingulsky", "Tcentralny" });
            //city.Info();
            //city += 100000;
            //city.Info();

            //Apple a1 = new Apple() { Color = Color.Red, Diametr = 10 };
            //Apple a2 = new Apple() { Color = Color.Green, Diametr = 15 };
            //Kompot k = a1 + a2;
            //k += "water  - 1 l";
            //k += "sugar  - 200 gr";
            //k += "korica - 20 gr";
            //k.Info();
            //k += new Apple() { Color = Color.Yellow, Diametr = 5 };
            //k.Info();




            // (=) + - * / % += ....

            // && || -> & |

            //Point point = new Point() { X = 8, Y = 4 };
            //Point point1 = -point;
            //point1.Print();
            //point++;
            //++point;
            //point.Print();

            //Point point2 = point + point1;
            //point2.Print();

            //point += point2;

            //point = point2 + 10;
            //point += 10;

            //point = 10 + point;

            //Point point3 = point;
            //point3.X = 888;

            //point.Print();

            //if (point2 == point)
            //{
            //    Console.WriteLine("Yes");
            //}
            //else
            //{
            //    Console.WriteLine("No");
            //}

            //float a = point;

            //if(point > point2)
            //{

            //}


            //Passport passport = new Passport() 
            //{
            //    Surname = "Гололобов",
            //    Name ="Сергій",
            //    FatherName = "Анатолійович",
            //    BirthDay = new DateOnly(2000, 5, 20),
            //    Number = 121212,
            //    Series = "EP"
            //};

            //passport.Info();
            //Console.WriteLine();

            //ForeignPassport foreign = new ForeignPassport()
            //{
            //    Surname = "Gololobov",
            //    Name = "Serhiy",
            //    BirthDay = new DateOnly(2000, 5, 20),
            //    Number = 454545,
            //    Series = "XX"
            //};

            //foreign.AddVisa(new Visa() { Country = "USA", DateStart = new DateOnly(2024, 12, 5), Period = new TimeSpan(90, 0, 0, 0) });
            //foreign.AddVisa(new Visa() { Country = "Germany", DateStart = new DateOnly(2024, 5, 15), Period = new TimeSpan(180, 0, 0, 0) });

            //foreign.Info();



            //Employee employee = new Employee(5, "Ivan", 16, 5000);
            //employee.Info();



            //Student student = new Student() { Id = 3, Name = "Ivan" };



            /// 02.12.2024 ////////
            /// 

            //City city = new ("Mykolaiv", "Ukraine", 30000000, "+380512", new string[] {"Ingulsky", "Tcentralny"});
            //city.MyProperty = 10;
            //int ddd = city.MyProperty;
            //city.Age = 234;

            //city.SetNewDistrict("Ingulsky", "qwewerwe");

            //city.Info();

            //Console.WriteLine(Sum(1,2,3,4));


            //int i = 9;
            //int[] arr = new int[] { 1,2,3 };

            //Func1(ref i, ref arr, out int a);

            //Console.WriteLine(i);

            //foreach (var item in arr)
            //    Console.WriteLine(item);

            //Console.WriteLine(a);

            //int b = Int32.Parse("2");


            //Int32.TryParse("44", out int c);
            //Console.WriteLine(c);

            //Point p = new Point();
            //p.Print();


            //Student student1;
            //Student student = new Student();

            ////student1 = student;

            ////student1.id = 555;

            //student.Print();

            //Student student2 = new Student(99);
            //student2.Print();

            ////student2.count2 = 44;
            //Console.WriteLine(student2.count2);

            ////Student.name = "Oleg";
            //Console.WriteLine(Student.GetName());



            /// 25.11.2024 ////////
            /// 

            string st = Console.ReadLine();

            //string[] words = st.Split(' ');
            //for (int i = 0; i < words.Length; i++)
            //{
            //    words[i] = new string(words[i].Reverse().ToArray());
            //}
            //string st1 = String.Join(" ", words);
            //Console.WriteLine(st1);


            //string[] words = st.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            //Console.WriteLine(words.Length);


            //Planet planet = Planet.Mars;

            //switch (planet)
            //{
            //    case Planet.Mars:
            //        break;
            //    case Planet.Venera:
            //        break;
            //    case Planet.Mercury:
            //        break;
            //    default:
            //        break;
            //}
            //Console.WriteLine(planet);
            //Enum.GetName(typeof(Planet), planet);
            //Console.WriteLine((int)planet);

            //DayOfWeek dd = DateTime.Now.DayOfWeek;
            //Console.WriteLine(dd);



            //int[] arr = new int[] { 4, 2, 13, 45, 3, 7 };
            //String s = "mama";
            //Console.WriteLine(s.PadRight(20, '.'));
            //Console.WriteLine(s.PadLeft(20, '.'));
            //Console.WriteLine(String.Join(" ", arr));
            //s += "papa";


            //StringBuilder sb = new StringBuilder("adsasdasd");
            //sb.Insert(sb.Length - 1, 1000);
            //Console.WriteLine(sb.Capacity);

            //string s1 = sb.ToString();
            //Console.WriteLine(s1);




            //int M = Convert.ToInt32(Console.ReadLine());
            //int N = Convert.ToInt32(Console.ReadLine());
            //int[] arr1 = new int[M];
            //int[] arr2 = new int[N];
            //int[] arr3 = new int[0];

            //Random rnd = new Random();
            //for (int i = 0; i < M; i++)
            //{
            //    arr1[i] = rnd.Next(0, 10);
            //    Console.Write(arr1[i] + " ");
            //}
            //Console.WriteLine();

            //for (int i = 0;i < N; i++)
            //{
            //    arr2[i] = rnd.Next(0, 10);
            //    Console.Write(arr2[i] + " ");
            //}
            //Console.WriteLine();

            //for (int i = 0; i < arr1.Length; i++)
            //{
            //    if(Array.IndexOf(arr2, arr1[i]) != -1 && Array.IndexOf(arr3, arr1[i]) == -1)
            //    {
            //        int[] temp = new int[arr3.Length + 1];
            //        arr3.CopyTo(temp, 0);
            //        temp[arr3.Length] = arr1[i];
            //        arr3 = temp;
            //    }
            //}

            //for (int i = 0; i < arr3.Length; i++)
            //{
            //    Console.Write(arr3[i] + " ");
            //}
            //Console.WriteLine();



            //int[] arr = new int[] { 4,2,13,45,3,7};
            //int[] arr1 = { 1, 2, 3 };
            //int[] arr3;
            //arr3 = new int[5];
            //Array.Sort(arr);
            //Console.WriteLine(Array.BinarySearch(arr, 3));
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] *= 3;
            //    Console.Write(arr[i] + " ");
            //}
            //Console.WriteLine();

            //foreach (int elem in arr)
            //{
            //    //i *= 3;
            //    Console.Write(elem + " ");
            //}
            //Console.WriteLine();

            //Console.WriteLine(arr.Rank);

            //int[,] arr5 = new int[2, 3] { { 1, 2, 3 }, { 45, 6, 3 } };
            //Console.WriteLine(arr5.Rank);

            //for (int i = 0; i < arr5.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr5.GetLength(1); j++)
            //    {
            //        Console.Write(arr5[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}



            //int [][] arr7 = new int[3][];
            //arr7[0] = new int[5] { 12,3,4,5,6};
            //arr7[1] = new int[2] { 23,4};
            //arr7[2] = arr;

            //for (int i = 0; i < arr7.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr7[i].Length; j++)
            //    {
            //        Console.Write(arr7[i][j] + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(arr.Sum());
            //Console.WriteLine(arr.Average());

            //int a = Convert.ToInt32(Console.ReadLine());
            //int n = 0;
            //while(a > 0)
            //{
            //    n = n * 10 + a % 10;
            //    a /= 10;
            //}
            //Console.WriteLine(n);


            //Random random = new Random();
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(random.NextDouble());
            //}


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
