﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intermediate
{
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public void Draw()
        {
            Console.WriteLine("draw function calling from shape class");
        }
    }
}
