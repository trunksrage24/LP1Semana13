using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{

    public class SuperList : List<double>
    {
        // Constructor for SuperList
        public SuperList(IEnumerable<double> collection) : base(collection)
        {
        }

        // Method to get the minimum and maximum values using out parameters
        public (double Min, double Max) GetMinMax1()
        {
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (var item in this)
            {
                UpdateMinMax(out min, out max, item);
            }

            return (Min: min, Max: max);
        }
    }
}