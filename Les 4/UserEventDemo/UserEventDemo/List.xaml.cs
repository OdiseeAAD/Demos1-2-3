using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
    /// Interaction logic for List.xaml
    /// </summary>
    public partial class List : UserControl, INotifyPropertyChanged
    {
        public event EventHandler<Person> PersonClicked;
        public event PropertyChangedEventHandler? PropertyChanged;

        public Action<Person> PersonClicked2;

        public Person SelectedPerson
        {
            get => selectedPerson;
            set
            {
                selectedPerson = value;
                OnPropertyChanged();
            }
        }

        private List<Person> people = new List<Person>()
            {
                new Person() { Name = "John Doe", PhoneNumber = "1234567890", Email = "john.doe@example.com" },
                new Person() { Name = "Jane Smith", PhoneNumber = "9876543210", Email = "jane.smith@example.com" },
                new Person() { Name = "Mike Johnson", PhoneNumber = "5555555555", Email = "mike.johnson@example.com" }
            };
        private Person selectedPerson;

        public List()
        {
            InitializeComponent();
            PeopleListView.ItemsSource = people;
        }

        public void AddPerson(Person p)
        {
            people.Add(p);
            PeopleListView.ItemsSource = null;// Remove list from listview
            PeopleListView.ItemsSource = people;
        }


        private void PeopleListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(PeopleListView.SelectedItem!= null)
            {
                //OnPersonClicked((Person)PeopleListView.SelectedItem);
                SelectedPerson = (Person)PeopleListView.SelectedItem;
            }
        }

        /*        protected virtual void OnPersonClicked(Person person)
                {
                    PersonClicked?.Invoke(this, person);
                }*/

        protected virtual void OnPropertyChanged([CallerMemberName]string propertyName = "" )
        {
            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
