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
    /// Логика взаимодействия для BuySubscribeWindow.xaml
    /// </summary>
    public partial class BuySubscribeWindow : Window
    {
        public BuySubscribeWindow()
        {
            InitializeComponent();
            Choice.IsChecked = true;
           
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Close();
            this.Close();
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }


        private void Choice_Click(object sender, RoutedEventArgs e)
        {
            if (Upgrade.IsChecked == true) Upgrade.IsChecked = false;
            const string url = "https://my.keepsolid.com/pricing/buy/35/?platform=Win&purchase_id=35#prch35";
            Process.Start(url);
        
        }

        private void Upgrade_Click(object sender, RoutedEventArgs e)
        {
            if (Choice.IsChecked == true) Choice.IsChecked = false;
            const string url = "https://www.keepsolid.com/monodefense/pricing?price=26440";
            Process.Start(url);
        
        }

        private void nonClientArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void WhatIsMD_Click(object sender, RoutedEventArgs e)
        {
            const string url = "https://www.keepsolid.com/monodefense/ru/what-is-md";
            Process.Start(url);
        }

        private void Continue_Click(object sender, RoutedEventArgs e)
        {
            if(Upgrade.IsChecked == true)
            {
                const string url = "https://www.keepsolid.com/monodefense/pricing?price=26440";
                Process.Start(url);
            }
            else if (Choice.IsChecked == true)
            {
                const string url = "https://my.keepsolid.com/pricing/buy/35/?platform=Win&purchase_id=35#prch35";
                Process.Start(url);
            }
        }
    }
}
