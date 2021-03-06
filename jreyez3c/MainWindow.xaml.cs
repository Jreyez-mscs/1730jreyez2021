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

namespace jreyez3c
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

        private void calcButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int index = int.Parse(inputTextBox0a.Text);
                resultTextBox0.Text = Ex3cCalculations.Calc0(index);

            }
            catch
            {
                MessageBox.Show("Invalid Input: " + this.inputTextBox0a.Text);
                resultTextBox0.Text = "";
            }

            try
            {
                string time = (inputTextBox1a.Text);
                resultTextBox1.Text = Ex3cCalculations.Calc1(time);

            }
            catch
            {
                MessageBox.Show("Invalid Input: " + this.inputTextBox1a.Text);
                resultTextBox1.Text = "";
            }

            try
            {
                int[] numbers2 = { 11, 22, 23, 34, 10 };
                resultTextBox2.Text = Ex3cCalculations.Calc2(numbers2).ToString();
            }
            catch
            {
                MessageBox.Show("Invalid Input ");
            }

            try
            {
                double[] numbers3 = { 11.1, 22.2, 23.3, 34.4, 9.0 };
                int count = int.Parse(inputTextBox3a.Text);
                resultTextBox3.Text = Ex3cCalculations.Calc3(numbers3, count).ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input " + this.inputTextBox3a.Text);
            }

            double[] numbers4 = new double[inputListBox4a.Items.Count];
            int i = 0;
            
            for (i = 0; i < 5; i++)

                numbers4[i] = double.Parse(inputListBox4a.Items[i].ToString());
            try
            {
                
                int count = int.Parse(inputTextBox3a.Text);
                resultTextBox4.Text = Ex3cCalculations.Calc3(numbers4, count).ToString();
            }
            catch
            {
                MessageBox.Show("Invalid input " + this.inputTextBox4a.Text);
            }
        }

        private void addItemButton4_Click(object sender, RoutedEventArgs e)
        {


        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            inputListBox4a.Items.Add("11.1");
            inputListBox4a.Items.Add("22.2");
            inputListBox4a.Items.Add("23.3");
            inputListBox4a.Items.Add("34.4");
            inputListBox4a.Items.Add("9.0");

            inputListBox5a.Items.Add("11.1");
            inputListBox5a.Items.Add("22.2");
            inputListBox5a.Items.Add("23.3");
            inputListBox5a.Items.Add("34.4");
            inputListBox5a.Items.Add("9.0");

            inputListBox6a.Items.Add("11.1");
            inputListBox6a.Items.Add("22.2");
            inputListBox6a.Items.Add("23.3");
            inputListBox6a.Items.Add("34.4");
            inputListBox6a.Items.Add("9.0");
        }
    }
}
