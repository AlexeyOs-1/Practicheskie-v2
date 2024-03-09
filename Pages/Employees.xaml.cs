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
using WpfApp1.Pages;

namespace WpfApp1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Employees.xaml
    /// </summary>
    public partial class Employees : Page
    {
        public Employees()
        {
            InitializeComponent();
            DataGridEmployee.ItemsSource = EmployeesEntities.GetContext().Employees.ToList();
        }

        private void DataGridEmployee_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ButtonEdit_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonDel_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void ButtonAdd_OnClick(object sender, RoutedEventArgs e)
        {
            EmployeesFrame?.Navigate(new AddEditPage());
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
