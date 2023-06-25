using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    public class LengthConversionMethods
    {
        public static void CentimeterToMeter()
        {
            Console.Write("Enter the length in Centimeter : ");
            var cm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Length in Meter: {cm * 0.01}");
            Console.ReadKey();
        }

        public static void CentimeterToKilometer()
        {
            Console.Write("Enter the length in Centimeter : ");
            var cm = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Length in Kilometer: {cm * 0.00001}");
            Console.ReadKey();
        }

        public static void MeterToCentimeter()
        {
            Console.Write("Enter the length in Meter : ");
            var m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Length in Centimeter: {m * 100}");
            Console.ReadKey();
        }

        public static void MeterToKilometer()
        {
            Console.Write("Enter the length in Meter : ");
            var m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Length in Kilometer: {m * 0.001}");
            Console.ReadKey();
        }

        public static void KilometerToCentimeter()
        {
            Console.Write("Enter the length in Kilometer : ");
            var km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Length in Centimeter: {km * 100000}");
            Console.ReadKey();
        }

        public static void KilometerToMeter()
        {
            Console.Write("Enter the length in Kilometer : ");
            var km = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Length in Meter: {km * 1000}");
            Console.ReadKey();
        }

        public static void InchToFeet()
        {
            Console.Write("Enter the length in Inch : ");
            var inch = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Length in Feet: {inch * 0.0834}");
            Console.ReadKey();
        }

        public static void FeetToInch()
        {
            Console.Write("Enter the length in Feet : ");
            var ft = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Length in Inch: {ft * 12}");
            Console.ReadKey();
        }
    }
}
