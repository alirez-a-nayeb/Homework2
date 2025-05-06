using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Program
    {

        static double CalcPrice(double price, double tax = 0.1, double discount = 0.05)
        {
            double taxedPrice = price + (price * tax); //summing tax with main price
            double finalPrice = taxedPrice - (taxedPrice * discount); //minus discount 
            return finalPrice;
        }

        static bool Nullcheck(string inputString)
        {
            return !string.IsNullOrWhiteSpace(inputString); 
            //checking if user uses optional parametr values

        }

        static void Main(string[] args)
        {
            double itemPrice = 0, finalItemPrice = 0;
            double itemTax = 0.1, itemDiscount = 0.05;

            Console.WriteLine("Enter Item's Price:");
            string priceInput = Console.ReadLine();
            if (Nullcheck(priceInput) && double.TryParse(priceInput, out itemPrice))
            {
                // OK
            }
            else
            {
                Console.WriteLine("Invalid Price Input!");
                return;
            }

            Console.WriteLine("Enter Item's Discount in Decimal (Optional):");
            string discountInput = Console.ReadLine();
            if (Nullcheck(discountInput) && double.TryParse(discountInput, out double discount))
            {
                itemDiscount = discount;
            }

            Console.WriteLine("Enter Item's Tax in Decimal (Optional):");
            string taxInput = Console.ReadLine();
            if (Nullcheck(taxInput) && double.TryParse(taxInput, out double tax))
            {
                itemTax = tax;
            }

            finalItemPrice = CalcPrice(itemPrice, itemTax, itemDiscount);
            Console.WriteLine($"Final Price Is: {finalItemPrice:F2}");
        }
    }
}
