using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.utilities
{
    public class Savings
    {


       public decimal InterestCalculator(decimal p, decimal r, decimal t)
        {
            if (p==1)
            {
                return 1;

            }
            else  if (p<0)
            {
                return 0;

            }
            else
            {
                return (p * r * t / 100) + p;
            }

           
        }
    }
}
