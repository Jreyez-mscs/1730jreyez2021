using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace jreyez3b1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void calcButton_Click_1(object sender, RoutedEventArgs e)
        { //00
            try
            {
                decimal subtotal = decimal.Parse(inputTxt0a.Text);
                decimal discountPercent = ex3bCalculations.GetDiscountPercent(subtotal);
                resultTxt0.Text = discountPercent.ToString("f3");
            }
            catch
            {
                MessageBox.Show("Invalid Input: " + this.inputTxt0a.Text);
                resultTxt0.Text = "";
            }
            //01 using out
            
            try
            {
                decimal subtotal = decimal.Parse(inputTxt1a.Text);
                decimal discountPercent;
                    ex3bCalculations.GetDiscountPercent(subtotal, out discountPercent);
                resultTxt1.Text = discountPercent.ToString("f3");
            }
            catch
            {
                MessageBox.Show("Invalid Input: " + this.inputTxt0a.Text);
                resultTxt1.Text = "";
            }

            //02
            try
            {
                int months = Int32.Parse(this.inputTxt2a.Text);
                decimal monthlyInvestment = decimal.Parse(this.inputTxt2b.Text);
                decimal monthyInterestRate = decimal.Parse(this.inputTxt2c.Text);
                decimal futureValue = ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthyInterestRate, months);
                resultTxt2.Text = futureValue.ToString("c2");
            }
            catch
            {
                MessageBox.Show("Invalid Input:\n"
                    + this.inputTxt2a.Text + "\n"
                    + this.inputTxt2b.Text + "\n"
                    + this.inputTxt2c.Text + "\n");
                resultTxt2.Text = "";
            }
            //03 using ref argument
            try
            {
                int months = Int32.Parse(this.inputTxt3a.Text);
                decimal monthlyInvestment = decimal.Parse(this.inputTxt3b.Text);
                decimal monthyInterestRate = decimal.Parse(this.inputTxt3c.Text);
                decimal futureValue = 0m;
                ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthyInterestRate, months, ref futureValue);
                resultTxt3.Text = futureValue.ToString("c2");
            }
            catch
            {
                resultTxt3.Text = " ";
                MessageBox.Show("Invalid Input:\n"
                    + this.inputTxt3a.Text + "\n"
                    + this.inputTxt3b.Text + "\n"
                    + this.inputTxt3c.Text + "\n");
                resultTxt2.Text = "";
            }
            //04
            try
            {
                double fh = double.Parse(this.inputTxt4a.Text);
                double Cs = ex3bCalculations.FahrenheitToCelsius(fh);
                resultTxt4.Text = Cs.ToString("f1");
            }
            catch
            {
                MessageBox.Show("Invalid Input: " + this.inputTxt4a.Text);
                resultTxt4.Text = "";
            }
            //05
            try
            {
                double Fh = 0.0;
                double Cs = double.Parse(this.inputTxt5a.Text);
                ex3bCalculations.CelsiusToFahrenheit(Cs, out Fh);
                resultTxt5.Text = Fh.ToString("f1");
            }
            catch
            {
                MessageBox.Show("Invalid Input: " + this.inputTxt4a.Text);
                resultTxt4.Text = "";
            }

            //06
            try
            {
                decimal hours = decimal.Parse(this.inputTxt9a.Text);
                decimal rate = decimal.Parse(this.inputTxt9c.Text);
                this.resultTxt9.Text = ex3bCalculations.GrossPay(hours, rate).ToString("c2");
            }
            catch
            {
                MessageBox.Show("Invalid Input: "
                    + this.inputTxt9a.Text + "\n"
                    + this.inputTxt9c.Text);
                resultTxt9.Text = "";
            }
            //07
            try
            {
                this.resultTxt7.Text =
                    ex3bCalculations.TotalHours(this.inputTxt7a.Text).ToString("n2");
            }
            catch
            {
                this.resultTxt7.Text = "";
                MessageBox.Show("Invalid input: " + this.inputTxt7a.Text);
            }
            //08
            try
            {
                decimal rate = Decimal.Parse(this.inputTxt8c.Text);
                this.resultTxt8.Text =
                    ex3bCalculations.GrossPay(
                        this.inputTxt8a.Text, rate).ToString("c2");
            }
            catch
            {
                this.resultTxt8.Text = " ";
                MessageBox.Show("Invalid Input:\n"
                    + this.inputTxt8a.Text + "\n"
                    + this.inputTxt8c.Text);
            }



        }
    }
}  
