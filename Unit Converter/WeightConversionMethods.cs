using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    public class WeightConversionMethods
    {
        public static void GramsToKiloGrams()
        {
            Console.Write("Enter the weight in grams : ");
            var grams = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Weight in Kilograms: {grams * 0.001}");
            Console.ReadKey();
        }

        public static void GramsToTonnes()
        {
            Console.Write("Enter the weight in grams : ");
            var grams = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Weight in Tonnes: {grams * 0.00001}");
            Console.ReadKey();
        }

        public static void KilogramsToGrams()
        {
            Console.Write("Enter the weight in Kilograms : ");
            var kilograms = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Weight in Grams: {kilograms * 0.001}");
            Console.ReadKey();
        }

        public static void KilogramsToTonnes()
        {
            Console.Write("Enter the weight in Kilograms : ");
            var kilograms = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Weight in Tonnes: {kilograms * 1000}");
            Console.ReadKey();
        }

        public static void TonnesToGrams()
        {
            Console.Write("Enter the weight in Tonnes : ");
            var tonne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Weight in Grams: {tonne * 100000}");
            Console.ReadKey();
        }

        public static void TonnesToKilograms()
        {
            Console.Write("Enter the weight in Tonnes : ");
            var tonne = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Weight in Kilograms: {tonne * 1000}");
            Console.ReadKey();
        }
    }
}
