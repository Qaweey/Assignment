using System;
using System.Collections.Generic;
using System.Linq;

namespace assignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("write the word");

                string word = Console.ReadLine().ToLower();



                //To check if the word start with "Sa"
                if (word.StartsWith("sa"))
                {
                    char[] character = word.ToCharArray();
                    //convert the array of character  to list of characters
                    var listOfChar = character.ToList();
                    listOfChar.RemoveAll(s => s.Equals('e'));
                    listOfChar.RemoveAll(s => s.Equals('m'));
                    int result = 0;
                    result += listOfChar.Count();


                    Console.WriteLine($"The valid number of character is {result}");

                }
                else
                {
                    Console.WriteLine("The input is not valid");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("An error occured please try again");
            }
        }
    }
}
