using AreaCalculator.Shapes;
using System;
using Xunit;

namespace AreaCalculator.Test;

public class TriangleTest
{
    [Fact]
    private void CreationOfTriangleWithNaNSides_ShouldThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(double.NaN, 1, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, double.NaN, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, double.NaN));
    }
    
    [Fact]
    private void CreationOfTriangleWithInfinitySides_ShouldThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(double.PositiveInfinity, 1, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, double.PositiveInfinity, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, double.PositiveInfinity));
        Assert.Throws<ArgumentException>(() => new Triangle(double.NegativeInfinity, 1, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, double.NegativeInfinity, 1));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 1, double.NegativeInfinity));
    }
    
    [Fact]
    private void CreationOfImpossibleTriangle_ShouldThrowsArgumentException()
    {
        Assert.Throws<ArgumentException>(() => new Triangle(1, 2, 5));
        Assert.Throws<ArgumentException>(() => new Triangle(1, 5, 2));
        Assert.Throws<ArgumentException>(() => new Triangle(5, 1, 2));
    }
    
    [Fact]
    private void CreationOfTriangleWithNegativeSides_SidesPropsShouldBePositive()
    {
        var triangle = new Triangle(-1, -1, -1);
        Assert.Equal(1, triangle.Side1);
        Assert.Equal(1, triangle.Side2);
        Assert.Equal(1, triangle.Side3);
    }

    [Fact]
    private void HasRightAngle_Test()
    {
        Assert.True(new Triangle(3, 4, 5).HasRightAngle());
        Assert.False(new Triangle(1, 1, 1).HasRightAngle());
        Assert.True(new Triangle(10, 8, 6).HasRightAngle());
        Assert.False(new Triangle(24, 32, 44).HasRightAngle());
    }
    
    [Fact]
    private void CalculateArea_Test()
    {
        Assert.Equal(6, new Triangle(3, 4, 5).CalculateArea());
        Assert.Equal(0.433, Math.Round(new Triangle(-1, -1, -1).CalculateArea(), 3));
        Assert.Equal(24, new Triangle(10, 8, 6).CalculateArea());
        Assert.Equal(374.7, Math.Round(new Triangle(24, 32, 44).CalculateArea(), 1));
    }
}