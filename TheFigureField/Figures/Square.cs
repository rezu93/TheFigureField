using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFigureField
{
    public class Square : Figure
    {
        public double CalculateSquareField()
        {
            return SideA * SideA;
        }
    }
}
