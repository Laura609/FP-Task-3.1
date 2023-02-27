using System.Windows;
using System;
using System.Windows.Controls;

namespace ML_Task_3.View.Pages.TaskPages
{

    public partial class Task2Page : Page
    {
        public Task2Page()
        {
            InitializeComponent();
        }

        private void BtnAnswer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                double k = 1, m = 1.8;

                MessageBox.Show($"x = {Math.Exp(m * k)} c = {Math.Pow(Math.Cos(m), 2) + Math.Pow(k, 2)}", " задание 2",
                        MessageBoxButton.OK,
                        MessageBoxImage.Information);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Задание 2",
                        MessageBoxButton.OK,
                        MessageBoxImage.Error);
            }
        }
    }
}
