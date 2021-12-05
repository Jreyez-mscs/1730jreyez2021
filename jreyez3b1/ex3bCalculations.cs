using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jreyez3b1
{
    public class ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {

            decimal discountPercent = 0m;

            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            return discountPercent;
        }

        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {

            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;

            //this is an output argument rather then reference
        }

        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0m;
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
            // when defining method..
            // say public or private
            // say return type
            // give name of method
            // give list of parameters
            // give types for each parameter
            // return type has to match other type on the top
        }

        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            
            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return;
            
        }


        public static double FahrenheitToCelsius(double Fh)
        {
            double Cs = 0.0;
            Cs = (Fh - 32) / 1.8;
            return Cs;
        }

        public static void CelsiusToFahrenheit(double Cs, out double Fh)
        {
            
            
            Fh = (Cs * 1.8) + 32;
            
        }

        public static decimal GrossPay (decimal hours, decimal rate)
        {
            decimal payCheck = 0m;
            if (hours <= 40)
            {
                payCheck = hours * rate;

            }
            if (hours > 40)
            {
                decimal bonus;
                bonus = (hours - 40) * (rate * 0.5m);

                payCheck = hours * rate + bonus;

            }
            return payCheck;
        }

        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0;
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }

            return total;
        }

        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal total = 0;
            int startIndex = 0;

            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                decimal number = Decimal.Parse(strNumber);
                total += number;
                
                startIndex = endIndex + 1;
                
            }
            total = total * rate;
            return total;
        }



    }
}
