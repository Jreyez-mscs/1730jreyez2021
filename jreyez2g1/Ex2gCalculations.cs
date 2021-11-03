using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jreyez2g1
{
    public class Ex2gCalculations
    {
        public static string Switch01(string customerType)
        {
            //1a 'Switch' with no default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
                    //  default:
                    //     discountPercent = .0m;
                    //     break
            }
            return discountPercent.ToString("0.0");
        }

        public static string If01(string customerType)
        {
            // Seperate "if" Statements
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = .1m;
            if (customerType == "C")
                discountPercent = .2m;

            return discountPercent.ToString("0.0");

        }

        public static string ElseIf01(string customerType)
        {
            // 1C) if elseif
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = .1m;
            else if (customerType == "C")
                discountPercent = .2m;
            // if the "if" statement is true, it does that one. If it isn't true, it skips it and does the else statement
            return discountPercent.ToString("0.0");
        }

        public static string NestedIfElse01(string customerType)
        {
            // 1D) NestedIf
            decimal discountPercent = -1m;

            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }

            }
            // Nested if statements can use blocks to make complex structions while not having each "if" statement overide or try to go over each other

            return discountPercent.ToString("0.0");
        }

        public static string SwitchDefault01(string customerType)
        {
            //1a 'Switch' with no default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountPercent = .1m;
                    break;
                case "C":
                    discountPercent = .2m;
                    break;
                default:
                    discountPercent = .0m;
                    break;
            }
            return discountPercent.ToString("0.0");
        }

        public static string IfDefault01(string customerType)
        {
            // Seperate "if" Statements
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = .1m;
            if (customerType == "C")
                discountPercent = .2m;
            if (customerType != "R" && customerType != "C")
                discountPercent = .0m;

            return discountPercent.ToString("0.0");

        }

        public static string ElseIfDefault01(string customerType)
        {
            // 1C) if elseif
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = .1m;
            else if (customerType == "C")
                discountPercent = .2m;
            else
                discountPercent = .0m;
            
            return discountPercent.ToString("0.0");
        }

        public static string NestedIfElseDefault01(string customerType)
        {
            // 1D) NestedIf
            decimal discountPercent = -1m;

            if (customerType == "R")
            {
                discountPercent = .1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = .2m;
                }
                else
                {
                    discountPercent = .0m;
                }

            }
            // Nested if statements can use blocks to make complex structions while not having each "if" statement overide or try to go over each other

            return discountPercent.ToString("0.0");
        }


        /*
These are the methods that the instructor pastes into the Ex2gCalculations class.
(he does this about a minute and a half into the video)
Make sure you paste them inside the class (paste them before the last TWO curly braces at the bottom of the file)
*/
        public static string Switch02(string customerType)
        {
            // 2a) 'Switch' with no default
            
                decimal discountPercent = -1m;

                switch (customerType)
                {
                    case "R":
                    case "C":
                        discountPercent = .2m;
                        break;
                    case "T":
                        discountPercent = .4m;
                        break;
                        //  default:
                        //     discountPercent = .0m;
                        //     break
                }
                return discountPercent.ToString("0.0");
        }

        public static string If02(string customerType)
        {
            // 2b) Separate 'if' statements
            {
                
                decimal discountPercent = -1m;

                if (customerType == "R")
                    discountPercent = .2m;
                if (customerType == "C")
                    discountPercent = .2m;
                if (customerType == "T")
                    discountPercent = .4m;
                if (customerType != "R" && customerType != "C" && customerType != "T")
                    discountPercent = -1m;

                return discountPercent.ToString("0.0");

            }
            
        }
        public static string ElseIf02(string customerType)
        {
            // 2c) if elseif
            {
                
                decimal discountPercent = -1m;

                if (customerType == "R")
                    discountPercent = .2m;
                else if (customerType == "C")
                    discountPercent = .2m;
                else if (customerType == "T")
                    discountPercent = .4m;
                else
                    discountPercent = -1m;
                return discountPercent.ToString("0.0");
            }
            
        }
        public static string NestedIfElse02(string customerType)
        {
            // 2d) Nested if-else
            {
              
                decimal discountPercent = -1m;

                if (customerType == "R")
                {
                    discountPercent = .2m;
                }
                else
                {
                    if (customerType == "C")
                    {
                        discountPercent = .2m;
                    }
                    if (customerType == "T")
                    {
                        discountPercent = .4m;
                    }
                    if (customerType != "T" && customerType != "C")
                    {
                        discountPercent = -1m;
                    }
                }
                
                       

               
                // Nested if statements can use blocks to make complex structions while not having each "if" statement overide or try to go over each other

                return discountPercent.ToString("0.0");
            }
            
        }
    }
}
