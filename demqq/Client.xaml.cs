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
    /// Логика взаимодействия для Client.xaml
    /// </summary>
    public partial class Client : Window
    {
        public Client()
        {
            InitializeComponent();
            CLI.ItemsSource = new sessionsEntities().houses.ToList();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Go go = new Go();
            go.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Rieltor rieltor = new Rieltor();
            rieltor.Show();
            Hide();
        }

        private void CLI_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
