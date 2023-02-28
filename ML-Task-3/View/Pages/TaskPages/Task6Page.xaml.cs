using System.Windows;
using System;
using System.Windows.Controls;

namespace ML_Task_3.View.Pages.TaskPages
{
    public partial class Task6Page : Page
    {
        public Task6Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double a = -5, b = 5.3, z = Math.ILogB(b * Math.Pow(x, 3));
                double A = 3, B = 5, Z = Math.ILogB(b * x);
                double А = -10, В = 3, З = Math.ILogB(b * Math.Pow(x, 2));
                if (x < a)
                {
                    MessageBox.Show($"1)y = {2.8 * Math.Pow(Math.Sin(a * x), 2) - b * Math.Pow(x, 3) * z}\n" +
                        $"2)y = {2.8 * Math.Pow(Math.Sin(A * x), 2) - B * Math.Pow(x, 3) * Z}\n" +
                        $"3)y = {2.8 * Math.Pow(Math.Sin(А * x), 2) - В * Math.Pow(x, 3) * З}", " задание 6",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (a <= x && x <= Math.Pow(b, 2))
                {
                    MessageBox.Show($"1)y = {z * Math.Cos(Math.Pow(a * x + b, 2)) + Math.ILogB(z)}\n" +
                        $"2)y = {Z * Math.Cos(Math.Pow(A * x + B, 2)) + Math.ILogB(Z)}\n" +
                        $"3)y = {z * Math.Cos(Math.Pow(А * x + В, 2)) + Math.ILogB(З)}", " задание 6",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (x > Math.Pow(b, 2))
                {
                    MessageBox.Show($"1)y = {Math.Exp(2.5 * a * x) + z * a * b * x}\n" +
                        $"2)y = {Math.Exp(2.5 * A * x) + Z * A * B * x}\n" +
                        $"3)y = {Math.Exp(2.5 * А * x) + З * А * В * x}", " задание 6",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка 404", "задание 6",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
    }
}
