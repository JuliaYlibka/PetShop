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
    /// Логика взаимодействия для NewWorkerPage.xaml
    /// </summary>
    public partial class NewWorkerPage : Page
    {
        public NewWorkerPage()
        {
            InitializeComponent();
        }

        private void Return_Click(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new Uri("WorkerPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private void BUT_Add_Worker_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUT_Create_Job_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUT_Search_Job_Click(object sender, RoutedEventArgs e)
        {
            Test win2 = new Test();
            win2.Show();

        }
    }
}
