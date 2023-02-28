using System.Windows;
using System;
using System.Windows.Controls;

namespace ML_Task_3.View.Pages.TaskPages
{
    public partial class Task9Page : Page
    {
        public Task9Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = 1.2, b = 7.2, z = Math.Exp(x);
                double A = -1.5, B = 3.2, Z = Math.Exp(2 * x);
                double А = 1.7, В = 5.5, З = Math.Exp(3);
                if (x < Math.Pow(a, 3))
                {
                    MessageBox.Show($"1)y = {a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x + a)}\n" +
                        $"2)y = {A * Math.Pow(Math.Sin(x), 2) + B * Math.Cos(Z * x + A)}\n" +
                        $"3)y = {А * Math.Pow(Math.Sin(x), 2) + В * Math.Cos(З * x + А)}", " задание 9",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Pow(a, 3) <= x && x <= b)
                {
                    MessageBox.Show($"1)y = {Math.Pow(a + b * x, 2) - Math.Sin(a + z * x)}\n" +
                        $"2)y = {Math.Pow(A + B * x, 2) - Math.Sin(A + Z * x)}\n" +
                        $"3)y = {Math.Pow(А + В * x, 2) - Math.Sin(А + З * x)}", " задание 9",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (x > b)
                {
                    MessageBox.Show($"1)y = {Math.Exp(2.5 * a * x) + z * a * b * x}\n" +
                        $"2)y = {Math.Exp(2.5 * A * x) + Z * A * B * x}\n" +
                        $"3)y = {Math.Exp(2.5 * А * x) + З * А * В * x}", " задание 9",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка 404", "задание 9",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
    }
}
