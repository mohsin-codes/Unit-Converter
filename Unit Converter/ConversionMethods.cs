using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Converter
{
    public class ConversionMethods
    {

        public static void UserChoiceToConversionMethod(String? UserChoice)
        {
            switch(UserChoice)
            {
                case "W1":
                    WeightConversionMethods.GramsToKiloGrams();
                    break;

                case "W2":
                    WeightConversionMethods.GramsToTonnes();
                    break;

                case "W3":
                    WeightConversionMethods.KilogramsToGrams();
                    break;

                case "W4":
                    WeightConversionMethods.KilogramsToTonnes();
                    break;

                case "W5":
                    WeightConversionMethods.TonnesToGrams();
                    break;

                case "W6":
                    WeightConversionMethods.TonnesToKilograms();
                    break;

                case "L1":
                    LengthConversionMethods.CentimeterToMeter();
                    break;

                case "L2":
                    LengthConversionMethods.CentimeterToKilometer();
                    break;

                case "L3":
                    LengthConversionMethods.MeterToCentimeter();
                    break;

                case "L4":
                    LengthConversionMethods.MeterToKilometer();
                    break;

                case "L5":
                    LengthConversionMethods.KilometerToCentimeter();
                    break;

                case "L6":
                    LengthConversionMethods.KilometerToMeter();
                    break;

                case "L7":
                    LengthConversionMethods.InchToFeet();
                    break;

                case "L8":
                    LengthConversionMethods.FeetToInch();
                    break;

                case "C1":
                    CurrencyConversionMethods.INRTOUSD();
                    break;

                case "C2":
                    CurrencyConversionMethods.INRTOGBP();
                    break;

                case "C3":
                    CurrencyConversionMethods.INRTOEUR();
                    break;

                case "C4":
                    CurrencyConversionMethods.USDTOINR();
                    break;

                case "C5":
                    CurrencyConversionMethods.USDTOGBP();
                    break;

                case "C6":
                    CurrencyConversionMethods.USDTOEUR();
                    break;

                case "C7":
                    CurrencyConversionMethods.GBPTOINR();
                    break;

                case "C8":
                    CurrencyConversionMethods.GBPTOUSD();
                    break;

                case "C9":
                    CurrencyConversionMethods.GBPTOEUR();
                    break;

                case "C10":
                    CurrencyConversionMethods.EURTOINR();
                    break;

                case "C11":
                    CurrencyConversionMethods.EURTOUSD();
                    break;

                case "C12":
                    CurrencyConversionMethods.EURTOUSD();
                    break;


                default:
                    Console.WriteLine("Wrong Input! Please Try Again");
                    break;
            }
        }
    }
}
