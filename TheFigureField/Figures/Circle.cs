using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheFigureField
{
    public class Circle : Figure
    {
        public double CalculateCircleField()
        {
            return 3.1415 * (Beam * Beam);
        }

    }
}
