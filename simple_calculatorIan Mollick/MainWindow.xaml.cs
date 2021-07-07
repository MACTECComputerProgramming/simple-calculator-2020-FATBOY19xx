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

namespace simple_calculatorIan_Mollick
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

        private void add_Click(object sender, RoutedEventArgs e)
        {
            double number1=0, number2=0, total =0;

            number1 = Convert.ToDouble(textBox.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 + number2;

            label.Content = total;

        }

        private void minus_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 - number2;

            label.Content = total;
        }

        private void multiply_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 * number2;

            label.Content = total;
        }

        private void division_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 / number2;

            label.Content = total;
        }

        private void modulus_Click(object sender, RoutedEventArgs e)
        {
            double number1 = 0, number2 = 0, total = 0;

            number1 = Convert.ToDouble(textBox.Text);

            number2 = Convert.ToDouble(textBox2.Text);

            total = number1 % number2;

            label.Content = total;


        }

        private void clearform_Click(object sender, RoutedEventArgs e)
        {
            textBox.Text = "";

            textBox2.Text = "";

            label.Content = "";


        }
    }
}
