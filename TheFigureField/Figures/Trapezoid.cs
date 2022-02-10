using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFigureField
{
    public class Trapezoid : Figure
    {
        public double CalculateTrapezoidField()
        {
            return (SideA + SideB) * Height / 2;
        }
    }
}
