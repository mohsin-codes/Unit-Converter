using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    public class CurrencyConversionMethods
    {
        //These values are based on values available on Currency Exchange - 26/06/2023
        public static void INRTOUSD()
        {
            Console.Write("Enter the amount in Indian Rupees : ");
            var inr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in USD: {inr * 0.012}");
            Console.ReadKey();
        }

        public static void INRTOGBP()
        {
            Console.Write("Enter the amount in Indian Rupees : ");
            var inr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in  Pound Sterling: {inr * 0.0096}");
            Console.ReadKey();
        }

        public static void INRTOEUR()
        {
            Console.Write("Enter the amount in Indian Rupees : ");
            var inr = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in Euro: {inr * 0.011}");
            Console.ReadKey();
        }

        public static void USDTOINR()
        {
            Console.Write("Enter the amount in United States Dollar : ");
            var usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in Indian Rupees: {usd * 81.99}");
            Console.ReadKey();
        }

        public static void USDTOGBP()
        {
            Console.Write("Enter the amount in United States Dollar : ");
            var usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in Pound Sterling: {usd * 0.79}");
            Console.ReadKey();
        }

        public static void USDTOEUR()
        {
            Console.Write("Enter the amount in United States Dollar : ");
            var usd = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in Euro: {usd * 0.91}");
            Console.ReadKey();
        }


        public static void GBPTOINR()
        {
            Console.Write("Enter the amount in Pound Sterling : ");
            var gbp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in Indian Rupees: {gbp * 104.24}");
            Console.ReadKey();
        }

        public static void GBPTOUSD()
        {
            Console.Write("Enter the amount in Pound Sterling : ");
            var gbp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in USD: {gbp * 1.27}");
            Console.ReadKey();
        }

        public static void GBPTOEUR()
        {
            Console.Write("Enter the amount in Pound Sterling : ");
            var gbp = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in Euro: {gbp * 1.16}");
            Console.ReadKey();
        }

        public static void EURTOINR()
        {
            Console.Write("Enter the amount in Euro : ");
            var eur = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in Indian Rupees: {eur * 89.64}");
            Console.ReadKey();
        }

        public static void EURTOUSD()
        {
            Console.Write("Enter the amount in Euro : ");
            var eur = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in USD: {eur * 1.09}");
            Console.ReadKey();
        }

        public static void EURTOGBP()
        {
            Console.Write("Enter the amount in Euro : ");
            var eur = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Amount in Pound Sterling: {eur * 0.86}");
            Console.ReadKey();
        }
    }
}
