using System;

namespace Assignment1
{
    class Program
    {

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("write the first number");
                int firstNumber = int.Parse(Console.ReadLine());


                Console.WriteLine("write the second number");
                int secondNumber = int.Parse(Console.ReadLine());
                int AddNumber = firstNumber + secondNumber;
                
                if (firstNumber==30 || secondNumber==30|| AddNumber==30)
                {
                    Console.WriteLine(true);

                }
                else
                {
                    Console.WriteLine(false);
                }
            }
            catch (Exception )
            {
                Console.WriteLine("An error occoured please enter an integer");
               
            }
              

        }
    }
}
