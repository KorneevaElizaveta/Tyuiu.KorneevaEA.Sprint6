using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.KorneevaEA.Sprint6.Task1.V30.Lib
{
	public class DataService : ISprint6Task1V30
	{
		public double[] GetMassFunction(int startValue, int stopValue)
		{
			double[] valueArray;
			int len = (stopValue - startValue) + 1;
			valueArray = new double[len];
			double y;
			int count = 0;
			for (int x = startValue; x <= stopValue; x++)
			{
				y = Math.Round((2 * x - 3) / (Math.Cos(x) - 2 * x) + 5 * x - 6, 3);
				valueArray[count] = y;
				count++;
			}
			return valueArray;
		}
	}
}
