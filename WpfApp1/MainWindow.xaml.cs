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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetKey_Click(object sender, RoutedEventArgs e)
        {
            Register window1 = new Register();
            window1.Owner = this;
            this.Hide();
            window1.Show();
        }

        private void Get_Click(object sender, RoutedEventArgs e)
        {
            EnterKey enterKey = new EnterKey();
            enterKey.Owner = this;
            this.Hide();
            enterKey.Show();
            
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            AppWindow window1 = new AppWindow();
            window1.Show();
            this.Close();
           
        }
    }
}
