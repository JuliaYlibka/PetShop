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
    /// Логика взаимодействия для WorkerPage.xaml
    /// </summary>
    public partial class WorkerPage : Page
    {
        public WorkerPage()
        {
            InitializeComponent();
            DGrid.ItemsSource = ZooEntities.GetContext().Worker.ToList();

        }

        private void DGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BUT_Change_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUT_Return_Click(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new Uri("MainPage.xaml", UriKind.RelativeOrAbsolute));

        }

        private void BUT_Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BUT_Add_Click(object sender, RoutedEventArgs e)
        {

            NavigationService nav = NavigationService.GetNavigationService(this);

            nav.Navigate(new Uri("NewWorkerPage.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}


/*
                  <DataGrid x:Name="DGrid" SelectionChanged="DGrid_SelectionChanged">
            <DataGrid.Columns>
                <DataGridTextColumn Header="Наименование" Width="*"  Binding="{Binding Job_ID}" />
            </DataGrid.Columns> </DataGrid>*/