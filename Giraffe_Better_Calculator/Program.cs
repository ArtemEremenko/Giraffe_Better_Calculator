using Giraffe_Better_Calculator;
using System.Diagnostics.Metrics;
using System.Dynamic;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        CultureInfo.DefaultThreadCurrentCulture = CultureInfo.InvariantCulture;

        Calculator.Run();
    }
} 