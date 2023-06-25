using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    public class StartMenu
    {
        public static void Start_Menu()
        {
            Console.WriteLine("Welcome to Mohsin's Unit Converter");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Note: As input you can use initial letter of the category, followed by the number before the conversion. For ex - W1");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Category - WEIGHTS:");
            Console.WriteLine("1. GM (Grams) -> KG (Kilograms)");
            Console.WriteLine("2. GM (Grams) -> T (Tonnes)");
            Console.WriteLine("3. KG (Kilograms) -> GM (Grams)");
            Console.WriteLine("4. KG (Kilograms) -> T (Tonnes)");
            Console.WriteLine("5. T (Tonnes) -> GM (Grams)");
            Console.WriteLine("6. T (Tonnes) -> KG (Kilograms)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Category - LENGTHS:");
            Console.WriteLine("1. CM (Centimeter) -> M (Meter)");
            Console.WriteLine("2. CM (Centimeter) -> KM (Kilometer)");
            Console.WriteLine("3. M (Meter) -> CM (Centimeter)");
            Console.WriteLine("4. M (Meter) -> KM (Kilometer)");
            Console.WriteLine("5. KM (Kilometer) -> CM (Centimeter)");
            Console.WriteLine("6. KM (Kilometer) -> M (Meter)");
            Console.WriteLine("7. IN (Inch) -> FT (Feet)");
            Console.WriteLine("8. FT (Feet) -> IN (Inch)");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Category - Currency:");
            Console.WriteLine("1. INR (Indian Rupee) -> USD (United States Dollar)");
            Console.WriteLine("2. INR (Indian Rupee) -> GBP (Pound Sterling)");
            Console.WriteLine("3. INR (Indian Rupee) -> EUR (Euro)");
            Console.WriteLine("4. USD (United States Dollar) -> INR (Indian Rupee)");
            Console.WriteLine("5. USD (United States Dollar) -> GBP (Pound Sterling)");
            Console.WriteLine("6. USD (United States Dollar) -> EUR (Euro)");
            Console.WriteLine("7. GBP (Pound Sterling) -> INR (Indian Rupee)");
            Console.WriteLine("8. GBP (Pound Sterling) -> USD ((United States Dollar)");
            Console.WriteLine("9. GBP (Pound Sterling) -> EUR (Euro)");
            Console.WriteLine("10. EUR (Euro) -> INR (Indian Rupee)");
            Console.WriteLine("11. EUR (Euro) -> USD ((United States Dollar)");
            Console.WriteLine("12. EUR (Euro) -> GBP (Pound Sterling)");
            Console.WriteLine();
            Console.WriteLine();



            Console.Write("Input: ");
            var UserChoice = Console.ReadLine();

            ConversionMethods.UserChoiceToConversionMethod(UserChoice);
        }
    }
}
