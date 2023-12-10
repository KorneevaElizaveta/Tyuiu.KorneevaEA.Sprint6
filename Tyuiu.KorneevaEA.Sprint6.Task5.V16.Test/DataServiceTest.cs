using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.KorneevaEA.Sprint6.Task5.V16.Lib;

namespace Tyuiu.KorneevaEA.Sprint6.Task5.V16.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidLoadFromDataFile()
        {
            string path = @"C:\Users\1\source\repos\Tyuiu.KorneevaEA.Sprint6\Tyuiu.KorneevaEA.Sprint6.Task5.V16\bin\Debug\InPutFileTask5V16.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
