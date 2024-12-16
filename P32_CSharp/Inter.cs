using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public interface IA
    {
        void A();
    }

    public interface IB
    {
        void B(int b);
    }

    public interface IC : IA, IB
    {
        void C();
    }


    public class Class : IC
    {
        public void A()
        {
            throw new NotImplementedException();
        }

        public void B(int b)
        {
            throw new NotImplementedException();
        }

        public void C()
        {
            throw new NotImplementedException();
        }
    }



    interface IA1
    {
        void Show();
    }

    interface IB1
    {
        void Show();
    }

    interface IC1
    {
        void Show();
    }

    class Test : IA1, IB1, IC1
    {
        public void Show()
        {
            Console.WriteLine("Show Default");
        }
        void IA1.Show()
        {
            Console.WriteLine("Show IA");
        }

        void IB1.Show()
        {
            Console.WriteLine("Show IB");
        }
    }
}
