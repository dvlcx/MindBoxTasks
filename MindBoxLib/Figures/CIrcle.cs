namespace MindBoxLib.Figures;

public class Circle : IFigure
{
    public double Radius { get; private set; }

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentOutOfRangeException(nameof(radius), "Radius cannot be equal or less than zero!");
        }

        Radius = radius;
    }

    public double CalculateArea()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
}
