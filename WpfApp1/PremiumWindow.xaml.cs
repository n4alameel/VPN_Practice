using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
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
    /// Логика взаимодействия для PremiumWindow.xaml
    /// </summary>
    public partial class PremiumWindow : Window
    {
        public PremiumWindow()
        {
            InitializeComponent();
        }

       

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void nonClientArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _1year_Click(object sender, RoutedEventArgs e)
        {
            BuySubscribeWindow buySubscribeWindow = new BuySubscribeWindow();
            buySubscribeWindow.Owner = this;
            this.Hide();
            buySubscribeWindow.Show();
            buySubscribeWindow.Choice.Content = " 1 год \n $69.99 \n Оплачивается ежегодно";
            buySubscribeWindow.Upgrade.Content = "MonoDefense 1 год \n $99.99 \n Оплачивается ежегодно";
        }

        private void Infinity_Click(object sender, RoutedEventArgs e)
        {
            BuySubscribeWindow buySubscribeWindow = new BuySubscribeWindow();
            buySubscribeWindow.Owner = this;
            this.Hide();
            buySubscribeWindow.Show();
            buySubscribeWindow.Choice.Content = " Вечность \n $99.99 \n Оплачивается единоразово";
            buySubscribeWindow.Upgrade.Content = "MonoDefense вечность \n $199.99 \n Оплачивается единоразово";
        }

        private void _7days_Click(object sender, RoutedEventArgs e)
        {
            BuySubscribeWindow buySubscribeWindow = new BuySubscribeWindow();
            buySubscribeWindow.Owner = this;
            this.Hide();
            buySubscribeWindow.Show();
            const string url = "https://my.keepsolid.com/pricing/buy/130/?platform=Win&purchase_id=130#prch130";
            Process.Start(url);
        }

        private void _1month_Click(object sender, RoutedEventArgs e)
        {
            BuySubscribeWindow buySubscribeWindow = new BuySubscribeWindow();
            buySubscribeWindow.Owner = this;
            this.Hide();
            buySubscribeWindow.Show();
            buySubscribeWindow.Choice.Content = "1 месяц \n $11.99 \n Оплачивается ежемесячно";
            buySubscribeWindow.Upgrade.Content = "MonoDefense 1 месяц \n $14.99 \n Оплачивается ежемесячно";
        }

        private void AdditionalSlots_Click(object sender, RoutedEventArgs e)
        {
            AdditionalSlotsWindow additionalSlotsWindow = new AdditionalSlotsWindow();
            additionalSlotsWindow.Owner = this;
            this.Hide();
            additionalSlotsWindow.Show();
        }

        private void PersonalServer_Click(object sender, RoutedEventArgs e)
        {
            PersonalServerWindow personalServerWindow = new PersonalServerWindow();
            personalServerWindow.Owner = this;
            this.Hide();
            personalServerWindow.Show();
        }
    }
}
