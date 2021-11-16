using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

namespace jreyez2h1
{
    public class Ex2hhCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }

            return result;



        }
        public static string DateCalc07(string strDate)
        {
            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }

            return result;



        }
        public static string DateCalc08(string strDate)
        {
            string result = "Invalid Input";
            DateTime date;
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();


            return result;
        }
        public static string DateCalc09(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                TimeSpan TimeTillDue = dateA - dateB;
                return TimeTillDue.TotalDays + " days";



            }
            catch { }

            return result;
        }
        public static string DateCalc10(string strDateA, string strDateB)
        {
            string result = "Invalid input";
            DateTime dateA;
            DateTime dateB;
            try
            {
                dateA = DateTime.Parse(strDateA);
                dateB = DateTime.Parse(strDateB);
                if (dateA > dateB)
                {
                    TimeSpan TimeTillDue = dateA - dateB;
                    return TimeTillDue.TotalDays + " days past due";
                }
                if (dateA <= dateB)
                {
                    return "On time";
                }

            }
            catch { }

            return result;
        }
        public static string StringCalc01(string s)
        {
            string result = "Invalid input";
            
            try
            {

                s = s.Remove(0, 1);
                s = s.Insert(0, "c");
                s = s.Insert(1, "r");
                return s;
            }
             catch { }
            return result;
        }

        public static string StringCalc02(string s)
        {
            string result = "Invalid input";

            try
            {
                s = s.Trim();
                s = s.Remove(1, 1);
                s = s.Insert(1, "rit");
                
                
                return s;
            }
            catch { }
            return result;
        }

        public static string StringCalc03(string s)
        {
            string result = "Invalid input";
            
            try
            {
                s = s.Trim();
                s = s.Substring(2, 4);
                s = s.ToUpper();
                return s;


            }
            catch { }
            return result;
        }

        public static string StringCalc04(string s)
        {
            string result = "Invalid input";
            char pad = '*';
            try
            {
                s = s.Trim();
                s = s.PadLeft(10, pad);
                return s;


            }
            catch { }
            return result;
        }

        public static string StringCalc05(string s)
        {
            string result = "Invalid input";
            
            try
            {
                s = s.Trim();
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace(" ", "");
                s = s.Replace("-", "");
                
                return s;


            }
            catch { }
            return result;
        }

        public static string StringCalc06(string s)
        {
            string result = "Invalid input";
            
            try
            {
                s = s.Trim();
                s = s.Replace("(", "");
                s = s.Replace(")", "");
                s = s.Replace(" ", "");
                s = s.Replace("-", "");
                if (s.Length == 7)
                {
                    s = s.Insert(3, ".");
                    return s;
                    
                }
                else if (s.Length == 10)
                {
                    s = s.Insert(3, ".");
                    s = s.Insert(7, ".");
                    return s;
                }
                else
                {
                    return result;
                }
              
            }
            catch { }
            return result;
        }

        public static string StringCalc07(string s1)
        {
            string result = "Invalid input";
            
            try
            {
                
                s1 = s1.Trim();
                s1 = s1.ToLower();


                if (s1.Contains("pioneer") == true)
                {
                    return "Found";

                }
                else
                    return "Not Found";




            }
            catch { }
            return result;
        }

        public static string StringCalc08(string s2)
        {
            string result = "Invalid input";
            int city = s2.IndexOf(",") + 1;
            try
            {
                if (s2.Contains(",") == true)
                {
                    s2 = s2.Substring(city + 1);
                    return s2;
                }
                else
                {
                    return result;
                }



            }
            catch { }
            return result;
        }

        public static string StringCalc09(string s3)
        {
            string result = "Invalid input";
            int city = s3.LastIndexOf(",") + 1;
            try
            {
                if (s3.Contains(",") == true) { 
                s3 = s3.Substring(city + 1);
                return s3;
                }
                else
                { 
                    return result;
                }


            }
            catch { }
            return result;
        }

        public static string StringCalc10(string s1, string s2, string s3)
        {
            StringBuilder labelResult = new StringBuilder(10);
            labelResult.Append(s1 + ", " + s2 + ", " + s3 + ", ");
            return labelResult.ToString();
           
            
        }
    }
}

