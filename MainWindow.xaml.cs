using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace UnitConvertor
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

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(InputValue.Text, out double inputValue))
            {
                string fromUnit = ((ComboBoxItem)FromUnit.SelectedItem).Content.ToString();
                string toUnit = ((ComboBoxItem)ToUnit.SelectedItem).Content.ToString();
                double conversionFactor = Conversion(fromUnit, toUnit);
                double conversionResult = inputValue * conversionFactor;
                Result.Text = conversionResult.ToString();
            }
            else
            {
                Result.Text = "Invalid Input";
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            InputValue.Text = string.Empty;
            FromUnit.SelectedIndex = -1;
            ToUnit.SelectedIndex = -1;
            Result.Text = string.Empty;
        }

        private double Conversion(string fromUnit, string toUnit)
        {
            double factor = 1.0;

            if (fromUnit == "Meters")
            {
                switch (toUnit)
                {
                    case "Kilometers":
                        factor = 0.001; 
                        break;
                    case "Feet": factor = 3.28084; break;
                    case "Miles": factor = 0.000621371; break;
                }
            }
            else if (fromUnit == "Kilometers")
            {
                switch (toUnit)
                {
                    case "Meters": factor = 1000.0; break;
                    case "Feet": factor = 3280.84; break;
                    case "Miles": factor = 0.621371; break;
                }
            }
            else if (fromUnit == "Feet")
            {
                switch (toUnit)
                {
                    case "Meters": factor = 0.3048; break;
                    case "Kilometers": factor = 0.0003048; break;
                    case "Miles": factor = 0.000189394; break;
                }
            }
            else if (fromUnit == "Miles")
            {
                switch (toUnit)
                {
                    case "Meters": factor = 1609.34; break;
                    case "Kilometers": factor = 1.60934; break;
                    case "Feet": factor = 5280.0; break;
                }
            }

            return factor;
        }
    }
}
