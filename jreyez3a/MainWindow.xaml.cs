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

namespace jreyez3a
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public  MainWindow()
        {
            InitializeComponent();
        }

        

        

        private void calcButton_Click_1(object sender, RoutedEventArgs e)
        {
            resultTxt0.Text = Ex3aLoops.Calc0(
                inputTxt0a.Text, inputTxt0b.Text, inputTxt0c.Text);

            resultTxt1.Text = Ex3aLoops.Calc1(
                inputTxt1a.Text, inputTxt1b.Text, inputTxt1c.Text);

            resultTxt2.Text = Ex3aLoops.Calc2(
                inputTxt2a.Text, inputTxt2b.Text, inputTxt2c.Text);
            
            resultTxt3.Text = Ex3aLoops.Calc3(
                inputTxt3a.Text, inputTxt3b.Text, inputTxt3c.Text);

            resultTxt4.Text = Ex3aLoops.Calc4(
                inputTxt4a.Text, inputTxt4b.Text, inputTxt4c.Text);

            resultTxt5.Text = Ex3aLoops.Calc5(
                inputTxt5a.Text, inputTxt5b.Text, inputTxt5c.Text);

            resultTxt9.Text = Ex3aLoops.Calc6(
                inputTxt9a.Text, inputTxt9c.Text);

            resultTxt7.Text = Ex3aLoops.Calc7(
                inputTxt7a.Text, inputTxt7c.Text);

            resultTxt8.Text = Ex3aLoops.Calc8(
                inputTxt8a.Text, inputTxt8c.Text);


        }

        
    }
}
