namespace HotelTriangle;

public static class IsTriangle
{
    public static bool CanMakeTriangle(double a, double b, double c) =>
        double.IsFinite(a) && double.IsFinite(b) && double.IsFinite(c) &&
        a > 0 && b > 0 && c > 0 && a + b > c && a + c > b && b + c > a;
}
