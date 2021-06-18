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
    /// Логика взаимодействия для Lands.xaml
    /// </summary>
    public partial class Lands : Window
    {
        public Lands()
        {
            InitializeComponent();
            Gland.ItemsSource = new sessionsEntities().lands.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Rieltor rieltor = new Rieltor();
            rieltor.Show();
            Hide();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
