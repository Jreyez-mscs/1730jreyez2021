using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jreyez2f1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            // #1 
            result1Txt.Text = Ex2fCalculations.Calc01(input1aTxt.Text);

            // #2
            result2Txt.Text = Ex2fCalculations.Calc02(input2aTxt.Text);

            // #3
            result3Txt.Text = Ex2fCalculations.Calc03(input3aTxt.Text);

            // #4
            result4Txt.Text = Ex2fCalculations.Calc04(input4aTxt.Text);


            // #5
            result5Txt.Text = Ex2fCalculations.Calc05(input5aTxt.Text);
            // #6
            result6Txt.Text = Ex2fCalculations.Calc06(input6aTxt.Text, input6bTxt.Text);

            //#7
            result7Txt.Text = Ex2fCalculations.Calc07(input7aTxt.Text);

            //#8
            result8Txt.Text = Ex2fCalculations.Calc08(input8aTxt.Text, input8bTxt.Text);

            //#9
            result9Txt.Text = Ex2fCalculations.Calc09(input9aTxt.Text, input9bTxt.Text);

            //#10
            result10Txt.Text = Ex2fCalculations.Calc10(input10aTxt.Text, input10bTxt.Text);
        }


        
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void input9bTxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
