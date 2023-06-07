using System;

namespace MultipleStuff
{

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of SuperList containing multiple numbers
            SuperList superList = new SuperList(new double[] { 10.5, 7.2, 15.8, 3.6, 9.1 });

            // Get and print the minimum and maximum using the three implemented methods
            var minMax1 = superList.GetMinMax1();
            Console.WriteLine($"Minimum: {minMax1.Min}, Maximum: {minMax1.Max}");

            var minMax2 = superList.GetMinMax2();
            Console.WriteLine($"Minimum: {minMax2.Min}, Maximum: {minMax2.Max}");

            var minMax3 = superList.GetMinMax3();
            Console.WriteLine($"Minimum: {minMax3.Min}, Maximum: {minMax3.Max}");

            var minMax4 = superList.GetMinMax4();
            Console.WriteLine($"Minimum: {minMax4.Min}, Maximum: {minMax4.Max}");
        }
    }
}
