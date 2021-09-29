using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jreyez1f1
{
    public partial class CurrencyConvertV2 : Form
    {
        public CurrencyConvertV2()
        {
            InitializeComponent();
        }

        private void picAus_Click(object sender, EventArgs e)
        {

        }

        private void picBhuDim_Click(object sender, EventArgs e)
        {

        }

        private void CurrencyConvertV2_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAus.Image;
            btnBhutanese.BackgroundImage = picBhuDim.Image;
            btnCosta.BackgroundImage = picCostaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.717976";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = btnAustralia.Text + " :";
            txtCurrency.Focus();

        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAus.Image;
            btnBhutanese.BackgroundImage = picBhuDim.Image;
            btnCosta.BackgroundImage = picCostaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.717976";
            lblCurrency.Text = btnAustralia.Text + " :";
            txtCurrency.Text = "0.00";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnBhutanese_Click(object sender, EventArgs e)
        {
            btnBhutanese.BackgroundImage = picBhu.Image;
            btnAustralia.BackgroundImage = picAusDim.Image;
            btnCosta.BackgroundImage = picCostaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.0139831";
            lblCurrency.Text = btnBhutanese.Text + " :";
            txtCurrency.Text = "0.00";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnCosta_Click(object sender, EventArgs e)
        {
            btnCosta.BackgroundImage = picCosta.Image;
            btnAustralia.BackgroundImage = picAusDim.Image;
            btnBhutanese.BackgroundImage = picBhuDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            txtRate.Text = "0.00176122";
            lblCurrency.Text = btnCosta.Text + " :";
            txtCurrency.Text = "0.00";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnEuro_Click(object sender, EventArgs e)
        {
            btnEuro.BackgroundImage = picEuro.Image;
            btnAustralia.BackgroundImage = picAusDim.Image;
            btnBhutanese.BackgroundImage = picBhuDim.Image;
            btnCosta.BackgroundImage = picCostaDim.Image;
            txtRate.Text = "1.15528";
            lblCurrency.Text = btnEuro.Text + " :";
            txtCurrency.Text = "0.00";
            txtUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void lblCurrency_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSD.Text) +
                Convert.ToDecimal(txtTotalUSD.Text)
                ).ToString("0.00");
            txtCurrency.Focus();
            lblEquation.Text = lblEquation.Text + " + " + txtUSD.Text;
        }
       

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void txtUSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtRate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCurrency_TextChanged(object sender, EventArgs e)
        {
            txtUSD.Text = (Convert.ToDecimal(txtCurrency.Text)
                * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
            //To make it automatically change, you want to make the box that will trigger the change
            //into a TextChanged event, then, put the calculation you want done in code under that text changed 
            //string or start of it. This is for me because I had to back track to the prior lesson before realizing
            //it was resaid in the video
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void txtRate_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtTotalUSD_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtClear_Click(object sender, EventArgs e)
        {
            txtCurrency.Text = ("0.00");
            txtRate.Text = ("0.717976");
            txtTotalUSD.Text = ("0.00");
            btnAustralia.BackgroundImage = picAus.Image;
            btnBhutanese.BackgroundImage = picBhuDim.Image;
            btnCosta.BackgroundImage = picCostaDim.Image;
            btnEuro.BackgroundImage = picEuroDim.Image;
            lblCurrency.Text = btnAustralia.Text + " :";
            lblEquation.Text = " ";
            txtCurrency.Focus();
        }

        private void txtExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picAusDim_Click(object sender, EventArgs e)
        {

        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {

        }

        private void picBhu_Click(object sender, EventArgs e)
        {

        }
    }
}
