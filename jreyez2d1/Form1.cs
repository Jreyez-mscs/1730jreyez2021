using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jreyez2d1
{
    public partial class Week7project : Form
    {
        public Week7project()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnFailValue_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "xyz";
            txtTest2.Text = "xyz";
            txtTest3.Text = "2.4";
            txtTest4.Text = "true";
            txtTest5a.Text = "2";
            txtTest5b.Text = "3";
            txtTest6.Text = "Jones";
            txtTest7.Text = "0";
            txtTest8a.Text = "1";
            txtTest8b.Text = "1";
            txtTest9.Text = "499";
            txtTest10a.Text = "4";
            txtTest10b.Text = "3";
        }

        private void btnPassValue_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "Frank";
            txtTest2.Text = "";
            txtTest3.Text = "2.3";
            txtTest4.Text = "false";
            txtTest5a.Text = "2";
            txtTest5b.Text = "2";
            txtTest6.Text = "xyz";
            txtTest7.Text = "1";
            txtTest8a.Text = "1";
            txtTest8b.Text = "2";
            txtTest9.Text = "500";
            txtTest10a.Text = "3";
            txtTest10b.Text = "3";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            txtResult1.Text = "Fail :[";
            txtResult2.Text = "Fail :[";
            txtResult3.Text = "Fail :[";
            txtResult4.Text = "Fail :[";
            txtResult5.Text = "Fail :[";
            txtResult6.Text = "Fail :[";
            txtResult7.Text = "Fail :[";
            txtResult8.Text = "Fail :[";
            txtResult9.Text = "Fail :[";
            txtResult10.Text = "Fail :[";

            txtResult1B.Text = "Winner!";
            txtResult2b.Text = "Winner!";
            txtResult3b.Text = "Winner!";
            txtResult4b.Text = "Winner!";
            txtResult5b.Text = "Winner!";
            txtResult6b.Text = "Winner!";
            txtResult7b.Text = "Winner!";
            txtResult8b.Text = "Winner!";
            txtResult9b.Text = "Winner!";
            txtResult10b.Text = "Winner!";

            if (txtTest1.Text == "Frank")
                txtResult1.Text = "Winner!";
            if (txtTest1.Text != "Frank")
                txtResult1B.Text = "Fail :[";

            decimal val3 = Convert.ToDecimal(txtTest3.Text);
            if (val3 == 2.3m)
                txtResult3.Text = "Winner!";
            if (val3 != 2.3m)
                txtResult3b.Text = "Fail :[";

            if (txtTest2.Text == "")
                txtResult2.Text = "Winner!";
            if (txtTest2.Text != "")
                txtResult2b.Text = "Fail :[";

            bool val4 = Convert.ToBoolean(txtTest4.Text);
            if (val4 == false)
                txtResult4.Text = "Winner!";
            if (val4 != false)
                txtResult4b.Text = "Fail :[";
            //This is how to convert values or variables into booleans to use for true or false statements //

            int val5A = Convert.ToInt32(txtTest5a.Text);
            int val5B = Convert.ToInt32(txtTest5b.Text);
            if (val5A == val5B)
                txtResult5.Text = "Winner!";
            if (val5A != val5B)
                txtResult5b.Text = "Fail :[";

            if (txtTest6.Text != "Jones")
                txtResult6.Text = "Winner!";
            if (txtTest6.Text == "Jones")
                txtResult6b.Text = "Fail :[";

            int val7 = Convert.ToInt32(txtTest7.Text);
            if (val7 > 0)
                txtResult7.Text = "Winner!";
            if (val7 == 0)
                txtResult7b.Text = "Fail :[";

            int val8A = Convert.ToInt32(txtTest8a.Text);
            int val8b = Convert.ToInt32(txtTest8b.Text);
            if (val8A < val8b)
                txtResult8.Text = "Winner!";
            if (val8A >= val8b)
                txtResult8b.Text = "Fail :[";

            int val9 = Convert.ToInt32(txtTest9.Text);
            if (val9 >= 500)
                txtResult9.Text = "Winner!";
            if (val9 < 500)
                txtResult9b.Text = "Fail :[";

            int val10A = Convert.ToInt32(txtTest10a.Text);
            int val10b = Convert.ToInt32(txtTest10b.Text);
            if (val10A <= val10b)
                txtResult10.Text = "Winner!";
            if (val10A > val10b)
                txtResult10b.Text = "Fail :[";
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
