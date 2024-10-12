using System.Diagnostics;

namespace InternTask.Lib;

public class Triangle : IFigure
{
    private readonly double _a, _b, _c;

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
        {
            throw new ArgumentException("the side length must be greater than 0");
        }

        _a = a;
        _b = b;
        _c = c;
    }

    public double GetSurface()
    {
        var p = _a + _b + _c;
        var s = p * (p - _a) * (p - _b) * (p - _c);

        return Math.Sqrt(s);
    }

    public bool IsRightTriangle()
    {
        var c2 = Math.Pow(GetHypotenuse(), 2);

        var (a, b) = GetLegs();

        var a2b2 = Math.Pow(a, 2) + Math.Pow(b, 2);

        return c2 == a2b2;
    }

    private double GetHypotenuse()
    {
        return _a > _b ? _a > _c ? _a : _c : _b > _c ? _b : _c;
    }

    private (double a, double b) GetLegs()
    {
        var arr = new double[3] {_a, _b, _c};

        arr = [.. arr.Order()];

        return (arr[0], arr[1]);
    }
}
