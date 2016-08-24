﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake1
{
    class Figure
    {
        protected List<Point> pList;

        public void Print()
        {
            foreach (Point p in pList)
                p.Draw();
        }
    }
}
