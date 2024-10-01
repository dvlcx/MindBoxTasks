using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MindBoxLib.Figures;
using NUnit.Framework;

namespace MindBoxLib.Tests
{
    public class TriangleTests
    {
[Test]
        public void Constructor_ValidSides_SetsSidesCorrectly()
        {
            // Arrange
            var firstSide = 3.0;
            var secondSide = 4.0;
            var thirdSide = 5.0;

            // Act
            var triangle = new Triangle(firstSide, secondSide, thirdSide);

            // Assert
            Assert.That(triangle.FirstSide, Is.EqualTo(firstSide));
            Assert.That(triangle.SecondSide, Is.EqualTo(secondSide));
            Assert.That(triangle.ThirdSide, Is.EqualTo(thirdSide));  

        }

        [Test]
        public void Constructor_ZeroSide_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var firstSide = 3.0;
            var secondSide = 4.0;
            var thirdSide = 0.0;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        [Test]
        public void Constructor_NegativeSide_ThrowsArgumentOutOfRangeException()
        {
            // Arrange
            var firstSide = 3.0;
            var secondSide = 4.0;
            var thirdSide = -5.0;

            // Act & Assert
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        [Test]
        public void Constructor_InvalidTriangleSides_ThrowsArgumentException()
        {
            // Arrange
            var firstSide = 1.0;
            var secondSide = 2.0;
            var thirdSide = 4.0; // Sides don't form a triangle

            // Act & Assert
            Assert.Throws<ArgumentException>(() => new Triangle(firstSide, secondSide, thirdSide));
        }

        [Test]
        public void CalculateArea_ValidTriangle_ReturnsCorrectArea()
        {
            // Arrange
            var firstSide = 3.0;
            var secondSide = 4.0;
            var thirdSide = 5.0;
            var expectedArea = 6.0; // Area of a right-angled triangle

            // Act
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var actualArea = triangle.CalculateArea();

            // Assert
            Assert.That(actualArea, Is.EqualTo(expectedArea).Within(0.001));
        }

        [Test]
        public void IsRightAngled_RightAngledTriangle_ReturnsTrue()
        {
            // Arrange
            var firstSide = 3.0;
            var secondSide = 4.0;
            var thirdSide = 5.0; // Right-angled triangle

            // Act
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsTrue(isRightAngled);
        }

        [Test]
        public void IsRightAngled_NotRightAngledTriangle_ReturnsFalse()
        {
            // Arrange
            var firstSide = 2.0;
            var secondSide = 3.0;
            var thirdSide = 4.0; // Not a right-angled triangle

            // Act
            var triangle = new Triangle(firstSide, secondSide, thirdSide);
            var isRightAngled = triangle.IsRightAngled();

            // Assert
            Assert.IsFalse(isRightAngled);
        }
    }
}