using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"int max = {int.MaxValue}");
            Console.WriteLine($"int min = {int.MinValue}");
            Console.WriteLine($"double max = {double.MaxValue}");
            Console.WriteLine($"double min = {double.MinValue}");
            Console.WriteLine($"byte max = {byte.MaxValue}");
            Console.WriteLine($"byte min = {byte.MinValue}");

            Console.WriteLine($"double +inf = {double.PositiveInfinity}");
            Console.WriteLine($"double -inf = {double.NegativeInfinity}");
            Console.WriteLine($"double min = {double.NaN}");
        }
    }
}
