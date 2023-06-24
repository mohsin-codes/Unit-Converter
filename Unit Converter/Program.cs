namespace Unit_Converter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mohsin's Unit Converter");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("WEIGHTS:");
            Console.WriteLine("1. GM (Grams) -> KG (Kilograms)");
            Console.WriteLine("2. GM (Grams) -> T (Tonnes)");
            Console.WriteLine("3. KG (Kilograms) -> GM (Grams)");
            Console.WriteLine("4. KG (Kilograms) -> T (Tonnes)");
            Console.WriteLine("5. T (Tonnes) -> GM (Grams)");
            Console.WriteLine("6. T (Tonnes) -> KG (Kilograms)");
            Console.WriteLine();
            Console.WriteLine();


        }

        public static double GramsToKiloGrams(double grams)
        {
            return grams * 0.001;
        }

        public static double GramsToTonnes(double grams)
        {
            return grams * 0.00001;
        }

        public static double KilogramsToTonnes(double kilograms)
        {
            return kilograms * 0.001;
        }

        public static double KilogramsToGrams(double kilograms)
        {
            return kilograms * 1000;
        }

        public static double TonnesToGrams(double tonne)
        {
            return tonne * 100000;
        }

        public static double TonnesToKilograms(double tonne)
        {
            return tonne * 1000;
        }
    }
}