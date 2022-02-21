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
    /// Логика взаимодействия для AdditionalSlotsWindow.xaml
    /// </summary>
    public partial class AdditionalSlotsWindow : Window
    {
        public AdditionalSlotsWindow()
        {
            InitializeComponent();
        }


        private void Shoppings_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Hide_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Owner.Show();
            this.Owner.Close();
        }

        private void Minimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Owner.Close();
            this.Owner.Close();

        }

        private void Monthly1slot_Click(object sender, RoutedEventArgs e)
        {
            const string url = "https://my.keepsolid.com/pricing/buy/12119/?platform=Win&purchase_id=12119#prch12119";
            Process.Start(url);
        }

        private void Monthly5slots_Click(object sender, RoutedEventArgs e)
        {
            const string url = "https://my.keepsolid.com/pricing/buy/12129/?platform=Win&purchase_id=12129#prch12129";
            Process.Start(url);
        
        }

        private void Monthly10slots_Click(object sender, RoutedEventArgs e)
        {
            const string url = "https://my.keepsolid.com/pricing/buy/12134/?platform=Win&purchase_id=12134#prch12134";
            Process.Start(url);
        
        }

        private void Year1slot_Click(object sender, RoutedEventArgs e)
        {
            const string url = "https://my.keepsolid.com/pricing/buy/12139/?platform=Win&purchase_id=12139#prch12139";
            Process.Start(url);
        }

        private void Year5slots_Click(object sender, RoutedEventArgs e)
        {
            const string url = "https://my.keepsolid.com/pricing/buy/12149/?platform=Win&purchase_id=12149#prch12149";
            Process.Start(url);
        }

        private void Year10slots_Click(object sender, RoutedEventArgs e)
        {
            const string url = "https://my.keepsolid.com/pricing/buy/12154/?platform=Win&purchase_id=12154#prch12154";
            Process.Start(url);
        }

        private void Infinity5slots_Click(object sender, RoutedEventArgs e)
        {
            const string url = "https://my.keepsolid.com/pricing/buy/12112/?platform=Win&purchase_id=12112#prch12112";
            Process.Start(url);
        }

        private void nonClientArea_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }
    }

    
    }
    
