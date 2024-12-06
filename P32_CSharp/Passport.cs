using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public class Passport
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public string? FatherName { get; set; } = null;

        public DateOnly BirthDay { get; set; }

        public string Series { get; set; }

        public int Number { get; set; }

        public void Info()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Surname);
            if (FatherName != null)
            {
                Console.WriteLine(FatherName);
            }
            Console.WriteLine(BirthDay.ToShortDateString());
            Console.WriteLine(Series + " " + Number);
        }
    }


    public class Visa
    {
        public string Country { get; set; }
        public TimeSpan Period { get; set; }

        public DateOnly DateStart { get; set; }

        public void Info()
        {
            Console.WriteLine($"{Country.PadRight(15)}{DateStart.ToShortDateString().PadRight(12)}{Period.Days}");
        }

    }


    public class ForeignPassport : Passport
    {
        Visa[] visas;

        int countVisas = 0;

        readonly int maxVisas = 10; 

        public ForeignPassport()
        {
            visas = new Visa[maxVisas];
        }

        public void AddVisa(Visa visa)
        {
            if (countVisas < maxVisas)
            {
                visas[countVisas++] = visa;
            }
        }

        public new void Info()
        {
            base.Info();
            Console.WriteLine("Visas:");
            for (int i = 0; i < countVisas; i++)
            {
                visas[i].Info();
            }
        }
    }

}
