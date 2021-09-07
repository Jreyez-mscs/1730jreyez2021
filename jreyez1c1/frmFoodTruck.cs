using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jreyez1c1
{
    public partial class FrmFoodTruck : Form
    {
        private readonly object Clear;

        public FrmFoodTruck()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtHotdogTotal.Text = (
                4.0m * Convert.ToDecimal(txtHotdogs.Text)
                ).ToString("0.00");
            txtBurgerTotal.Text = (
                5.0m * Convert.ToDecimal(txtBurgers.Text)
                ).ToString("0.00");
            txtPretaxTotal.Text = (Convert.ToDecimal(txtBurgerTotal.Text) + Convert.ToDecimal(txtHotdogTotal.Text)
                ).ToString("0.00");
            
            txtTax.Text = (
                Convert.ToDecimal(txtPretaxTotal.Text) * (Convert.ToDecimal("6.875") / 100)).ToString("0.00");
            txtTotal.Text = (Convert.ToDecimal(txtTax.Text) + Convert.ToDecimal(txtPretaxTotal.Text)
                ).ToString("0.00");


            btnClear.Focus();

            //I hope you are having a good day!

            
        }

        private void txtBurgers_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHotdogs_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtPretaxTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void ExitClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            txtHotdogs.Text = "0";
            txtBurgers.Text = "0";
            txtHotdogTotal.Text = "0";
            txtBurgerTotal.Text = "0";
            txtPretaxTotal.Text = "0";

            txtHotdogs.Focus();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
