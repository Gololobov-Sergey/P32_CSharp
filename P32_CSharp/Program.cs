using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Specialized;
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

        public delegate void VoidDelegate();


        public static void VoidFunc()
        {
            Console.WriteLine("Void Fanc no params");
        }


        public delegate void ConsolePrint(string message);

        public delegate bool Method(int elem);

        public static int CountValue(int[] arr, Method method)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (method(arr[i]))
                {
                    count++;
                }
            }
            return count;
        }

        public static bool IsNegative(int a)
        {
            return a > 0;
        }

        public delegate bool VerifyDay(DateOnly d);


        public static void PrintGroup(Hashtable students)
        {
            foreach (var st in students.Keys)
            {
                Console.Write($"{st} - ");
                ArrayList v = (ArrayList)students[st]!;
                foreach (int item in v)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();
            }
        }

        public static void AddMark(Hashtable students, string fullName, int mark)
        {
            foreach (Student st in students.Keys)
            {
                if(fullName == st.LastName + " " + st.FirstName)
                {
                    ArrayList marks = (ArrayList)students[st]!;
                    marks.Add(mark);
                    Console.WriteLine("Mark added");
                    return;
                }
            }
            Console.WriteLine("Student not found");
        }

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Console.Title = "P32 C# - Слава Україні!";
            Console.Clear();


            /// 10.01.2025 ////////
            /// 


            Hashtable students = new Hashtable
            {
                {
                    new Student
                    {
                        LastName = "Petroff",
                        FirstName = "Oleg",
                        BirthDay = new DateTime(2000, 5, 15),
                        StudentCard = new StudentCard
                        {
                            Series = "AB",
                            Number = 123456
                        }
                    }, new ArrayList{7,8,9}
                },

                {
                    new Student
                    {
                        LastName = "Naumova",
                        FirstName = "Olga",
                        BirthDay = new DateTime(1999, 1, 20),
                        StudentCard = new StudentCard
                        {
                            Series = "AB",
                            Number = 123454
                        }
                    }, new ArrayList {6,8,10}
                },

                {
                    new Student
                    {
                        LastName = "Kuznetcov",
                        FirstName = "Dmytro",
                        BirthDay = new DateTime(2001, 10, 20),
                        StudentCard = new StudentCard
                        {
                            Series = "AA",
                            Number = 123456
                        }
                    }, new ArrayList{10,11,11}
                }
            };

            PrintGroup(students);
            AddMark(students, "Kuznetcov Dmytro", 12);
            PrintGroup(students);


            //ArrayList al = [1, "one", DateTime.Now];
            //al.AddRange(new int[] { 1, 2, 3 });
            //Console.WriteLine(al.Capacity);
            //Console.WriteLine(al.Count);

            //foreach (var item in al)
            //{
            //    Console.WriteLine(item);
            //}


            //Hashtable t = new Hashtable();
            //t.Add(1, "one");
            //t.Add("two", 2);
            //t[3] = "tree";

            //Console.WriteLine(t[4]);

            //foreach (object s in t.Keys)
            //{
            //    Console.WriteLine($"{s} - {t[s]}");
            //}



            /// 25.12.2024 ////////
            /// 

            //List<Student> group = new List<Student>
            //{
            //    new Student
            //    {
            //        LastName = "Petroff",
            //        FirstName = "Oleg",
            //        BirthDay = new DateTime(2000, 5, 15),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "AB",
            //            Number = 123456
            //        }
            //    },
            //    new Student
            //    {
            //        LastName = "Naumova",
            //        FirstName = "Olga",
            //        BirthDay = new DateTime(1999, 1, 20),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "AB",
            //            Number = 123454
            //        }
            //    },
            //    new Student
            //    {
            //        LastName = "Kuznetcov",
            //        FirstName = "Dmytro",
            //        BirthDay = new DateTime(2001, 10, 20),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "AA",
            //            Number = 123456
            //        }
            //    },
            //    new Student
            //    {
            //        LastName = "Frolova",
            //        FirstName = "Kateryna",
            //        BirthDay = new DateTime(2000, 3, 10),
            //        StudentCard = new StudentCard
            //        {
            //            Series = "AA",
            //            Number = 123452
            //        }
            //    }
            //};

            //Teacher teacher = new Teacher() { Name = "Gololobov S.A." };

            //foreach (Student item in group)
            //{
            //    teacher.ExamEvent += item.ExamInfo;
            //}


            //teacher.SetExam(new ExamEventArgs { Subject = "C#", Date = new DateOnly(2024, 12, 25), MaxGrade = 12 });
            //Console.WriteLine();

            //teacher.ExamEvent -= group[2].ExamInfo;

            ////teacher.ExamEvent += Teacher_ExamEvent;

            //teacher.SetExam(new ExamEventArgs { Subject = "C#", Date = new DateOnly(2025, 1, 1), MaxGrade = 10 });



            //Card card = new Card { Name = "Serg", PIN = "1111" };
            //card.AddMoneyEvent += ShowInfoFromConsole;
            //card.AddMoneyEvent += ShowInfoFromEmail;
            //card.AddMoney(1000);

            /// 23.12.2024 ////////
            /// 



            //int[] arr = { 1, 23, 43, 5, 7, 8, 1, -56, 1 };
            //Console.WriteLine(CountValue(arr, (e) => e == 1));
            //Console.WriteLine(CountValue(arr, (e) => e < 8));
            //Console.WriteLine(CountValue(arr, (e) => e > 20 && e < 50));
            //Console.WriteLine(CountValue(arr, (e) => e % 2 == 0));
            //Console.WriteLine(CountValue(arr, (e) => e > 0));
            //Console.WriteLine(CountValue(arr, IsNegative));


            //VerifyDay pd = (DateOnly d) =>  d.DayOfYear == 256;
            //pd += (DateOnly d) => d.DayOfWeek == DayOfWeek.Monday;
            //Console.WriteLine(pd(new DateOnly(2024, 9, 15)));
            //Console.WriteLine(pd(new DateOnly(2024, 12, 23)));

            //Color color;


            //ConsolePrint cp = (string message) => Console.WriteLine(message);

            //cp("Hello");


            //VoidDelegate vd = VoidFunc;
            //vd();

            //Calc calc = new Calc();
            //CalcDelegate? calcDelegate = null;

            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //char c = Convert.ToChar(Console.ReadLine());

            //switch(c)
            //{
            //    case '+': calcDelegate = new CalcDelegate(calc.Add); break;
            //    case '-': calcDelegate = calc.Diff; break;
            //    case '*': calcDelegate = Calc.Mult; break;
            //    case '/': calcDelegate = calc.Div; break;
            //}

            //calcDelegate = new CalcDelegate(calc.Add);
            //calcDelegate += calc.Diff;
            //calcDelegate += Calc.Mult;
            //calcDelegate += calc.Div;

            //if (calcDelegate != null)
            //    Console.WriteLine(calcDelegate(a,b));

            //Delegate[] d = calcDelegate.GetInvocationList();
            //Console.WriteLine((calcDelegate.GetInvocationList()[1] as CalcDelegate)(a, b));


            //foreach (CalcDelegate item in calcDelegate.GetInvocationList())
            //{
            //    Console.WriteLine(item(a, b));
            //}


            //calcDelegate -= Calc.Mult;
            //calcDelegate -= Calc.Mult;


            //foreach (CalcDelegate item in calcDelegate.GetInvocationList())
            //{
            //    Console.WriteLine(item(a, b));
            //}

            //calcDelegate += delegate (int a, int b) { Console.WriteLine($"{a} +=+ {b}"); return a + b; };
            //Console.WriteLine(calcDelegate(5,6));

            //calcDelegate += (int a, int b) => { return a + b; };

            /// 20.12.2024 ////////
            /// 


            //Group group = new Group();

            //foreach (Student student in group)
            //{
            //    Console.WriteLine(student);
            //}

            ////group.Sort();

            ////group.Sort(new DateComparer());
            ////group.Sort(Student.FromBirthDay);

            ////group.Sort(new StudentCardComparer());
            //group.Sort(Student.FromStudentCard);



            //Console.WriteLine();
            //foreach (Student student in group)
            //{
            //    Console.WriteLine(student);
            //}


            //Student st1 = new Student
            //{
            //    LastName = "Petroff",
            //    FirstName = "Oleg",
            //    BirthDay = new DateTime(2000, 5, 15),
            //    StudentCard = new StudentCard
            //    {
            //        Series = "AB",
            //        Number = 123456
            //    }
            //};

            //Student st2 = (Student)st1.Clone();

            //st2.FirstName = "xxxxxxx";

            //st2.StudentCard.Series = "XX";
            //Console.WriteLine(st2);
            //Console.WriteLine(st1);




            //Test t = new Test();
            //t.Show();
            //(t as IA1).Show();

            //IA1 a1 = new Test();
            //a1.Show();

            //IB1 b1 = new Test();
            //b1.Show();

            //IC1 c1 = new Test();
            //c1.Show();


            /*IWorker dir = new Director(2, "Petro", 30, 1000, 10);
            IWorker eng = new Enginer(4, "Vasya", 20, 500, 5);
            IWorker cm = new CleanigManager(6, "Maria", 50, 100, 200);
            IWorker[] employees = { dir, eng, cm };

            foreach (IWorker item in employees)
            {
                Console.WriteLine(item.Proff());
            }*/

            ////Employee dir = new Employee(2, "Petro", 30, 1000);

            //Employee dir = new Director(2, "Petro", 30, 1000, 10);
            //Employee eng = new Enginer(4, "Vasya", 20, 500, 5);
            //Employee cm = new CleanigManager(6, "Maria", 50, 100, 200);

            //Employee[] employees = { dir, eng, cm };
            //foreach (Employee item in employees)
            //{
            //    item.Proffesion();
            //    Console.WriteLine(item);
            //    Console.WriteLine();


            //    //try
            //    //{
            //    //    ((Director)item).Info();
            //    //}
            //    //catch (Exception)
            //    //{

            //    //}


            //    //Enginer e = item as Enginer;
            //    //if (e != null)
            //    //{
            //    //    e.Info();
            //    //}


            //    //if(item is CleanigManager)
            //    //{
            //    //    (item as CleanigManager)?.Info();
            //    //}

            //}



            //Matrix m = new Matrix(4, 5);
            //m.SetMatrix(0, 50);
            //Console.WriteLine(m);

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

        private static void ShowInfoFromEmail(string message)
        {
            Console.WriteLine("На Email прийшло повідомлення:");
            Console.WriteLine(message);
        }

        private static void ShowInfoFromConsole(string message)
        {
            Console.WriteLine("В консоль прийшло повідомлення:");
            Console.WriteLine(message);
        }

        private static void Teacher_ExamEvent(object? sender, ExamEventArgs e)
        {
            Console.WriteLine("Просто метод події");
        }
    }
}
