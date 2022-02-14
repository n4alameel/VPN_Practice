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
    /// Логика взаимодействия для EnterKey.xaml
    /// </summary>
    public partial class EnterKey : Window
    {
        public EnterKey()
        {
            InitializeComponent();
            Pass1.MaxLength = 1;
            Pass2.MaxLength = 1;
            Pass3.MaxLength = 1;
            Pass4.MaxLength = 1;
            Pass5.MaxLength = 1;
            Pass6.MaxLength = 1;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            this.Owner.Show();
        }

       

        private void Pass1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pass2.Focus();
        }

        private void Pass2_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pass3.Focus();
        }

        private void Pass3_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pass4.Focus();
        }

        private void Pass4_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pass5.Focus();
        }

        private void Pass5_TextChanged(object sender, TextChangedEventArgs e)
        {
            Pass6.Focus();
        }

        private void Pass6_TextChanged(object sender, TextChangedEventArgs e)
        {
            Label1.Content = "Wrong code";
            Label1.Visibility = Visibility.Visible;
            AppWindow window1 = new AppWindow();
            window1.Show();
            this.Close();
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
