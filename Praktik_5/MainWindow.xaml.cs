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

namespace Praktik_5
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
                int N = ListBoxData.Items.Count;
                int maxScore = 0; // максимальное количество правильных ответов
                bool hasZeroScore = false; // флаг для проверки наличия участников с нулевым количеством правильных ответов

                for (int i = 0; i < N; i++)
                {
                    int score = Convert.ToInt32(ListBoxData.Items[i]); // количество правильных ответов текущего участника
                    if (score > maxScore)
                    {
                        maxScore = score; // обновляем максимальное количество правильных ответов
                    }
                    if (score == 0)
                    {
                        hasZeroScore = true; // устанавливаем флаг, если найден участник с нулевым количеством правильных ответов
                    }
                }
                TextBlockAnswer.Text = $"{maxScore}";
                if (hasZeroScore)
                {
                    TextBlockAnswer2.Text="YES";
                }
                else
                {
                    TextBlockAnswer2.Text="NO";
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
