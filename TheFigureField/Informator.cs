using System;

namespace TheFigureField
{
    public class Informator
    {
        public string UserChoice { get; set; }

        public double Calculate { get; set; }

        public string Result { get; set; }

        public void Start()
        {
            Console.WriteLine("Witaj w programie, który pomoże Ci bez znajomości wzorów obliczyć pola danej figury.");
        }

        public void SelectYourFigureToCalculate()
        {
            Console.WriteLine("Proszę podaj z listy komend której figury pole chciałbyś obliczyć:");
            Console.WriteLine("0 - Wyjście z programu.");
            Console.WriteLine("1 - Oblicz pole kwadratu.");
            Console.WriteLine("2 - Oblicz pole prostokątu.");
            Console.WriteLine("3 - Oblicz pole trójkątu.");
            Console.WriteLine("4 - Oblicz pole równoległoboku.");
            Console.WriteLine("5 - Oblicz pole rombu.");
            Console.WriteLine("6 - Oblicz pole trapezu.");
            Console.WriteLine("7 - Oblicz pole koła.");

            UserChoice = Console.ReadLine();

            if (UserChoice == "0")
            {
                return;
            }
            else if (UserChoice == "1")
            {
                var square = new Square();
                Console.WriteLine("Podaj długość boku kwadratu w cm.");
                square.SideA = double.Parse(Console.ReadLine());
                Calculate = square.CalculateSquareField();
            }
            else if (UserChoice == "2")
            {
                var rectangle = new Rectangle();
                Console.WriteLine("Podaj długość pierwszego boku prostokątu w cm.");
                rectangle.SideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj długość drugiego boku prostokątu w cm.");
                rectangle.SideB = double.Parse(Console.ReadLine());
                Calculate = rectangle.CalculateRectangleField();
            }
            else if (UserChoice == "3")
            {
                var triangle = new Triangle();
                Console.WriteLine("Podaj długość podstawy trójkątu w cm.");
                triangle.SideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wysokość trójkątu w cm.");
                triangle.Height = double.Parse(Console.ReadLine());
                Calculate = triangle.CalculateTriangleField();
            }
            else if (UserChoice == "4" || UserChoice == "5")
            {
                var rhombus = new Rhombus();
                Console.WriteLine("Podaj długość boku równoległoboku lub rombu w cm.");
                rhombus.SideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wysokość równoległoboku lub rombu w cm.");
                rhombus.Height = double.Parse(Console.ReadLine());
                Calculate = rhombus.CalculateRhombusField();
            }
            else if (UserChoice == "6")
            {
                var trapezoid = new Trapezoid();
                Console.WriteLine("Podaj pierwszą podstawę trapezu w cm.");
                trapezoid.SideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą podstawę trapezu w cm.");
                trapezoid.SideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wysokość trapezu w cm.");
                trapezoid.Height = double.Parse(Console.ReadLine());
                Calculate = trapezoid.CalculateTrapezoidField();
            }
            else if (UserChoice == "7")
            {
                var circle = new Circle();
                Console.WriteLine("Podaj długość promienia koła w cm.");
                circle.Beam = double.Parse(Console.ReadLine());
                Calculate = circle.CalculateCircleField();
            }
            else
            {
                Console.WriteLine("Wpisano nie prawidłową komendę! Spróbuj ponownie.");
                SelectYourFigureToCalculate();
                return;
            }

            Result = $"Pole tej figury wynosi: {Calculate} cm2";
            Console.WriteLine(Result);
            SelectYourFigureToCalculate();

        }
    }
}
