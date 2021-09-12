using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jreyezEx1E
{
    public partial class frmTestAverage : Form
    {
        public frmTestAverage()
        {
            InitializeComponent();
        }

        private void txtTestOne_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTestTwo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTestThree_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAverage_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (
                Convert.ToDecimal(txtTestOne.Text) +
                Convert.ToDecimal(txtTestTwo.Text) +
                Convert.ToDecimal(txtTestThree.Text)
                ).ToString("0.00");
            txtAverage.Text = (
                Convert.ToDecimal(txtAverage.Text) / 3
                ).ToString("0.00");
                

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTestOne.Text = "0";
            txtTestTwo.Text = "0";
            txtTestThree.Text = "0";
            txtAverage.Text = "0";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
