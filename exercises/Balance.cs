using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    public static class Balance
    {
        public static void SumBalance(List<IAcount> accounts)
        {
            double positiveBalance = 0; 
            double negativeBalance = 0;

            foreach(IAcount account in accounts)
            {
                if (account is PositiveAcount)
                {
                    positiveBalance += account.GetBalnce();
                }
                if (account is NegativeAcount)
                {
                    negativeBalance += account.GetBalnce();
                }
            }
            Console.WriteLine($"your positive Balance is :{positiveBalance}");
            Console.WriteLine($"your negative Balance is :{negativeBalance}");
            Console.WriteLine($"all your money is :{positiveBalance - negativeBalance}");


        }
    }
}
