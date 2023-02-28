using System.Windows;
using System;
using System.Windows.Controls;
namespace ML_Task_3.View.Pages.TaskPages
{
    public partial class Task8Page : Page
    {
        public Task8Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double x = Convert.ToDouble(TBx.Text);
                double k = 3.1, m = 5.15, n = -1.15;
                double K = 0.78, M = -2.4, N = 4.36;
                double К = 1.1, М = 0.8, Н = 0.41;
                if (Math.Pow(x, 2) > m + n)
                {
                    MessageBox.Show($"1)y = {Math.ILogB(Math.Abs(m * x + n))}\n" +
                        $"2)y = {Math.ILogB(Math.Abs(M * x + N))}\n" +
                        $"3)y = {Math.ILogB(Math.Abs(М * x + Н))}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Pow(x, 2) == m + n)
                {
                    MessageBox.Show($"1)y = {Math.Exp(Math.Cos(Math.Abs(m * x - n)))}\n" +
                        $"2)y = {Math.Exp(Math.Cos(Math.Abs(M * x - N)))}\n" +
                        $"3)y = {Math.Exp(Math.Cos(Math.Abs(М * x - Н)))}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
                if (Math.Pow(x, 2) < m + n)
                {
                    MessageBox.Show($"1)y = {Math.Pow(Math.Sqrt(Math.Pow(k, 2) + Math.Pow(Math.Cos(x), 2)), 3)}\n" +
                        $"2)y = {Math.Pow(Math.Sqrt(Math.Pow(K, 2) + Math.Pow(Math.Cos(x), 2)), 3)}\n" +
                        $"3)y = {Math.Pow(Math.Sqrt(Math.Pow(К, 2) + Math.Pow(Math.Cos(x), 2)), 3)}", " задание 8",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information);
                }
            }
            catch
            {
                MessageBox.Show("Ошибка 404", "задание 8",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
            }
        }
    }
}
