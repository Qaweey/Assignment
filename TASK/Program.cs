using System;
using System.Collections.Generic;

namespace TASK
{
    class Program
    {
        static void Main(string[] args)
        {
            var listOfMean = new List<decimal>();
            Console.WriteLine("Welcome!!!! please enter the Newspapers you intend to sell and enter the data reqiured for each Newspaper ");
            Console.WriteLine("Please enter the name of the first Newspaper");
            string firstNewspaper = Console.ReadLine();
            var weeklyIncome1 = new List<decimal>();
            Console.WriteLine($"Enter the quantity and price  sold  for each week with {firstNewspaper} Newspaper ");

            Console.WriteLine("Week 1");
            int qty1 = int.Parse(Console.ReadLine());
            decimal price1 = decimal.Parse(Console.ReadLine());
            var income1 = price1 * qty1;
            weeklyIncome1.Add(income1);

            Console.WriteLine("Week 2");
            int qty2 = int.Parse(Console.ReadLine());
            decimal price2 = decimal.Parse(Console.ReadLine());
            var income2 = price2 * qty2;
            weeklyIncome1.Add(income2);

            Console.WriteLine("Week 3");
            int qty3 = int.Parse(Console.ReadLine());
            decimal price3 = decimal.Parse(Console.ReadLine());
            var income3 = price3 * qty3;
            weeklyIncome1.Add(income3);

            Console.WriteLine("Week 4");
            int qty4 = int.Parse(Console.ReadLine());
            decimal price4 = decimal.Parse(Console.ReadLine());
            var income4 = price4 * qty4;
            weeklyIncome1.Add(income4);

            decimal firstMeanIncome = 0;
            foreach (var item in weeklyIncome1)
            {
                firstMeanIncome += item / weeklyIncome1.Count;
            }
            listOfMean.Add(firstMeanIncome);

            Console.WriteLine("-----------------------------------------");


            //For Second Newspaper
            var weeklyIncome2 = new List<decimal>();

            Console.WriteLine("Please enter the name of the second  Newspaper");
            string secondNewspaper = Console.ReadLine();
            Console.WriteLine($"Enter the quantity and price sold  for each week with {secondNewspaper} Newspaper ");
            Console.WriteLine("Week 1");
            int secondQty1 = int.Parse(Console.ReadLine());
            decimal secondPrice1 = decimal.Parse(Console.ReadLine());
            var secondIncome1 = secondPrice1 * secondQty1;
            weeklyIncome2.Add(secondIncome1);

            Console.WriteLine("Week 2");
            int secondQty2 = int.Parse(Console.ReadLine());
            decimal secondPrice2 = decimal.Parse(Console.ReadLine());
            var secondIncome2 = secondPrice2 * secondQty2;
            weeklyIncome2.Add(secondIncome2);

            Console.WriteLine("Week 3");
            int secondQty3 = int.Parse(Console.ReadLine());
            decimal secondPrice3 = decimal.Parse(Console.ReadLine());
            var secondincome3 = secondPrice3 * secondQty3;
            weeklyIncome2.Add(secondincome3);

            Console.WriteLine("Week 4");
            int secondQty4 = int.Parse(Console.ReadLine());
            decimal secondPrice4 = decimal.Parse(Console.ReadLine());
            var secondIncome4 = secondPrice4 * secondQty4;
            weeklyIncome2.Add(secondIncome4);

            decimal secondMeanIncome = 0;
            foreach (var item in weeklyIncome2)
            {
                secondMeanIncome += item / weeklyIncome2.Count;
            }
            listOfMean.Add(secondMeanIncome);

            Console.WriteLine("-----------------------------------------");

            // For third Newspaper
            var weeklyIncome3 = new List<decimal>();
            Console.WriteLine("Please enter the name of the third Newspaper");
            string thirdNewspaper = Console.ReadLine();
            Console.WriteLine($"Enter the quantity and price sold  for each week with {thirdNewspaper} Newspaper ");
            Console.WriteLine("Week 1");
            int thirdQty1 = int.Parse(Console.ReadLine());
            decimal thirdPrice1 = decimal.Parse(Console.ReadLine());
            var thirdIncome1 = thirdPrice1 * thirdQty1;
            weeklyIncome3.Add(thirdIncome1);

            Console.WriteLine("Week 2");
            int thirdQty2 = int.Parse(Console.ReadLine());
            decimal thirdPrice2 = decimal.Parse(Console.ReadLine());
            var thirdIncome2 = thirdPrice2 * thirdQty2;
            weeklyIncome3.Add(thirdIncome2);

            Console.WriteLine("Week 3");
            int thirdQty3 = int.Parse(Console.ReadLine());
            decimal thirdPrice3 = decimal.Parse(Console.ReadLine());
            var thirdincome3 = thirdPrice3 * thirdQty3;
            weeklyIncome3.Add(thirdincome3);

            Console.WriteLine("Week 4");
            int thirdQty4 = int.Parse(Console.ReadLine());
            decimal thirdPrice4 = decimal.Parse(Console.ReadLine());
            var thirdIncome4 = thirdPrice4 * thirdQty4;
            weeklyIncome3.Add(thirdIncome4);

            decimal thirdMeanIncome = 0;
            foreach (var item in weeklyIncome3)
            {
                thirdMeanIncome += item / weeklyIncome3.Count;
            }
            listOfMean.Add(thirdMeanIncome);

            Console.WriteLine("-----------------------------------------");


            // For the forth Newspaper
            var weeklyIncome4 = new List<decimal>();
            Console.WriteLine("Please enter the name of the forth  Newspaper");
            string forthNewspaper = Console.ReadLine();
            Console.WriteLine($"Enter the price and quantity sold  for each week with {forthNewspaper} Newspaper ");
            Console.WriteLine("Week 1");
            int forthQty1 = int.Parse(Console.ReadLine());
            decimal forthPrice1 = decimal.Parse(Console.ReadLine());
            var forthIncome1 = forthPrice1 * forthQty1;
            weeklyIncome4.Add(forthIncome1);

            Console.WriteLine("Week 2");
            int forthQty2 = int.Parse(Console.ReadLine());
            decimal forthPrice2 = decimal.Parse(Console.ReadLine());
            var forthIncome2 = forthPrice2 * forthQty2;
            weeklyIncome4.Add(forthIncome2);

            Console.WriteLine("Week 3");
            int forthQty3 = int.Parse(Console.ReadLine());
            decimal forththPrice3 = decimal.Parse(Console.ReadLine());
            var forthincome3 = forththPrice3 * forthQty3;
            weeklyIncome4.Add(forthincome3);

            Console.WriteLine("Week 4");
            int forthQty4 = int.Parse(Console.ReadLine());
            decimal forthPrice4 = decimal.Parse(Console.ReadLine());
            var forthIncome4 = forthPrice4 * forthQty4;
            weeklyIncome4.Add(forthIncome4);

            decimal forthMeanIncome = 0;
            foreach (var item in weeklyIncome4)
            {
                forthMeanIncome += item / weeklyIncome4.Count;
            }
            listOfMean.Add(forthMeanIncome);

            //Finding the higest average mean and the equivalent Newspaper

            listOfMean.Sort();


            if (listOfMean[listOfMean.Count - 1] == firstMeanIncome)
            {
                Console.WriteLine($"From the analysis it is advisable to go for {firstNewspaper} Newspaper because it has the highest average income of {firstMeanIncome} ");
            }
            if (listOfMean[listOfMean.Count - 1] == secondMeanIncome)
            {
                Console.WriteLine($"From the analysis it is advisable to go for {secondNewspaper} Newspaper because it has the highest  average income of {secondMeanIncome} ");
            }
            if (listOfMean[listOfMean.Count - 1] == thirdMeanIncome)
            {
                Console.WriteLine($"From the analysis it is advisable to go for {thirdNewspaper} Newspaper because it has the highest  average income of {thirdMeanIncome} ");
            }
            if (listOfMean[listOfMean.Count - 1] == forthMeanIncome)
            {
                Console.WriteLine($"From the analysis it is advisable to go for {forthNewspaper} Newspaper because it has the highest  average income of {forthMeanIncome} ");
            }

        
    }
    }
}
