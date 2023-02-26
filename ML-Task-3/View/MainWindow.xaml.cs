using ML_Task_3.Core;
using ML_Task_3.View;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
namespace ML_Task_3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CoreNavigate.MyCore = MainFrame;

            Frame.Navigate(new MainPage());
        }

        public Frame? MainFrame { get; }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
    }
}

