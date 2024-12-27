using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Tyuiu.MaslennikovVA.Sprint3.Task3.V1.Lib;

namespace Tyuiu.MaslennikovVA.Sprint3.Task3.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetCharCount()
        {
            DataService ds = new DataService();
            string str = "have a nice time";
            char chr = 'a';

            double res = ds.GetCharCount(str, chr);
            int wait = 2;
            Assert.AreEqual(wait, res);

        }
    }
}
