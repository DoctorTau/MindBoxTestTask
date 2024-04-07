namespace FiguresLib;

/// <summary>
/// Represents a geometric figure.
/// </summary>
public abstract class Figure
{
    /// <summary>
    /// Calculates the area of the figure.
    /// </summary>
    /// <returns>The area of the figure.</returns>
    public abstract double GetArea();

    /// <summary>
    /// Calculates the perimeter of the figure.
    /// </summary>
    /// <returns>The perimeter of the figure.</returns>
    public abstract double GetPerimeter();
}
