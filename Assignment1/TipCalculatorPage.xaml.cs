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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238


namespace Assignment1
{
    public sealed partial class TipCalculatorPage : Page
    {
        public TipCalculatorPage()
        {
            this.InitializeComponent();
        }

        

        private void btnCalculateTip_Click_1(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(billAmountTextBox.Text, out double bill) && double.TryParse(tipPercentTextBox.Text, out double tipPercentage))
            {
                double tip = (bill * tipPercentage) / 100;
                double totalBill = bill + tip;

                // Display the results in the tipResultTextBlock
                tipResultTextBlock.Text = $"Tip: {tip:C}\nTotal Bill: {totalBill:C}";
            }
            else
            {
                // Handle invalid input
                tipResultTextBlock.Text = "Invalid input. Please enter valid bill amount and tip percentage.";
            }
        }

        private void btnHome_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

    }
}

