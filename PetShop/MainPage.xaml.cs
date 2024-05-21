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

namespace PetShop
{

    public partial class MainPage : Page
    {

        public MainPage()
        {
            InitializeComponent();

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();

        }

        private void BUT_Order_Click(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new Uri("OrderPage.xaml", UriKind.RelativeOrAbsolute));

        }

        private void BUT_Supply_Click(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new Uri("SupplyPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BUT_Sotrudnyky_Click(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new Uri("WorkerPage.xaml", UriKind.RelativeOrAbsolute));

        }
    }
}
