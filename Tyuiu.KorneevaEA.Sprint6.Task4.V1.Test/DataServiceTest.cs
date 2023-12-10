using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint6.Task4.V1.Lib;

namespace Tyuiu.KorneevaEA.Sprint6.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();
            int startValue = -5;
            int stopValue = 5;
            double[] array = new double[-startValue + stopValue + 1];
            array[0] = -12.18;
            array[1] = 16.03;
            array[2] = 18.87;
            array[3] = 4.96;
            array[4] = -9.99;
            array[5] = -2;
            array[6] = 2.16;
            array[7] = -7.54;
            array[8] = -22.76;
            array[9] = -20.45;
            array[10] = 7.77;

            double[] checkArray = ds.GetMassFunction(startValue, stopValue);

            CollectionAssert.AreEqual(checkArray, array);
        }
    }
}
