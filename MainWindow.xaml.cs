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

namespace UnitConvertor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double inputValue;
        public MainWindow()
        {
            InitializeComponent();

        }
        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {

            if (double.TryParse(InputValue.Text, out inputValue))
            {
                string fromUnit = (FromUnit.SelectedItem as ComboBoxItem)?.Content.ToString();
                string toUnit = (ToUnit.SelectedItem as ComboBoxItem)?.Content.ToString();

                double conversionFactor = GetConversionFactor(fromUnit, toUnit);

                double result = inputValue * conversionFactor;
                Result.Text = $"{inputValue} {fromUnit} = {result} {toUnit}";
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }


        private double GetConversionFactor(string fromUnit, string toUnit)
        {
          
            double factor = 1.0;

            switch (fromUnit)
            {
                case "Meters":
                    switch (toUnit)
                    {
                        case "Meters":
                            factor = 1.0;
                            break;
                        case "Kilometers":
                            factor = 0.001;
                            break;
                        case "Feet":
                            factor = 3.28084;
                            break;
                        case "Miles":
                            factor = 0.000621371;
                            break;
                    }
                    break;
                case "Kilometers":
                    switch (toUnit)
                    {
                        case "Meters":
                            factor = 1000.0;
                            break;
                        case "Kilometers":
                            factor = 1.0;
                            break;
                        case "Feet":
                            factor = 3280.84;
                            break;
                        case "Miles":
                            factor = 0.621371;
                            break;
                    }
                    break;
                case "Feet":
                    switch (toUnit)
                    {
                        case "Meters":
                            factor = 0.3048;
                            break;
                        case "Kilometers":
                            factor = 0.0003048;
                            break;
                        case "Feet":
                            factor = 1.0;
                            break;
                        case "Miles":
                            factor = 0.000189394;
                            break;
                    }
                    break;
                case "Miles":
                    switch (toUnit)
                    {
                        case "Meters":
                            factor = 1609.34;
                            break;
                        case "Kilometers":
                            factor = 1.60934;
                            break;
                        case "Feet":
                            factor = 5280.0;
                            break;
                        case "Miles":
                            factor = 1.0;
                            break;
                    }
                    break;
            }

            return factor;
        }
    }

}
