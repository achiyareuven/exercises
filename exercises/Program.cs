﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var accounts = new List<IAcount>
            {
                new PositiveAcount(1000),
                new NegativeAcount(500)
            };

            Balance.SumBalance(accounts);
        }
    }
}
