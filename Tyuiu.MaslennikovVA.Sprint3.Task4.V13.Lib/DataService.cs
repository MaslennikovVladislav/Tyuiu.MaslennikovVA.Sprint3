﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MaslennikovVA.Sprint3.Task4.V13.Lib
{
    public class DataService : ISprint3Task4V13
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 1;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res = res * (Math.Sin(x) / Math.Cos(x));
                }

            }
            return Math.Round(res, 3);
        }
    }
}