using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KorneevaEA.Sprint6.Task4.V1.Lib
{
    public class DataService : ISprint6Task4V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array = new double[-startValue + stopValue + 1];
            for (int i = 0, x = startValue; x <= stopValue; x++, i++)
            {
                array[i] = Math.Round(((Math.Sin(x)) / (x + 1.2)) + Math.Cos(x) * 7 * x - 2, 2);
            }

            return array;
        }
    }
}
