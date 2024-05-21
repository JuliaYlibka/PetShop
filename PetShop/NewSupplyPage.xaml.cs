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
    /// <summary>
    /// Логика взаимодействия для NewSupplyPage.xaml
    /// </summary>
    public partial class NewSupplyPage : Page
    {
        public NewSupplyPage()
        {
            InitializeComponent();
        }

        private void BUT_Search_Supply_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUT_Search_Provider_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUT_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUT_Done_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUT_Reurn_Click(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new Uri("SupplyPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void TB_NumSup_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TB_Provider_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TB_Sum_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TB_Product_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TB_Kolvo_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TB_Stoim_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void PoductList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
