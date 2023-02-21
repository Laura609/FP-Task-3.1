using ML_Task_3.Core;
using ML_Task_3.View;
using System.Windows;
using System.Windows.Input;
namespace ML_Task_3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CoreNavigate.MyCore = MainFrame;

            MainFrame.Navigate(new MainPage());
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ButtonState == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
            private void Border_MouseDown(object sender, MouseButtonEventArgs e)
            {
                if (e.ClickCount == 2)
                {
                    Application.Current.Shutdown();
                }
            }
    }
}

