using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace P32_CSharp
{
    public class StudentCard : IComparable
    {
        public int Number { get; set; }

        public string? Series { get; set; }

        public int CompareTo(object? obj)
        {
            if (obj is StudentCard)
            {
                StudentCard? sc = obj as StudentCard;
                return $"{Series}{Number}".CompareTo($"{sc!.Series}{sc!.Number}");
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{Series} {Number}";
        }
    }

    

    public class Student : IComparable, ICloneable
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime BirthDay { get; set; }

        public StudentCard? StudentCard { get; set; }

        public static IComparer FromStudentCard => new StudentCardComparer();
        public static IComparer FromBirthDay => new DateComparer();

        public int CompareTo(object? obj)
        {
            if (obj is Student)
            {
                Student st = (Student)obj;
                return $"{LastName}{FirstName}".CompareTo($"{st.LastName}{st.FirstName}");
            }
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"{LastName!.PadRight(15)} {FirstName!.PadRight(10)} {BirthDay.ToShortDateString()} {StudentCard}";
        }

        public object Clone()
        {
            Student temp = (Student)this.MemberwiseClone();
            temp.StudentCard = new StudentCard
            {
                Series = this.StudentCard!.Series,
                Number = this.StudentCard!.Number
            };
            return temp;
        }

        //#2
        public void ExamInfo(object sender, ExamEventArgs task)
        {
            Console.WriteLine($"Екзамен для {LastName} {FirstName}, по предмету {task.Subject} назначений на {task.Date.ToShortDateString()}\n" +
                $"Максимальна кількіть балів - {task.MaxGrade}\n" +
                $"Екзамен назначив - {(sender as Teacher).Name}");
        }


        //#1
        //public void ExamInfo(DateOnly date)
        //{
        //    Console.WriteLine($"Екзамен для {LastName} {FirstName} назначений на {date.ToShortDateString()}");
        //}
    }


    public class Group : IEnumerable
    {
        Student[] students;

        public Group()
        {
            students = new Student[]
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
                },
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
                },
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
                },
                new Student
                {
                    LastName = "Frolova",
                    FirstName = "Kateryna",
                    BirthDay = new DateTime(2000, 3, 10),
                    StudentCard = new StudentCard
                    {
                        Series = "AA",
                        Number = 123452
                    }
                }
            };
        }

        public void Sort()
        {
            Array.Sort(students);
        }

        public void Sort(IComparer comparer)
        {
            Array.Sort(students, comparer);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return students.GetEnumerator();
        }
    }

    public class DateComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if(x is Student && y is Student)
            {
                return (x as Student)!.BirthDay.CompareTo((y as Student)!.BirthDay);
            }
            throw new NotImplementedException();
        }
    }

    public class StudentCardComparer : IComparer
    {
        public int Compare(object? x, object? y)
        {
            if (x is Student && y is Student)
            {
                return (x as Student)!.StudentCard!.CompareTo((y as Student)!.StudentCard);
            }
            throw new NotImplementedException();
        }
    }

    public delegate void ExamDelegate(DateOnly date);

    public class Teacher
    {
        SortedList<string, EventHandler<ExamEventArgs>> list = new();

        public string Name { get; set; }
        //#2
        public event EventHandler<ExamEventArgs> ExamEvent
        {
            add 
            {
                Student st = value.Target as Student;
                list.Add(st.LastName + st.FirstName, value);
            }
            remove 
            {
                Student st = value.Target as Student;
                list.Remove(st.LastName + st.FirstName);
            }
        }

        public void SetExam(ExamEventArgs task)
        {
            if (list != null)
            {
                foreach (string item in list.Keys)
                {
                    list[item](this, task);
                }
            }
        }


        // #1
        //public event ExamDelegate ExamEvent;

        //public void SetExam(DateOnly date)
        //{
        //    if( ExamEvent != null )
        //    {
        //        ExamEvent(date);
        //    }
        //}
    }

    public class ExamEventArgs : EventArgs
    {
        public DateOnly Date { get; set; }
        public string Subject { get; set; }
        public int MaxGrade { get; set; }


    }
    
}
