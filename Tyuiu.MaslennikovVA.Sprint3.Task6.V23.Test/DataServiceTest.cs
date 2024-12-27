using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MaslennikovVA.Sprint3.Task6.V23.Lib;

namespace Tyuiu.MaslennikovVA.Sprint3.Task6.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumTheDivisors()
        {
            DataService ds = new DataService();

            int startValue = 10;
            int stopValue = 15;
            int res = ds.GetSumTheDivisors(startValue, stopValue);
            int wait = 10;
            Assert.AreEqual(wait, res);

        }
    }
}