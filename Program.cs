using QuadraticEquation;

Console.WriteLine("Quadratic equation solver: ax^2 + bx + c = 0");
Console.Write("Enter a, b and c separated by spaces: ");
var values = (Console.ReadLine() ?? string.Empty)
    .Split(' ', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);

if (values.Length != 3 || !values.All(value => double.TryParse(value, out _)))
{
    Console.WriteLine("Please enter exactly three numeric coefficients.");
    return;
}

try
{
    var result = QuadraticRoots.Solve(
        double.Parse(values[0]), double.Parse(values[1]), double.Parse(values[2]));
    Console.WriteLine(result.Count switch
    {
        0 => "The equation has no real roots.",
        1 => $"The equation has one real root: x = {result.Roots[0]}",
        _ => $"The equation has two real roots: x1 = {result.Roots[0]}, x2 = {result.Roots[1]}"
    });
}
catch (ArgumentException ex)
{
    Console.WriteLine(ex.Message);
}
