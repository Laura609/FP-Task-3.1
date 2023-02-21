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

        private void Border_MouseDown1(object sender, MouseButtonEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task1Page());
        }
        private void Border_MouseDown2(object sender, MouseButtonEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task2Page());
        }

        private void Border_MouseDown3(object sender, MouseButtonEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task3Page());
        }

        private void Border_MouseDown4(object sender, MouseButtonEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task4Page());
        }

        private void Border_MouseDown5(object sender, MouseButtonEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task5Page());
        }

        private void Border_MouseDown6(object sender, MouseButtonEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task6Page());
        }

        private void Border_MouseDown7(object sender, MouseButtonEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task7Page());
        }

        private void Border_MouseDown8(object sender, MouseButtonEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task1Page());
        }

        private void Border_MouseDown9(object sender, MouseButtonEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task9Page());
        }

        private void Border_MouseDown10(object sender, MouseButtonEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task10Page());
        }

        private void Border_MouseDown11(object sender, MouseButtonEventArgs e)
        {
            CoreNavigate.MyCore?.Navigate(new Task11Page());
        }

    }
}

