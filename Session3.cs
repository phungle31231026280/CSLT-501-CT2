using System;
using System.Diagnostics.CodeAnalysis;

namespace ueh
{
    internal class Baitap
    {
        public static void Main(string[] args)
        { stringa(); }
        static void BT1()
        {  
            Console.Write("Enter temperature in Celsius:");
            float Celcius = Convert.ToSingle(Console.ReadLine());
            float Kelvin = Celcius + 273;
            Console.WriteLine($"Convert Celsius to Kelvin: {Celcius}  do C =  {Kelvin} do K");
        }
    static void BT2()
    {
            Console.Write("Enter radius: ");
            float radius = Convert.ToSingle(Console.ReadLine());
            double pi = Math.PI;
            double surface = 4 * pi * Math.Pow(radius,2);
            double volume = 4 / 3 * pi * Math.Pow(radius, 3);
            Console.WriteLine($"Surface of the sphere: {surface}. Volume of the sphere: {volume}");
    }
    static void BT3()
        {
            Console.Write(" Enter number 1: ");
            int a =Convert.ToInt16(Console.ReadLine());
            Console.Write(" Enter number 2: ");
            int b = Convert.ToInt16(Console.ReadLine());
            int c = a + b;
            int d = a - b;
            int e = a * b;
            float f = a / b;
            int g = a % b;
            Console.WriteLine($"{a} + {b} = {c}");
            Console.WriteLine($"{a} - {b} = {d}");
            Console.WriteLine($"{a} * {b} = {e}");
            Console.WriteLine($"{a} / {b} = {f}");
            Console.WriteLine($"{a} % {b} = {g}");

        }
        static void stringa()
        {
        
        
        
        }
    }
}