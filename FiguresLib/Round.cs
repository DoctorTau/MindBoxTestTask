namespace FiguresLib;

/// <summary>
/// Represents a round figure with a given radius.
/// </summary>
public class Round : Figure
{
    public double Radius { get; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Round"/> class with the specified radius.
    /// </summary>
    /// <param name="radius">The radius of the round figure.</param>
    /// <exception cref="ArgumentException">Thrown when the radius is less than or equal to zero.</exception>
    public Round(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Radius must be positive");
        Radius = radius;
    }

    /// <summary>
    /// Calculates and returns the area of the round figure.
    /// </summary>
    /// <returns>The area of the round figure.</returns>
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }

    /// <summary>
    /// Calculates and returns the perimeter of the round figure.
    /// </summary>
    /// <returns>The perimeter of the round figure.</returns>
    public override double GetPerimeter()
    {
        return 2 * Math.PI * Radius;
    }
}