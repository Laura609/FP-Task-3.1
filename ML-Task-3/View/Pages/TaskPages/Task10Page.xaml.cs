using System.Windows;
using System;
using System.Windows.Controls;

namespace ML_Task_3.View.Pages.TaskPages
{

    public partial class Task10Page : Page
    {
        public Task10Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = 0.1, b = 9.8, c = 11.12;
                double A = 10, B = 10.05, C = 6.2;
                double А = 100, В = 3.03, С = 7.12;
                if (Math.Log10(a) < x)
                {
                    MessageBox.Show($"1)y = {Math.Pow(Math.Sqrt(Math.Pow(b, 2) + Math.Sqrt(Math.Abs(x + c))), 3)}\n" +
                        $"2)y = {Math.Pow(Math.Sqrt(Math.Pow(B, 2) + Math.Sqrt(Math.Abs(x + C))), 3)}\n" +
                        $"3)y = {Math.Pow(Math.Sqrt(Math.Pow(В, 2) + Math.Sqrt(Math.Abs(x + С))), 3)}", " задание 10",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Log10(a) == x)
                {
                    MessageBox.Show($"1)y = {Math.Cos(x - b - c)}\n" +
                        $"2)y = {Math.Cos(x - B - C)}\n" +
                        $"3)y = {Math.Cos(x - В - С)}", " задание 10",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Log10(a) > x)
                {
                    MessageBox.Show($"1)y = {Math.Sin(x + a - b)}\n" +
                        $"2)y = {Math.Sin(x + A - B)}\n" +
                        $"3)y = {Math.Sin(x + А - В)}", " задание 10",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка 404", "задание 10",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
    }
}
