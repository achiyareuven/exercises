using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public class PositiveAcount : IAcount
    {
        public double CashBalance { get; set; }

        public PositiveAcount(double cash)
        {
            CashBalance = cash;
        }
        public double GetBalnce() => CashBalance;
    }

}
