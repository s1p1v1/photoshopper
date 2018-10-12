﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MyPhotoshop
{
    public class Pixel
    {   
        public double Check(double value)
        {
            if (value < 0 || value > 1) throw new ArgumentException();
                return value;
        }

        public static double Trim(double value)
        {
            if (value < 0) return 0;
            if (value > 1) return 1;
            return value;
        }

        double r;
        public double R
        {
            get { return r; }
            set
            {
                r = Check(value);
            }
        }

        double g;
        public double G
        {
            get { return g; }
            set
            {
                g = Check(value);
            }
        }

        double b;
        public double B
        {
            get { return b; }
            set
            {
                b = Check(value);
            }
        }
        
       
    }
}
