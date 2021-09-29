using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VariableSamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            //txtHotdogTotal.Text = (
            //   4.0m * Convert.ToDecimal(txtHotdogs.Text)
            //   ).ToString("0.00");

            int hotDogs = Convert.ToInt32(txtHotdogs.Text);
            decimal hotDogPrice = 4m;
            decimal hotDogSubtotal = hotDogs * hotDogPrice;
            txtHotdogTotal.Text = hotDogSubtotal.ToString("0.00");

            //txtBurgerTotal.Text = (
            //    5.0m * Convert.ToDecimal(txtBurgers.Text)
            //    ).ToString("0.00");

            int burgers = Convert.ToInt32(txtBurgers.Text);
            decimal burgerPrice = 5m;
            decimal burgerSubtotal = burgers * burgerPrice;
            txtBurgerTotal.Text = burgerSubtotal.ToString("0.00");


            // txtPretaxTotal.Text = (Convert.ToDecimal(txtBurgerTotal.Text) + Convert.ToDecimal(txtHotdogTotal.Text)
            //     ).ToString("0.00");

            decimal pretaxTotal = hotDogSubtotal + burgerSubtotal;
            txtPretaxTotal.Text = pretaxTotal.ToString("0.00");

          //  txtTax.Text = (
            //Convert.ToDecimal(txtPretaxTotal.Text) * (Convert.ToDecimal("6.875") / 100)).ToString("0.00");

            decimal tax = 6.875m * pretaxTotal / 100;
            txtTax.Text = tax.ToString("0.00");
            // txtTotal.Text = (Convert.ToDecimal(txtTax.Text) + Convert.ToDecimal(txtPretaxTotal.Text)
            //     ).ToString("0.00");
            decimal total = pretaxTotal + tax;
            txtTotal.Text = total.ToString("0.00");

            btnClear.Focus();

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotdogs.Text = "0";
            txtBurgers.Text = "0";
            txtHotdogTotal.Text = "0";
            txtBurgerTotal.Text = "0";
            txtPretaxTotal.Text = "0";

            txtHotdogs.Focus();
        }

        private void ExitClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBurgerTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
