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

namespace ZAD3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            if (double.TryParse(PriceTextBox.Text, out double price))
            {
                for (double weight = 1.2; weight <= 2.0; weight += 0.2)
                {
                    double cost = price * weight;
                    ResultListBox.Items.Add($"{weight} kg: {cost:C}");
                }
            }
            else
            {
                MessageBox.Show("Ошибка.");
            }
        }
    }
}
