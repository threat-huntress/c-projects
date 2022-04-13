namespace ArchitectArithmetic
{
    using System;

    internal class Program
    {
        internal static void Main(string[] args)
        {
            double Rect(double length, double width) {
                return length * width;
            }

            double Circle(double radius) {
                return Math.PI * Math.Pow(radius, 2);
            }

            double Triangle(double width, double height) {
                return width * height / 2;
            }
            
            double Teotihuacan = Rect(2500, 1500) + Circle(375) / 2 + Triangle(750, 500);

            void CalculateTotalCost(string buildingName, double buildingArea, double materialCost = 180, string currency = "pesos") {
                double buildingCost = Math.Round(buildingArea * materialCost, 2);

                Console.WriteLine($"{buildingName} covers an area of {buildingArea}m² and would cost {buildingCost} {currency} in flooring materials.");

            }
            
            CalculateTotalCost("Teotihuacan", Teotihuacan);

            double TajMahal = Rect(90.5, 90.5) - 2 * Rect(24, 24);

            CalculateTotalCost("The Taj Mahal", TajMahal, 900, "rupees");
            
        }
    }
}