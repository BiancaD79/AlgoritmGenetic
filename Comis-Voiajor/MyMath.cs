﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comis_Voiajor
{
    public static class MyMath
    {
        public static float Distance(PointF A, PointF B)
        {
            return (float)Math.Sqrt((A.X - B.X)* (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y));
        }
    }
}
