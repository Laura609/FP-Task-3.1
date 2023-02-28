using System.Windows;
using System;
using System.Windows.Controls;

namespace ML_Task_3.View.Pages.TaskPages
{
    public partial class Task4Page : Page
    {
        public Task4Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = 0.2, b = 0.5, z = Math.Exp(a * x);
                double A = 0.15, B = 0.2, Z = Math.Exp(2 * A * x);
                double А = 0.15, В = 0.2, З = Math.Exp(2 * A * x);
                if (x < -Math.ILogB(a))
                {
                    MessageBox.Show($"1)y = {a * Math.Pow(Math.Sin(x), 2) + b * Math.Cos(z * x)}\n" +
                        $"2)y = {A * Math.Pow(Math.Sin(x), 2) + B * Math.Cos(Z * x)}\n" +
                        $"3)y = {А * Math.Pow(Math.Sin(x), 2) + В * Math.Cos(З * x)}", " задание 4",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (-Math.ILogB(a) <= x && x <= b)
                {
                    MessageBox.Show($"1)y = {Math.Pow(a, b) - Math.Pow(Math.Cos(a + z * x), 3)}\n" +
                        $"2)y = {Math.Pow(A, B) - Math.Pow(Math.Cos(A + Z * x), 3)}\n" +
                        $"3)y = {Math.Pow(А, В) - Math.Pow(Math.Cos(В + З * x), 3)}", " задание 4",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (x > b)
                {
                    MessageBox.Show($"1)y = {Math.Sqrt(2.5 * Math.Pow(a, 3) + Math.Pow(b - z * Math.Pow(x, 2), 6))}\n" +
                        $"2)y = {Math.Sqrt(2.5 * Math.Pow(A, 3) + Math.Pow(B - Z * Math.Pow(x, 2), 6))}\n" +
                        $"3)y = {Math.Sqrt(2.5 * Math.Pow(А, 3) + Math.Pow(В - З * Math.Pow(x, 2), 6))}", " задание 4",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка 404", "задание 4",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
    }
}

