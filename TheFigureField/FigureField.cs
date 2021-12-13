namespace TheFigureField
{
    public class FigureField
    {
        public double SideA { get; set; }

        public double SideB { get; set; }

        public double Height { get; set; }

        public double DiagonalA { get; set; }

        public double DiagonalB { get; set; }

        public double Beam { get; set; }

        public double Result { get; set; }

        public double CalculateSquareField(double a)
        {
            return Result = a * a;
        }

        public double CalculateRectangleField(double a, double b)
        {
            return Result = a * b;
        }

        public double CalculateTriangleField(double a, double h)
        {
            return Result = a * h / 2;
        }

        public double CalculateRhombusField(double a, double h)
        {
            return Result = a * h;
        }

        public double CalculateTrapezoidField(double a, double b, double h)
        {
            return Result = (a + b) * h / 2;
        }

        public double CalculateCircleField(double r)
        {
            return Result = 3.1415 * (r * r);
        }


    }
}
