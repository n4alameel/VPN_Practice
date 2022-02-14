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
    /// Логика взаимодействия для AppWindow.xaml
    /// </summary>
    public partial class AppWindow : Window
    {
        public AppWindow()
        {
            InitializeComponent();
            Stop.Visibility = Visibility.Hidden;
            vpn v = new vpn("w");
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Start.Visibility = Visibility.Hidden;
            Stop.Visibility = Visibility.Visible;
            
        }

        private void Stop_Click(object sender, RoutedEventArgs e)
        {
            Start.Visibility = Visibility.Visible;
            Stop.Visibility = Visibility.Hidden;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void EventsButton_Click(object sender, RoutedEventArgs e)
        {
            Events events = new Events();
            events.Owner = this;
            this.Hide();
            events.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MenuWindow menuWindow = new MenuWindow();
            menuWindow.Owner = this;
            this.Hide();
            menuWindow.Show();
        }

        private void Location_Click(object sender, RoutedEventArgs e)
        {
            LocationWindow locationWindow = new LocationWindow();
            locationWindow.Owner = this;
            this.Hide();
            locationWindow.Show();
        }

        private void MonoDefenseBut_Click(object sender, RoutedEventArgs e)
        {
            MonoDefenseWindow monoDefenseWindow = new MonoDefenseWindow();
            monoDefenseWindow.Owner = this;
            this.Hide();
            monoDefenseWindow.Show();
        }

        private void BuyPremium_Click(object sender, RoutedEventArgs e)
        {
            PremiumWindow premiumWindow = new PremiumWindow();
            premiumWindow.Owner = this;
            this.Hide();
            premiumWindow.Show();
        }

        private void ChooseServer_Click(object sender, RoutedEventArgs e)
        {
            ServersWindow serversWindow = new ServersWindow();
            serversWindow.Owner = this;
            this.Hide();
            serversWindow.Show();
        }

        private void nonClientArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }
}
