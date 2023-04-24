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

namespace ZAD2
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
        private void BtnCancelClick(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void BtnOKClick(object sender, RoutedEventArgs e)
        {
            try
            {
                int sum = 0; // сумма трехзначных чисел
                int count = 0; // количество трехзначных чисел

                for (int i = 0; i < ListBoxData.Items.Count; i++)
                {
                    // запрашиваем у пользователя число
                    int number = Convert.ToInt32(ListBoxData.Items[i]);

                    // проверяем, является ли число трехзначным
                    if (number >= 100 && number <= 999)
                    {
                        sum += number; // добавляем число к сумме
                        count++; // увеличиваем количество трехзначных чисел
                    }
                }

                // проверяем, были ли введены трехзначные числа
                if (count == 0)
                {
                    TextBlockAnswer.Text = ("NO");
                }
                else
                {
                    // выводим среднее арифметическое трехзначных чисел
                    double average = (double)sum / count;
                    TextBlockAnswer2.Text = ("Среднее арифметическое: " + average);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((String.IsNullOrEmpty(TbNumber.Text)))
            {
                return;
            }
            try
            {
                int xa = Convert.ToInt32(TbNumber.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("Введены не корректные данные");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ListBoxData.Items.Add(TbNumber.Text);
        }
    }
}
