using FiguresLib;

namespace FiguresTest;

public class TriangleTests
{

    [Fact]
    public void IsRightTriangle_3_4_5_True()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.IsRightTriangle();

        // Assert
        Assert.True(result);
    }

    [Fact]
    public void IsRightTriangle_3_4_6_False()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 6);

        // Act
        var result = triangle.IsRightTriangle();

        // Assert
        Assert.False(result);
    }

    [Fact]
    public void GetArea_3_4_5_6()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.GetArea();

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void GetArea_1000_1000_1000_4330127018922193()
    {
        // Arrange
        var triangle = new Triangle(1000, 1000, 1000);

        // Act
        var result = triangle.GetArea();

        // Assert
        Assert.Equal(433013, Math.Round(result));
    }

    [Fact]
    public void GetPerimeter_3_4_5_12()
    {
        // Arrange
        var triangle = new Triangle(3, 4, 5);

        // Act
        var result = triangle.GetPerimeter();

        // Assert
        Assert.Equal(12, result);
    }

    [Fact]
    public void Constructor_NegativeSide_ArgumentException()
    {
        // Arrange
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => new Triangle(-3, 4, 5));
    }

    [Fact]
    public void Constructor_ZeroSide_ArgumentException()
    {
        // Arrange
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => new Triangle(0, 4, 5));
    }

    [Fact]
    public void Constructor_3_4_6_ArgumentException()
    {
        // Arrange
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => new Triangle(3, 4, 1000));
    }

    [Fact]
    public void Constructor_3_4_5()
    {
        // Arrange
        // Act
        var triangle = new Triangle(3, 4, 5);

        // Assert
        Assert.Equal(3, triangle.A);
        Assert.Equal(4, triangle.B);
        Assert.Equal(5, triangle.C);
    }

    [Fact]
    public void Constructor_3_5_4()
    {
        // Arrange
        // Act
        var triangle = new Triangle(3, 5, 4);

        // Assert
        Assert.Equal(3, triangle.A);
        Assert.Equal(5, triangle.B);
        Assert.Equal(4, triangle.C);
    }
}