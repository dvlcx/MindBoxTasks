namespace MindBoxLib.Figures
{
    public class Triangle : IFigure
    {
        public double FirstSide { get; private set; }
        public double SecondSide { get; private set;}
        public double ThirdSide { get; private set;}

        public Triangle(double firstSide, double secondSide, double thirdSide)
        {
            if (firstSide <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(firstSide), "Side cannot be equal or less than zero!");
            }

            if (secondSide <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(secondSide), "Side cannot be equal or less than zero!");
            }

            if (thirdSide <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(thirdSide), "Side cannot be equal or less than zero!");
            }

            if (!(firstSide + secondSide > thirdSide && firstSide + thirdSide > secondSide && secondSide + thirdSide > firstSide))
            {
                throw new ArgumentException("Triangle with such sides cannot exist!");
            }

            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
        }

        public double CalculateArea()
        {
            var semiPerimeter = (FirstSide + SecondSide + ThirdSide) / 2;
            var result = Math.Sqrt(semiPerimeter * (semiPerimeter - FirstSide) * (semiPerimeter - SecondSide) * (semiPerimeter - ThirdSide));
            return result;
        }

        public bool IsRightAngled()
        {
            double[] sides = [FirstSide, SecondSide, ThirdSide];
            Array.Sort(sides);
            if (Math.Pow(sides[2], 2) != Math.Pow(sides[1], 2) + Math.Pow(sides[0], 2))
            {
                return false;
            }
            return true;
        }
    }
}