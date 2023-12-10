using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint6.Task1.V30.Lib;

namespace Tyuiu.KorneevaEA.Sprint6.Task1.V30.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
		public void ValidGetMassFunction()
		{
			DataService ds = new DataService();
			double[] array = ds.GetMassFunction(-5, 5);
			int len = array.Length;
			double[] wait = new double[len];
			{
				wait[0] = -32.26;
				wait[1] = -27.5;
				wait[2] = -22.8;
				wait[3] = -17.95;
				wait[4] = -12.97;
				wait[5] = -9;
				wait[6] = -0.32;
				wait[7] = 3.77;
				wait[8] = 8.57;
				wait[9] = 13.42;
				wait[10] = 18.28;

			}
		}
	}
}
