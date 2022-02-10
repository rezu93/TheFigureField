using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFigureField
{
    public class Rectangle : Figure
    {
        public double CalculateRectangleField()
        {
            return SideA * SideB;
        }

    }
}
