using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
}
