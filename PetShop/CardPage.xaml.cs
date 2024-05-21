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
    /// Логика взаимодействия для CardPage.xaml
    /// </summary>
    public partial class CardPage : Page
    {
        public CardPage()
        {
            InitializeComponent();
            DGrid.ItemsSource = ZooEntities.GetContext().Card.ToList();

        }

        private void DGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BUT_Add_Click(object sender, RoutedEventArgs e)
        {
            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("NewCardPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
