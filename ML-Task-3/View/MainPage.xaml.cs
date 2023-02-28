using ML_Task_3.View.Pages.TaskPages;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ML_Task_3.View
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            

        }

                        //Кнопки заданий//

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(new Task4Page());
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(new Task5Page());
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(new Task6Page());
        }

        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(new Task7Page());
        }

        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(new Task8Page());
        }

        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(new Task9Page());
        }

        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(new Task10Page());
        }


        //Кнопка выхода//

        private void BtnLogout_Click(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}

