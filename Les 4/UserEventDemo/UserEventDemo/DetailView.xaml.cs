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

namespace UserEventDemo
{
    /// <summary>
    /// Interaction logic for DetailView.xaml
    /// </summary>
    public partial class DetailView : UserControl
    {
        public DetailView()
        {
            InitializeComponent();

            AddButton.Click += AddButton_Click;
            AddView.AddPerson += AddView_AddPerson;
           
        }

        private void AddView_AddPerson(object? sender, Person e)
        {
            ShowViewObject.Visibility = Visibility.Visible;
            AddView.Visibility = Visibility.Hidden;
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            ShowViewObject.Visibility = Visibility.Hidden;
            AddView.Visibility = Visibility.Visible;
        }
    }
}
