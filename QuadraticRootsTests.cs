using QuadraticEquation;

namespace QuadraticEquation.Tests;

public class QuadraticRootsTests
{
    [Fact]
    public void Solve_WhenDiscriminantIsNegative_ReturnsNoRealRoots()
    {
        var result = QuadraticRoots.Solve(1, 0, 1);

        Assert.Empty(result.Roots);
    }

    [Fact]
    public void Solve_WhenDiscriminantIsZero_ReturnsOneRealRoot()
    {
        var result = QuadraticRoots.Solve(1, 2, 1);

        var root = Assert.Single(result.Roots);
        Assert.Equal(-1, root, precision: 12);
    }

    [Fact]
    public void Solve_WhenDiscriminantIsPositive_ReturnsTwoRealRoots()
    {
        var result = QuadraticRoots.Solve(1, -3, 2);

        Assert.Equal(2, result.Count);
        Assert.Equal(1, result.Roots[0], precision: 12);
        Assert.Equal(2, result.Roots[1], precision: 12);
    }
}
