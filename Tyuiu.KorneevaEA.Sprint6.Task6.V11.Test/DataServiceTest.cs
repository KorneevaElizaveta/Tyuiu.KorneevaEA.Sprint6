using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KorneevaEA.Sprint6.Task6.V11.Lib;

namespace Tyuiu.KorneevaEA.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCollectTextFromFile()
        {
            DataService ds = new DataService();
            string wait = "btwMCZUcB PADUsjhlu JmjQKHd TMRyztkPxzEVkcarVMlQ EUWCvEgL";
            string path = @"C:\DataSprint6\InPutFileTask6V11.txt";
            string res = ds.CollectTextFromFile(path);
            Assert.AreEqual(res, wait);
        }
    }
}
