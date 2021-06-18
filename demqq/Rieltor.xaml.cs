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
using System.Windows.Shapes;

namespace demqq
{
    /// <summary>
    /// Логика взаимодействия для Rieltor.xaml
    /// </summary>
    public partial class Rieltor : Window
    {
        
        public Rieltor()
        {
            InitializeComponent();
            RIL.ItemsSource = new sessionsEntities().apartments.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Go go = new Go();
            go.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Client client = new Client();
            client.Show();
            Hide();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Go go = new Go();
            go.Show();
            Hide();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Lands lands = new Lands();
            lands.Show();
            Hide();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            districts districts = new districts();
            districts.Show();
            Hide();
        }
    }
}
