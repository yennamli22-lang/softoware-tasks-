using TemperatureConversion;
using Xunit;

namespace TemperatureConversion.Tests;

public class TemperatureConverterTests
{
    [Theory]
    [InlineData(0.0, 32.0)]
    [InlineData(100.0, 212.0)]
    [InlineData(-40.0, -40.0)]
    [InlineData(-10.0, 14.0)]
    [InlineData(20.0, 68.0)]
    [InlineData(37.0, 98.6)]
    [InlineData(0.5, 32.9)]
    [InlineData(-0.5, 31.1)]
    [InlineData(-273.15, -459.67)]
    [InlineData(1000.0, 1832.0)]
    public void CelsiusToFahrenheit_KnownTemperature_ReturnsExpectedValue(
        double celsius, double expectedFahrenheit)
    {
        // Act
        double actualFahrenheit = TemperatureConverter.celsius_to_fahrenheit(celsius);

        // Assert: decimal precision allows normal floating-point rounding.
        Assert.Equal(expectedFahrenheit, actualFahrenheit, precision: 10);
    }
}
