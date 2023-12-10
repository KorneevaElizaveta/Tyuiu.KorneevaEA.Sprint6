using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint6.Task0.V2.Lib;

namespace Tyuiu.KorneevaEA.Sprint6.Task0.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(1);
            double wait = 0.014;
            Assert.AreEqual(wait, res);
        }
    }
}
