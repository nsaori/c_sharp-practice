﻿//p.509-514 Linq

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasic
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            /*
            List<int> output = new List<int>();
            foreach (int item in input)
            {
                if (item % 2 == 0) {
                    output.Add(item);
                }
            }*/
            //sql랑 분법이 똑같대
            var output = from item in input
                         where item % 2 == 0
                         select item;
           
                foreach (int item in output)
            {
                Console.WriteLine(item);
            }
        }
    }
}
