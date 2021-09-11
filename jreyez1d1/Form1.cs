using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jreyez1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
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
            //I had all these before you said the easier route in the video, so ignore how many there are
        }

        private void austrailaTextChange(object sender, EventArgs e)
        {
            txtUSDAus.Text = (Convert.ToDecimal(txtAusAmount.Text)
                * Convert.ToDecimal(txtAusRate.Text

                )).ToString("0.00");
        }

        private void txtUSDAus_TextChanged(object sender, EventArgs e)
        {
            txtUSDAus.Text = (Convert.ToDecimal(txtAusAmount.Text) 
                * Convert.ToDecimal(txtAusRate.Text)
                ).ToString("0.00");
        }

        private void txtUSDBhu_TextChanged(object sender, EventArgs e)
        {
            txtUSDBhu.Text = (Convert.ToDecimal(txtBhuAmount.Text)
                * Convert.ToDecimal(txtBhuRate.Text)
                ).ToString("0.00");
        }

        private void BhultaneseTextChange(object sender, EventArgs e)
        {
            txtUSDBhu.Text = (Convert.ToDecimal(txtBhuAmount.Text)
                * Convert.ToDecimal(txtBhuRate.Text)
                ).ToString("0.00");
        }

        private void CostaTextChange(object sender, EventArgs e)
        {
            txtUSDCosta.Text = (Convert.ToDecimal(txtCostaAmount.Text)
                * Convert.ToDecimal(txtCostaRate.Text)

                ).ToString("0.00");
        }

        private void EuroTextChange(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (Convert.ToDecimal(txtEuroAmount.Text)
                * Convert.ToDecimal(txtEuroRate.Text)

                ).ToString("0.00");
        }

        private void txtUSDCosta_TextChanged(object sender, EventArgs e)
        {
            txtUSDCosta.Text = (Convert.ToDecimal(txtCostaAmount.Text)
                * Convert.ToDecimal(txtCostaRate.Text)
                ).ToString("0.00");
        }

        private void txtUSDEuro_TextChanged(object sender, EventArgs e)
        {
            txtUSDEuro.Text = (Convert.ToDecimal(txtEuroAmount.Text)
                * Convert.ToDecimal(txtEuroRate.Text)
                ).ToString("0.00");
        }

        private void usdTextChange(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAus.Text) +
                Convert.ToDecimal(txtUSDBhu.Text) +
                Convert.ToDecimal(txtUSDCosta.Text) +
                Convert.ToDecimal(txtUSDEuro.Text)
               
               ).ToString("0.00");
        }
    }
    }
    

