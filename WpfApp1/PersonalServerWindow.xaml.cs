using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для PersonalServerWindow.xaml
    /// </summary>
    public partial class PersonalServerWindow : Window
    {
        public PersonalServerWindow()
        {
            InitializeComponent();
        }

        private void nonClientArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void HideButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Close();
            this.Owner.Owner.Show();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }

        private void ShoppingsButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }
    }
}
