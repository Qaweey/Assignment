using System;

namespace Assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ulong result = 0;
            bool prime = true;
            for (uint i = uint.MinValue; i <= uint.MaxValue; i++)
            {
               
                int divisor = 2;
                double maximumDivisor = Math.Sqrt(uint.MaxValue);
                
                while (prime&& divisor<maximumDivisor)
                {
                    if (i%divisor==0)
                    {
                        prime = false;
                        break;

                    }

                    divisor++;
                    if (prime)
                    {
                        result += i;
                    }
                }

                
                
            }
            Console.WriteLine(result);
        }
        
    }
}
