using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jreyez3a
{
    public class Ex3aLoops
    {
        //public static string Calc0()
        //{
        //    int i = 1, sum = 0;
        //    while (i < 5)
        //    {
        //        sum += i;
        //        i++;
        //    }
        //    // step 1, initalize control variable
        //    // step 2, type of loop, condition we are testing
        //    // step 3, we are going to perform an operation in the loop
        //    // step 4, change the value of the control variable
        //    // step 5, show where the beginning and end of the loop is

        //    return sum.ToString();
        //}
        public static string Calc0(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try { 
                int months = Int32.Parse(strMonths);
                double monthlyPayment = double.Parse(strMonthlyPayment);
                double monthlyInterestRate = double.Parse(strMonthlyInterestRate);
                int i = 1;
                while (i <= months)
                {
                futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                i++;
                }
            }
            catch
            {
                return "Invalid input";
            }

            return futureValue.ToString("n2");
        }

        public static string Calc1(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = double.Parse(strMonthlyPayment);
                double monthlyInterestRate = double.Parse(strMonthlyInterestRate);
                int i = 1;
                do
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                    i++;
                }
                while (i <= months);
            }
            catch
            {
                return "Invalid input";
            }

            return futureValue.ToString("n2");
        }

        public static string Calc2(string strMonths, string strMonthlyPayment, string strMonthlyInterestRate)
        {
            double futureValue = 0.0;
            try
            {
                int months = Int32.Parse(strMonths);
                double monthlyPayment = double.Parse(strMonthlyPayment);
                double monthlyInterestRate = double.Parse(strMonthlyInterestRate);
                
                for (int i = 1; i <= months; i++)
                {
                    futureValue = (futureValue + monthlyPayment) * (1 + monthlyInterestRate);
                    
                }
                
            }
            catch
            {
                return "Invalid input";
            }

            return futureValue.ToString("n2");
        }

        public static string Calc3(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            try
            {
                int increment = Int32.Parse(strIncrement);
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                if (increment <= 0) throw new Exception(" ");
                int i = Start;
                //result += i + " ";
                while (i <= End)
                {

                    result += i + " ";
                    i += increment;
                }
            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

        public static string Calc4(string strStart, string strEnd, string strIncrement)
        {
            string result = "";

            try
            {
                int increment = Int32.Parse(strIncrement);
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                if (increment <= 0) throw new Exception(" ");
                int i = Start;
                //result += i + " ";
                do
                {

                    result += i + " ";
                    i += increment;
                }
                while (i <= End);
            }
            catch
            {
                return "Invalid input";
            }
            return result;
        }

        public static string Calc5(string strStart, string strEnd, string strIncrement)
        {
            string result = "";
            try
            {
                int increment = Int32.Parse(strIncrement);
                int Start = Int32.Parse(strStart);
                int End = Int32.Parse(strEnd);
                
                if (increment <= 0) throw new Exception(" ");

                for (int i = Start; i <= End; i += increment)
                {
                    
                    
                    result += i + " ";
                }

                
            }
            catch
            {
                return "Invalid input";
            }


            return result;
        }
        /*
                public static string Calc6(string strNumbers, string strCount)
                {
                    string result = "";
                    int startIndex = 0;

                    //try
                    //{
                        int i = 0;
                        int nCount = Int32.Parse(strCount);
                        int sum = 0;
                        while(i < nCount) 
                        { 

                            int endIndex = strNumbers.IndexOf(" ", startIndex);
                            string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                            int number = Int32.Parse(strNumber);
                            startIndex = endIndex + 1;
                            //sum = sum + number;
                            sum += number;
                            //int sum = number;
                            //result = sum.ToString();
                            i++;







                        }
                    //}
                   // catch
                   // {
                   //     result = "Invalid input";
                   // }
                    return result;
                }
                // counting variable
                // calculation adding to sum
                // inalize counting variable
                // count 1 from number entered
                // while statement
                // increment counting variable 
            `*/
        public static string Calc6(string strNumbers, string strCount)
        {
            int sum = 0;
            string result = "";
            int startIndex = 0;
            try
            {
                int count = Int32.Parse(strCount);
                int i = 1;

                while (i <= count)
                {
                    int endIndex = strNumbers.IndexOf(' ', startIndex);
                    string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                    int number = Int32.Parse(strNumber);
                    sum += number;
                    startIndex = endIndex + 1;
                    i++;
                }
                result = sum.ToString();

            }
            catch
            {
                return "Invalid input";
            }

            return result;
        }


        public static string Calc7(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }

        public static string Calc8(string strNumbers, string strCount)
        {
            string result = "";

            return result;
        }
    }
}
