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
        double inputNo,outputNo;
        string convertionType;

       

        private void ConvertButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void convertFrom_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        public MainWindow()
        {
            InitializeComponent();
            input.Text= "0";
        }
    }
}
