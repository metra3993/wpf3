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
using wpf3.GymDataSetTableAdapters;

namespace wpf3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        customerTableAdapter customer = new customerTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
            CustomerDataGrid.ItemsSource = customer.GetFullInfo();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
          CustomerDataGrid.Columns[0].Visibility = Visibility.Collapsed;
          CustomerDataGrid.Columns[1].Header = "Имя";
          CustomerDataGrid.Columns[2].Header = "Фамилия";
          CustomerDataGrid.Columns[3].Header = "Отчество";
          CustomerDataGrid.Columns[4].Visibility = Visibility.Collapsed;
          CustomerDataGrid.Columns[5].Visibility = Visibility.Collapsed;
          CustomerDataGrid.Columns[6].Header = "Имя тренера";
          CustomerDataGrid.Columns[7].Header = "Фамилия тренера";
          CustomerDataGrid.Columns[8].Header = "Отчество тренера";
          CustomerDataGrid.Columns[9].Header = "Возраст тренера";
          CustomerDataGrid.Columns[10].Header = "Срок абонемента";
          CustomerDataGrid.Columns[11].Header = "Цена(руб.) абонемента";
        }

        private void newTable_Click(object sender, RoutedEventArgs e)
        {

            PageGymEF page = new PageGymEF();
            this.Content = page;
        }
    }
}
