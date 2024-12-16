using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public interface IWorker
    {
        bool Work {  get; }

        string Proff();
    }
}
