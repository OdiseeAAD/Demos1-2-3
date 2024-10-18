using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
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
    /// Interaction logic for AddView.xaml
    /// </summary>
    public partial class AddView : UserControl
    {
        public event EventHandler<Person> AddPerson;
        public AddView()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person p = new Person();
            p.Name = NameTextBox.Text;
            p.Email = EmailTextBox.Text;
            p.PhoneNumber = PhoneTextBox.Text;

            AddPerson?.Invoke(this,p);
        }
    }
}
