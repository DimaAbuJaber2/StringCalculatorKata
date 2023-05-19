﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalcKata
{
    public class StringCalculatorKata
    {
        public static int Add(string numbers)
        {
            if (String.IsNullOrEmpty(numbers)) return 0;

            var Splitednumbers = numbers.Split(',');

            return Splitednumbers.Select(num => int.Parse(num)).Sum();

        }
    }
}