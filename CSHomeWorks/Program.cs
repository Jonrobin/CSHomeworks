﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CSHomeWorks;

namespace CSHomeWorks
{
    class Program
    {
        static void Main(string[] args)
        {
            HomeWork homeWork = new CSHomeWorks.Test.Test();
            homeWork.RunHomeWork();
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
