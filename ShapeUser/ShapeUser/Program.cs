﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Page48_Shapes;

namespace ShapeUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c = new Circle(1.0F);
            Console.WriteLine("{0}", c.Area());
        }
    }
}
