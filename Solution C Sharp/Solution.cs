﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Solution_C_Sharp
{
    internal class Solution
    {
        public static int Summary() {

            string?input;
            int result = 0;

            Console.WriteLine("Input Number Integer: ");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++) {
                int temp = Convert.ToInt32(input[i]) - '0';
                result += temp;
            }
            return result;
        }
    }
}