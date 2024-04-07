using FiguresLib;

namespace FiguresTest;

public class RoundTests
{

    [Fact]
    public void Constructor_NegativeRadius_ArgumentException()
    {
        // Arrange
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => new Round(-1));
    }

    [Fact]
    public void Constructor_ZeroRadius_ArgumentException()
    {
        // Arrange
        // Act
        // Assert
        Assert.Throws<ArgumentException>(() => new Round(0));
    }

    [Fact]
    public void GetArea_10_314()
    {
        // Arrange
        var round = new Round(10);

        // Act
        var result = round.GetArea();

        // Assert
        Assert.Equal(314, Math.Round(result));
    }

    [Fact]
    public void GetArea_100_31416()
    {
        // Arrange
        var round = new Round(100);

        // Act
        var result = round.GetArea();

        // Assert
        Assert.Equal(31416, Math.Round(result));
    }

    [Fact]
    public void GetPerimeter_10_62()
    {
        // Arrange
        var round = new Round(10);

        // Act
        var result = round.GetPerimeter();

        // Assert
        Assert.Equal(63, Math.Round(result));
    }

    [Fact]
    public void GetPerimeter_100_628()
    {
        // Arrange
        var round = new Round(100);

        // Act
        var result = round.GetPerimeter();

        // Assert
        Assert.Equal(628, Math.Round(result));
    }
}