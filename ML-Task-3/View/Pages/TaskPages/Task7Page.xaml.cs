using System.Windows;
using System;
using System.Windows.Controls;

namespace ML_Task_3.View.Pages.TaskPages
{
    public partial class Task7Page : Page
    {
        public Task7Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = 3.2, b = -0.7, c = 2.2;
                double A = 10.5, B = -2.5, C = 5.6;
                double А = 5.4, В = 3, С = 2.6;
                if (Math.Abs(1 - Math.Pow(x, 2)) == a + c)
                {
                    MessageBox.Show($"1)y = {x * Math.Exp(a) + Math.Exp(Math.Abs(b * c))}\n" +
                        $"2)y = {x * Math.Exp(A) + Math.Exp(Math.Abs(B * C))}\n" +
                        $"3)y = {x * Math.Exp(А) + Math.Exp(Math.Abs(В * С))}", " задание 7",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Abs(1 - Math.Pow(x, 2)) > a + c)
                {
                    MessageBox.Show($"1)y = {Math.Pow(Math.Sin(a * x), 2) + Math.Cos(b * c)}\n" +
                        $"2)y = {Math.Pow(Math.Sin(A * x), 2) + Math.Cos(B * C)}\n" +
                        $"3)y = {Math.Pow(Math.Sin(А * x), 2) + Math.Cos(В * С)}", " задание 7",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Abs(1 - Math.Pow(x, 2)) < a + c)
                {
                    MessageBox.Show($"1)y = {Math.Sqrt(a * Math.Pow(b, 4) + Math.Pow(Math.Sqrt(c * Math.Pow(x, 2)), 5))}\n" +
                        $"2)y = {Math.Cos(Math.Sqrt(Math.Abs(x + A * B * C)))}\n" +
                        $"3)y = {Math.Cos(Math.Sqrt(Math.Abs(x + А * В * С)))}", " задание 7",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка 404", "задание 7",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
    }
}
