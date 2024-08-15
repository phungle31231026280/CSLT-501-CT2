using System;
using System.Diagnostics.CodeAnalysis;

namespace ueh
{
    internal class Baitap
    {
        public static void Main(string[] args)
        {
            baitap_01();
            //baitap_02_cach2();	
            //baitap_03();
            //baitap_04();
            //baitap_05();
            //baitap_06();
            //baitap_08();
            //baitap_09();
            //baitap_10();
        }
        static void baitap_01()
        {
            Console.Write("Enter number a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            int sum = a + b;

            Console.WriteLine($"{a} + {b} = {sum}");
        }
      
        static void baitap_02_cach2()
        {
            Console.Write("Enter number a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number b: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"before swap a={a}, b={b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"after swap a={a}, b={b}");
        }
        static void baitap_03()
        {
            Console.Write("Enter number a: ");
            float a = Convert.ToSingle(Console.ReadLine());

            Console.Write("Enter number b: ");
            float b = Convert.ToSingle(Console.ReadLine());

            float Multiply = a * b;

            Console.WriteLine($"{a} * {b} = {Multiply}");
        }
        static void baitap_04()
        {
            Console.Write("Enter number in feet: ");
            double feet = Convert.ToDouble(Console.ReadLine());
            double meter = feet / 3.2808;
            Console.WriteLine($"Convert feet to meter: {feet} feet = {meter} meter");
        }
        static void baitap_05()
        {
            Console.Write("Enter temperature in Celsius: ");
            double Celsius_1 = Convert.ToDouble(Console.ReadLine());
            double Fahrenheit_1 = 1.8 * Celsius_1 + 32;
            Console.WriteLine($"Convert Celsius to Fahrenheit: {Celsius_1} do C = {Fahrenheit_1} do F");
            Console.ReadLine();
            Console.Write("Enter temperature in Fahrenheit:");
            double Fahrenheit_2 = Convert.ToDouble(Console.ReadLine());
            double Celsius_2 = 5 * (Fahrenheit_2 - 32) / 9;
            Console.WriteLine($"Convert Fahrenheit to Celsius: {Fahrenheit_2}  do F =  {Celsius_2} do C");
        }
        static void baitap_06()
        {
            Console.WriteLine($"Size of int: {sizeof(int)}");
            Console.WriteLine($"Size of float: {sizeof(float)}");
            Console.WriteLine($"Size of char: {sizeof(char)}");
            Console.WriteLine($"Size of double: {sizeof(double)}");
            Console.WriteLine($"size of bool: {sizeof(bool)}");
        }
        static void baitap_08()
        {
            Console.Write("Nhap ban kinh hinh tron: ");
            double r = Convert.ToSingle(Console.ReadLine());
            double S = r * r * 3.14;
            Console.WriteLine($"Dien tich hinh tron ban kinh {r} la: {S}");
        }
        static void baitap_09()
        {
            Console.Write("Nhap canh hinh vuong: ");
            double a = Convert.ToSingle(Console.ReadLine());
            double S = a * a;
            Console.WriteLine($"Dien tich hinh vuong canh {a} la: {S}");
        }
        static void baitap_10()
        {
            Console.Write("Nhap so ngay: ");
            int n_days = Convert.ToInt32(Console.ReadLine());
            int year = n_days / 365;
            int week = (n_days % 365) / 7;
            int day = (n_days % 365) % 7;
            Console.WriteLine($"{n_days} ngay tuong duong {year} nam {week} tuan {day} ngay");
        }

    }
}