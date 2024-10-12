namespace InternTask.Lib;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        if (radius <= 0)
        {
            throw new ArgumentException("radius must be greater than 0");
        }

        _radius = radius;
    }

    public double GetSurface()
    {
        return Math.PI * _radius * _radius;
    }
}
