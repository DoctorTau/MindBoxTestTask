namespace FiguresLib;

/// <summary>
/// Represents a triangle figure.
/// </summary>
public class Triangle : Figure
{
    public double A { get; }
    public double B { get; }
    public double C { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Triangle"/> class with the specified side lengths.
    /// </summary>
    /// <param name="a">The length of side A.</param>
    /// <param name="b">The length of side B.</param>
    /// <param name="c">The length of side C.</param>
    /// <exception cref="ArgumentException">Thrown when any side length is less than or equal to zero or when the triangle with the given side lengths does not exist.</exception>
    public Triangle(double a, double b, double c)
    {
        // Check that sides are positive
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Sides must be positive");
        // Check that triange with the given side lengths exists
        if (a + b <= c || a + c <= b || b + c <= a)
            throw new ArgumentException("Triangle with the given side lengths does not exist");
        A = a;
        B = b;
        C = c;
    }

    /// <summary>
    /// Calculates the area of the triangle.
    /// </summary>
    /// <returns>The area of the triangle.</returns>
    public override double GetArea()
    {
        double p = (A + B + C) / 2;
        return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
    }

    /// <summary>
    /// Calculates the perimeter of the triangle.
    /// </summary>
    /// <returns>The perimeter of the triangle.</returns>
    public override double GetPerimeter()
    {
        return A + B + C;
    }

    /// <summary>
    /// Determines whether the triangle is a right triangle.
    /// </summary>
    /// <returns><c>true</c> if the triangle is a right triangle; otherwise, <c>false</c>.</returns>
     public bool IsRightTriangle()
    {
        double[] sides = [A, B, C];
        Array.Sort(sides);
        return sides[0] * sides[0] + sides[1] * sides[1] == sides[2] * sides[2];
    }
}