using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace MyCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        double firstnumber, secondnumber, result;
        string operation;

        private void Num0_Click(object sender, RoutedEventArgs e)
        {
            answerdisplay.Text = answerdisplay.Text + "0";
        }

        private void Num1_Click(object sender, RoutedEventArgs e)
        {
            answerdisplay.Text = answerdisplay.Text + "1";
        }

        private void Num2_Click(object sender, RoutedEventArgs e)
        {
            answerdisplay.Text = answerdisplay.Text + "2";
        }

        private void Num3_Click(object sender, RoutedEventArgs e)
        {
            answerdisplay.Text = answerdisplay.Text + "3";
        }

        private void Num4_Click(object sender, RoutedEventArgs e)
        {
            answerdisplay.Text = answerdisplay.Text + "4";
        }

        private void Num5_Click(object sender, RoutedEventArgs e)
        {
            answerdisplay.Text = answerdisplay.Text + "5";
        }

        private void Num6_Click(object sender, RoutedEventArgs e)
        {
            answerdisplay.Text = answerdisplay.Text + "6";
        }

        private void Num7_Click(object sender, RoutedEventArgs e)
        {
            answerdisplay.Text = answerdisplay.Text + "7";
        }

        private void Num8_Click(object sender, RoutedEventArgs e)
        {
            answerdisplay.Text = answerdisplay.Text + "8";
        }

        private void Num9_Click(object sender, RoutedEventArgs e)
        {
            answerdisplay.Text = answerdisplay.Text + "9";
        }

        private void Divide_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = double.Parse(answerdisplay.Text);
            operation = "/";
            answerdisplay.Text = " ";
            numinput.Text = firstnumber + " " + operation;
        }

        private void Multiply_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = double.Parse(answerdisplay.Text);
            operation = "x";
            answerdisplay.Text = " ";
            numinput.Text = firstnumber + " " + operation;
        }

        private void Subtract_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = double.Parse(answerdisplay.Text);
            operation = "-";
            answerdisplay.Text = " ";
            numinput.Text = firstnumber + " " + operation;
        }

        private void Add_Click(object sender, RoutedEventArgs e)
        {
            firstnumber = double.Parse(answerdisplay.Text);
            operation = "+";
            answerdisplay.Text = " ";
            numinput.Text = firstnumber + " " + operation;
        }

        private void Dot_Click(object sender, RoutedEventArgs e)
        {
            answerdisplay.Text = answerdisplay.Text + ".";
        }

        private void Percent_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            numinput.Text = "";
            answerdisplay.Text = "";
        }

        private void Equals_Click(object sender, RoutedEventArgs e)
        {
            secondnumber = double.Parse(answerdisplay.Text);
            switch (operation)
            {
                case "+":
                    numinput.Text = firstnumber + " " + operation + " " + secondnumber;
                    result = firstnumber + secondnumber;
                    break;
                case "-":
                    numinput.Text = firstnumber + " " + operation + " " + secondnumber;
                    result = firstnumber - secondnumber;
                    break;
                case "x":
                    numinput.Text = firstnumber + " " + operation + " " + secondnumber;
                    result = firstnumber * secondnumber;
                    break;
                case "/":
                    numinput.Text = firstnumber + " " + operation + " " + secondnumber;
                    result = firstnumber / secondnumber;
                    break;
            }
            answerdisplay.Text = result.ToString();
        }
    }
}
