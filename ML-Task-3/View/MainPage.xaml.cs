using ML_Task_3.Core;
using ML_Task_3.View.Pages.TaskPages;
using System;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

using System.Windows.Media.Animation;

namespace ML_Task_3.View
{
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Click1(object sender, System.Windows.RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task1Page());
        }

        private void Button_Click2(object sender, System.Windows.RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task2Page());
        }

        private void Button_Click3(object sender, System.Windows.RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task3Page());
        }

        private void Button_Click4(object sender, System.Windows.RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task4Page());
        }

        private void Button_Click5(object sender, System.Windows.RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task5Page());
        }

        private void Button_Click6(object sender, System.Windows.RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task6Page());
        }

        private void Button_Click7(object sender, System.Windows.RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task7Page());
        }

        private void Button_Click8(object sender, System.Windows.RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task8Page());
        }

        private void Button_Click9(object sender, System.Windows.RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task9Page());
        }

        private void Button_Click10(object sender, System.Windows.RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task10Page());
        }

        private void Button_Click11(object sender, System.Windows.RoutedEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task11Page());
        }
    }
}

