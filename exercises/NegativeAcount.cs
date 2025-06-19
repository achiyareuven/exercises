using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class NegativeAcount : IAcount
    {
        public double AmountOfDebt { get; set; }

        public NegativeAcount(double debt) { AmountOfDebt = debt; }

        public double GetBalnce()=>AmountOfDebt;
    }
}
