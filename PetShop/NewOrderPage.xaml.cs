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
    /// Логика взаимодействия для NewOrderPage.xaml
    /// </summary>
    public partial class NewOrderPage : Page
    {
        public NewOrderPage()
        {
            InitializeComponent();
            PoductList.ItemsSource = new List<Job>()
        {
            new Job{Job_ID = 1, Название = "test",Оклад = 516516},

        };
            // устанавливаем отображаемое свойство
            PoductList.DisplayMemberPath = "Job_ID";

        }

        private void PoductList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }


        private void BUT_Done_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUT_Add_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUT_Reurn_Click(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);
            nav.Navigate(new Uri("OrderPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}
