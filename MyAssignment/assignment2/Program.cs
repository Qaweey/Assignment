using System;

namespace assignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            uint maxnum = uint.MaxValue;
            ulong result = 0;

            for (uint i = 2; i < maxnum; i++)
            {

                uint divisor = 2;
                uint maxdivisor = (uint)Math.Sqrt(i);
                bool prime = true;
                while (prime && divisor <= maxdivisor)
                {
                    if (i % divisor == 0)
                    {
                        prime = false;
                        break;
                    }
                    divisor++;


                }
                if (prime)
                {

                    result += i;




                    Console.WriteLine(result);

                }





            





        }
    }
    }
}
