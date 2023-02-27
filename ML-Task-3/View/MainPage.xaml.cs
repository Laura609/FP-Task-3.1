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

        private void BtnTask1_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(new Task1Page());
        }
    
        private void BtnTask2_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(new Task2Page());
        }

        private void BtnTask3_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(typeof(Task3Page));
        }

        private void BtnTask4_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(typeof(Task4Page));
        }

        private void BtnTask5_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(typeof(Task5Page));
        }

        private void BtnTask6_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(typeof(Task6Page));
        }

        private void BtnTask7_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(typeof(Task7Page));
        }

        private void BtnTask8_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(typeof(Task8Page));
        }

        private void BtnTask9_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(typeof(Task9Page));
        }

        private void BtnTask10_Click(object sender, RoutedEventArgs e)
        {
            FramePanel.Navigate(typeof(Task10Page));
        }


                        //Кнопка выхода//
        private void BtnLogout_Click(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

    }
}

