using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P32_CSharp
{
    public delegate void Show(string message);
    public class Card
    {
        public string Name { get; set; }
        public string PIN { get; set; }
        
        int money;

        public event Show AddMoneyEvent;
        public void AddMoney(int sum)
        {
            money += sum;
            if(AddMoneyEvent != null)
            {
                AddMoneyEvent($"На рахунок поступило {sum} грошей");
            }
        }
        



    }
}
