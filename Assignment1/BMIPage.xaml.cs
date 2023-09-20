﻿using System;
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
    public sealed partial class BMIPage : Page
    {
        public BMIPage()
        {
            this.InitializeComponent();
        }

        

        private void btnCalculateBMI_Click(object sender, RoutedEventArgs e)
        private void btnHome_Click_1(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void btnCalculateBMI_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(heightCM.Text, out double height) && double.TryParse(weightKG.Text, out double weight))
            {
                // Calculate BMI
                double bmi = weight / ((height / 100) * (height / 100));

                // Display the result in bmiResult TextBox
                bmiResult.Text = $"Your BMI is: {bmi:F2}";
            }
            else
            {
                // Handle invalid input
                bmiResult.Text = "Please enter valid height and weight.";
            }
        }
    }
}
