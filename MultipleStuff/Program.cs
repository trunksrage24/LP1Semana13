using System;

namespace MultipleStuff
{

    public class Program
    {
        public static void Main()
        {
            SuperList superList = new SuperList();
            superList.Add(8.8);
            superList.Add(1.4);
            superList.Add(78.5);
            superList.Add(79.7);

            double min1, max1;
            (double min2, double max2) = superList.GetMinMax1(out min1,
                                                              out max1);
            Console.WriteLine($"Versão 1: Min = {min1}, Max = {max1}");

            (double min3, double max3) = superList.GetMinMax2();
            Console.WriteLine($"Versão 2: Min = {min3}, Max = {max3}");

            double min4 = double.MaxValue, max4 = double.MinValue;
            superList.GetMinMax3(ref min4, ref max4);
            Console.WriteLine($"Versão 3: Min = {min4}, Max = {max4}");

            (double Min5, double Max5) = superList.GetMinMax4();
            Console.WriteLine($"Versão 4: Min = {Min5}, Max = {Max5}");
        }
    }
}
