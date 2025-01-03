﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Tyuiu.MaslennikovVA.Sprint3.Task0.V26.Lib;



namespace Tyuiu.MaslennikovVA.Sprint3.Task0.V26.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMultiplySeries()
        {
            DataService ds = new DataService();

            int startValue = 1;
            int stopValue = 9;

            double res = ds.GetMultiplySeries(startValue, stopValue);

            double wait = -15.642;

            Assert.AreEqual(wait, res);
        }
    }
}
