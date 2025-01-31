using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ProgrammerAttribute : Attribute
    {
        public string name = "Gololobov SA";
        DateTime date = DateTime.Now;

        public ProgrammerAttribute()
        {
            
        }

        public ProgrammerAttribute(string name, string date)
        {
            this.name = name;   
            this.date = Convert.ToDateTime(date);
        }

        public override string ToString()
        {
            return $"Programmer: {name}, Date: {date.ToShortDateString()}";
        }
    }
}
