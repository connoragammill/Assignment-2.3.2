using System.ComponentModel.Design;

namespace Assignment_2._3._2
{
    internal class TipCalculator
    {
        static void Main(string[] args)
        {
            const double NcTaxRate = 0.0475;

            Console.WriteLine("Enter the bill amount:");
            double billAmount = double.Parse(Console.ReadLine());

            Console.WriteLine($"Choose a tip%:");
            Console.WriteLine("10%, 15%, 20%, Custom Tip%:");
            string tipInput = Console.ReadLine();
            double tipPercentage;
            //Tip percent divided by 100 to get the dollar amount
            if (tipInput.EndsWith("%")) 
            { 
                tipPercentage = double.Parse(tipInput.TrimEnd('%')) / 100;//If the user adds a % sign, .TrimEnd removes it
            } 
            else 
            { 
                tipPercentage = double.Parse(tipInput) / 100; 
            }

            double tipAmount = billAmount * tipPercentage;
            double taxAmount = billAmount * NcTaxRate;
            double billTotal = billAmount + tipAmount + taxAmount;
            Console.WriteLine($"\nBill Amount: ${billAmount:F2}");//F2 means its a floating point number with 2 decimal places 
            Console.WriteLine($"Tip Amount ({tipPercentage * 100}%): ${tipAmount:F2}"); 
            Console.WriteLine($"Tax Amount (North Carolina sales tax (4.75%)): ${taxAmount:F2}"); 
            Console.WriteLine($"Total Bill: ${billTotal:F2}");
        }
    }
}
