using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFigureField
{
    public class Rhombus : Figure
    {
        public double CalculateRhombusField()
        {
            return SideA * Height;
        }
    }
}
