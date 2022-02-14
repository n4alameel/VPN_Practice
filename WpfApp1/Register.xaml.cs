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
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
            Create.IsEnabled = false;
            
           

        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            Owner.Show();
            this.Close();
        }

  

        private void Agreement_Clicked(object sender, RoutedEventArgs e)
        {
            if((bool)Agreement.IsChecked == true){
                Create.IsEnabled = true;
            }
            if ((bool)Agreement.IsChecked == false)
            {
                Create.IsEnabled = false;
            }
        }

        private void Create_Click(object sender, RoutedEventArgs e)
        {
            if (Email.Text.Length == 0 || Password.Password.Length == 0) MessageBox.Show("Input email and password");
            else if (Confirm.Password.Length == 0) MessageBox.Show("Confirm password!");
            else
            {
                EnterKey enterKey = new EnterKey();
                enterKey.Owner = this.Owner;
                this.Close();
                enterKey.Show();
            }
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void nonClientArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
