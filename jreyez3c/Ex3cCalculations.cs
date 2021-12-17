using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jreyez3c
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
            //        return     arguement type
        {
            try
            {
                
                string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
                return days[index - 1];
            }
            catch
            {
                return "Invalid index";
            }
            
        }

        public static string Calc1(string time)
        {
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            //                    0        1            2             3             4              5            6

            time = time.Trim();
            time = time.ToUpper();
            for (int i = 0; i < days.Length; i++)
            {
                if (time == days[i])
                {
                    return hours[i];
                }
                
            }
            return "Invalid input";
            
            
            
        }

        public static int Calc2(int[] numbers)
        {
            int total = 0;
            foreach (int i in numbers)
            {
                total += i;
            }
            return total;
        }
        public static double Calc3(double[] numbers, int count)
        {
            double total = 0.0;
            if (count <= 5)
            {
                for (int i = 0; i < count; i++)
                {
                        total += numbers[i];
                    
                }
                }
                else
                {
                    return 0.0;
                }
                return total;
        }
        public static double Calc5(double[] index)
        {
            return 0.0;
        }

        public static double[] Calc6(double[] index)
        {
            return new double[10];
        }
    }
}
