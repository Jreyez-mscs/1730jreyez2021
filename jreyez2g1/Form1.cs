using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jreyez2g1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            // 1a) Switch with no default
            resultSwitch01Txt.Text = Ex2gCalculations.Switch01(input1aTxt.Text);

            // 1b Seperate 'if' statements
            resultIf01Txt.Text = Ex2gCalculations.If01(input1aTxt.Text);

            // 1c if elseif
            resultElseif01Txt.Text = Ex2gCalculations.ElseIf01(input1aTxt.Text);

            // 1d nested if - else
            resultNestedIf01Txt.Text = Ex2gCalculations.NestedIfElse01(input1aTxt.Text);

            // 1e SwitchDefault
            resultSwitchDefault01Txt.Text = Ex2gCalculations.SwitchDefault01(input1aTxt.Text);

            //1bAlt other value = 0
            resultIfAltTxt.Text = Ex2gCalculations.IfDefault01(input1aTxt.Text);

            //1cAlt other value = 0
            resultElseIfAlt.Text = Ex2gCalculations.ElseIfDefault01(input1aTxt.Text);

            //1dAlt other value = 0
            resultNestedIfAlt.Text = Ex2gCalculations.NestedIfElseDefault01(input1aTxt.Text);

            //2a
            resultSwitch02Txt.Text = Ex2gCalculations.Switch02(input2aTxt.Text);

            //2b
            resultIf02Txt.Text = Ex2gCalculations.If02(input2aTxt.Text);

            //3b
            resultElseIf02Txt.Text = Ex2gCalculations.ElseIf02(input2aTxt.Text);

            //4b
            resultNestedIf02Txt.Text = Ex2gCalculations.NestedIfElse02(input2aTxt.Text);
        }
    }
}
