using HotelTriangle;
using Xunit;

namespace HotelTriangle.Tests;

public class IsTriangleTests
{
    [Theory]
    [InlineData(3, 4, 5)]
    [InlineData(5, 5, 5)]
    [InlineData(2, 2, 3)]
    public void ValidSidesMakeATriangle(double a, double b, double c) =>
        Assert.True(IsTriangle.CanMakeTriangle(a, b, c));

    [Theory]
    [InlineData(1, 2, 3)]
    [InlineData(1, 1, 3)]
    [InlineData(0, 4, 5)]
    [InlineData(-1, 4, 5)]
    public void InvalidSidesDoNotMakeATriangle(double a, double b, double c) =>
        Assert.False(IsTriangle.CanMakeTriangle(a, b, c));
}
