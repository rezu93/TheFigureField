using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFigureField
{
    public class Triangle : Figure
    {
        public double CalculateTriangleField()
        {
            return SideA * Height / 2;
        }
    }
}
