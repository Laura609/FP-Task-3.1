using System.Windows;
using System;
using System.Windows.Controls;

namespace ML_Task_3.View.Pages.TaskPages
{
    public partial class Task5Page : Page
    {
        public Task5Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = 4.2, b = 5.3, c = 1.5;
                double A = -0.35, B = 1.8, C = -1.8;
                double А = 2.8, В = 5, С = 2;
                if (Math.Exp(a + b) > Math.Exp(x))
                {
                    MessageBox.Show($"1)y = {Math.Sin(Math.Exp(a + b)) + Math.Pow(x, 2)}\n" +
                        $"2)y = {Math.Sin(Math.Exp(A + B)) + Math.Pow(x, 2)}\n" +
                        $"3)y = {Math.Sin(Math.Exp(А + В)) + Math.Pow(x, 2)}", " задание 5",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Exp(a + b) == Math.Exp(x))
                {
                    MessageBox.Show($"1)y = {Math.Atan(a * b * c) + Math.Pow(Math.Sqrt(x), 3)}\n" +
                        $"2)y = {Math.Atan(A * B * C) + Math.Pow(Math.Sqrt(x), 3)}\n" +
                        $"3)y = {Math.Atan(А * В * С) + Math.Pow(Math.Sqrt(x), 3)}", " задание 5",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Exp(a + b) < Math.Exp(x))
                {
                    MessageBox.Show($"1)y = {Math.Cos(Math.Sqrt(Math.Abs(x + a * b * c)))}\n" +
                        $"2)y = {Math.Cos(Math.Sqrt(Math.Abs(x + A * B * C)))}\n" +
                        $"3)y = {Math.Cos(Math.Sqrt(Math.Abs(x + А * В * С)))}", " задание 5",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка 404", "задание 5",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
    }
}
