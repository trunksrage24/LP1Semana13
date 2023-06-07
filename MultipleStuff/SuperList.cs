using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MultipleStuff
{

    public class SuperList : List<double>
    {
        public (double min, double max) GetMinMax1(out double min, out double max)
        {
            min = double.MaxValue;
            max = double.MinValue;

            foreach (double number in this)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }

            return (min, max);
        }

        public (double min, double max) GetMinMax2()
        {
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double number in this)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }

            return (min, max);
        }

        public void GetMinMax3(ref double min, ref double max)
        {
            min = double.MaxValue;
            max = double.MinValue;

            foreach (double number in this)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }
        }

        public (double Min, double Max) GetMinMax4()
        {
            double min = double.MaxValue;
            double max = double.MinValue;

            foreach (double number in this)
            {
                if (number < min)
                    min = number;
                if (number > max)
                    max = number;
            }

            return (Min: min, Max: max);
        }
    }
}