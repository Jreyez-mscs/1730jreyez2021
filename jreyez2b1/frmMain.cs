using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jreyez2b1
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Calculate(object sender, EventArgs e)
        {
            decimal ausAmount = Convert.ToDecimal(txtAusAmount.Text);
            decimal ausRate = Convert.ToDecimal(txtAusRate.Text);
            decimal USDAus = ausAmount * ausRate;
            txtUSDAus.Text = USDAus.ToString("0.00");

            decimal bhuAmount = Convert.ToDecimal(txtBhuAmount.Text);
            decimal bhuRate = Convert.ToDecimal(txtBhuRate.Text); 
            decimal USDBhu = bhuAmount * bhuRate;
            txtUSDBhu.Text = USDBhu.ToString("0.00");

            decimal costaAmount = Convert.ToDecimal(txtCostaAmount.Text); 
            decimal costaRate = Convert.ToDecimal(txtCostaRate.Text); 
            decimal USDCosta = costaAmount * costaRate;
            txtUSDCosta.Text = USDCosta.ToString("0.00");

            decimal euroAmount = Convert.ToDecimal(txtEuroAmount.Text);
            decimal euroRate = Convert.ToDecimal(txtEuroRate.Text);
            decimal USDEuro = euroAmount * euroRate;
            txtUSDEuro.Text = USDEuro.ToString("0.00");

            decimal totalUSD = USDAus + USDBhu + USDCosta + USDEuro;
            txtTotalUSD.Text = totalUSD.ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAusAmount.Text = "0.00";
            txtUSDAus.Text = "0.00";
            txtBhuAmount.Text = "0.00";
            txtUSDBhu.Text = "0.00";
            txtCostaAmount.Text = "0.00";
            txtUSDCosta.Text = "0.00";
            txtEuroAmount.Text = "0.00";
            txtUSDEuro.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtAusRate.Text = "0.717976";
            txtBhuRate.Text = "0.0139831";
            txtCostaRate.Text = "0.00176122";
            txtEuroRate.Text = "1.15528";
            txtAusAmount.Focus();
        }
    }
}
