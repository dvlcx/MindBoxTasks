using MindBoxLib.Figures;

namespace MindBoxLib.Tests;

public class CircleTests
{
    [Test]
    public void Constructor_ValidRadius_SetsRadiusCorrectly()
    {
        // Arrange
        var radius = 5.0;

        // Act
        var circle = new Circle(radius);

        // Assert
        Assert.That(circle.Radius, Is.EqualTo(radius));
    }

    [Test]
    public void Constructor_ZeroRadius_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var radius = 0.0;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }

    [Test]
    public void Constructor_NegativeRadius_ThrowsArgumentOutOfRangeException()
    {
        // Arrange
        var radius = -3.0;

        // Act & Assert
        Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius));
    }

    [Test]
    public void CalculateArea_ValidRadius_ReturnsCorrectArea()
    {
        // Arrange
        var radius = 3.0;
        var expectedArea = Math.PI * Math.Pow(radius, 2);

        // Act
        var circle = new Circle(radius);
        var actualArea = circle.CalculateArea();

        // Assert
        Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.001)); // Точность до 3 знаков после запятой
    }
}