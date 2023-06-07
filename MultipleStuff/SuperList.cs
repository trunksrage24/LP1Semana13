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

        // Helper method to update the minimum and maximum values
        private void UpdateMinMax(out double min, out double max, double value)
        {
            min = Math.Min(min, value);
            max = Math.Max(max, value);
        }

        // Method to get the minimum and maximum values using a nested class
        public (double Min, double Max) GetMinMax2()
        {
            MinMaxPair pair = new MinMaxPair();

            foreach (var item in this)
            {
                pair.UpdateMinMax(item);
            }

            return (Min: pair.Min, Max: pair.Max);
        }

        // internal class to store the minimum and maximum values
        private class MinMaxPair
        {
            public double Min { get; private set; } = double.MaxValue;
            public double Max { get; private set; } = double.MinValue;

            public void UpdateMinMax(double value)
            {
                Min = Math.Min(Min, value);
                Max = Math.Max(Max, value);
            }
        }
    }
}