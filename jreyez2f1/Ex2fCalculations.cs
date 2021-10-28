using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jreyez2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            // #1 
            subtotal = Decimal.Parse(input);
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            // #2
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            string status = "Standard rate: ";
            if (subtotal >= 100m)
            {
                discountPercent = 0.2m;
                status = "Bulk rate: ";
            }
            // This is if you need to do more then one thing in a if statement
            return status + discountPercent.ToString("n2");
        }

        public static string Calc03(string input)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m && subtotal < 200m)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountPercent = 0.3m;
            else if (subtotal >= 300m)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");

        }

        public static string Calc06(string inputA, string inputB)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;
            }
            else
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            //#7 Validate input: non-empty string
            decimal ethereum = 0;
            if (input != "")
            {
                decimal dollars = Decimal.Parse(input);
                ethereum = (200m * dollars);
                return ethereum.ToString();
            }
                return "Invalid input";
        }
        public static string Calc08(string inputA, string inputB)
        {
            // #8 Validate input, calculate quantity * price, shipping
            decimal total = 0m;
            if (inputA != "" && inputB != "")
            {
                decimal price = Decimal.Parse(inputA);
                decimal amount = Decimal.Parse(inputB);
                decimal shippingTotal;
                
                total = price * amount;
                shippingTotal = total + Convert.ToDecimal(5m);
                if (total < 50m)
                    return shippingTotal.ToString();
                if (total >= 50m)
                    return total.ToString();
            }
            return "Invalid input";


        }
        

        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate
            decimal difference = 0m;
            decimal ValueA = 0m;
            decimal ValueB = 0m;
            decimal result = 0m;
            

            if (inputA != "" && inputB != "")
            {
                ValueA = Decimal.Parse(inputA);
                ValueB = Decimal.Parse(inputB);
                difference = ValueB - ValueA;
                result = difference * 0.10m;
                if (ValueA > ValueB)
                    return "Invalid input";
                if (ValueA < ValueB)
                    return result.ToString();
            }
            return "Invalid input";
        }

        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            double result = 0.0;
            double ValueA = 0.0;
            double ValueB = 0.0;
            if (inputA != "" && inputB != "")
            {
                ValueA = double.Parse(inputA);
                ValueB = double.Parse(inputB);
                if (ValueA >= ValueB)
                    result = ValueA / ValueB;
                if (ValueB >= ValueA)
                    result = ValueB / ValueA;
                if (ValueA <= 0)
                    return "Invalid input";
                if (ValueB <= 0)
                    return "Invalid input";

                
                //return "Invalid input";
              
                return result.ToString();
                
            }
                return "Invalid input";





        }
    }
}
