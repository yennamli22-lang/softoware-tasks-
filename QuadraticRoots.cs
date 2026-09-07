namespace QuadraticEquation;

public sealed record QuadraticRootsResult(IReadOnlyList<double> Roots)
{
    public int Count => Roots.Count;
}

public static class QuadraticRoots
{
    public static QuadraticRootsResult Solve(double a, double b, double c)
    {
        if (!double.IsFinite(a) || !double.IsFinite(b) || !double.IsFinite(c))
            throw new ArgumentException("Coefficients must be finite numbers.");
        if (a == 0)
            throw new ArgumentException("The coefficient a must be non-zero for a quadratic equation.", nameof(a));

        var discriminant = b * b - 4 * a * c;
        if (discriminant < 0)
            return new QuadraticRootsResult(Array.Empty<double>());
        if (discriminant == 0)
            return new QuadraticRootsResult(new[] { -b / (2 * a) });

        var squareRoot = Math.Sqrt(discriminant);
        var x1 = (-b - squareRoot) / (2 * a);
        var x2 = (-b + squareRoot) / (2 * a);
        return new QuadraticRootsResult(new[] { Math.Min(x1, x2), Math.Max(x1, x2) });
    }
}
