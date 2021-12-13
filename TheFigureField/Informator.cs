using System;

namespace TheFigureField
{
    public class Informator : FigureField
    {
        public string UserChoice { get; set; }


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
                Console.WriteLine("Podaj długość boku kwadratu w cm.");
                SideA = double.Parse(Console.ReadLine());
                CalculateSquareField(SideA);
            }
            else if (UserChoice == "2")
            {
                Console.WriteLine("Podaj długość pierwszego boku prostokątu w cm.");
                SideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj długość drugiego boku prostokątu w cm.");
                SideB = double.Parse(Console.ReadLine());
                CalculateRectangleField(SideA, SideB);
            }
            else if (UserChoice == "3")
            {
                Console.WriteLine("Podaj długość podstawy trójkątu w cm.");
                SideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wysokość trójkątu w cm.");
                Height = double.Parse(Console.ReadLine());
                CalculateTriangleField(SideA, Height);
            }
            else if (UserChoice == "4")
            {
                Console.WriteLine("Podaj długość boku równoległoboku w cm.");
                SideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wysokość równoległoboku w cm.");
                Height = double.Parse(Console.ReadLine());
                CalculateRhombusField(SideA, Height);
            }
            else if (UserChoice == "5")
            {
                Console.WriteLine("Podaj długość boku rombu w cm.");
                SideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wysokość rombu w cm.");
                Height = double.Parse(Console.ReadLine());
                CalculateRhombusField(SideA, Height);
            }
            else if (UserChoice == "6")
            {
                Console.WriteLine("Podaj pierwszą podstawę trapezu w cm.");
                SideA = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj drugą podstawę trapezu w cm.");
                SideB = double.Parse(Console.ReadLine());
                Console.WriteLine("Podaj wysokość trapezu w cm.");
                Height = double.Parse(Console.ReadLine());
                CalculateTrapezoidField(SideA, SideB, Height);
            }
            else if (UserChoice == "7")
            {
                Console.WriteLine("Podaj długość promienia koła w cm.");
                Beam = double.Parse(Console.ReadLine());
                CalculateCircleField(Beam);
            }
            else
            {
                Console.WriteLine("Wpisano nie prawidłową komendę! Spróbuj ponownie.");
                SelectYourFigureToCalculate();
                return;
            }

            FigureFieldResult();

        }

        public void FigureFieldResult()
        {
            
            Console.WriteLine("Pole tej figury wynosi: " + Result + "cm2");
            SelectYourFigureToCalculate();
        }

    }
}
