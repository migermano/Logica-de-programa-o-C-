using System;
using System.Globalization;

namespace curso
{
    class Program
    {
        static void Main(string[] args)
        {
            float b, B, h, area;
            b = 6f;
            B = 8f;
            h = 5f;
            area = (b + B) / 2f * h;
            Console.WriteLine(area);
        }
    }
}