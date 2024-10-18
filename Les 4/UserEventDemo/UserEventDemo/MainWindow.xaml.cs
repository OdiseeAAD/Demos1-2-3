using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //  ListViewObject.PersonClicked += DetailViewObject.ShowViewObject.SetDetail;
            // ListViewObject.PersonClicked += ListViewObject_PersonClicked;

            ListViewObject.PropertyChanged += ListViewObject_PropertyChanged;
            DetailViewObject.AddView.AddPerson += AddView_AddPerson;
        }

        private void AddView_AddPerson(object? sender, Person person)
        {
            ListViewObject.AddPerson(person);
        }

        private void ListViewObject_PropertyChanged(object? sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            if(e.PropertyName == "SelectedPerson")
            { 
                DetailViewObject.ShowViewObject.SetDetail(ListViewObject.SelectedPerson);
            }
        }

        private void ListViewObject_PersonClicked(object? sender, Person e)
        {
//            throw new NotImplementedException();
        }

    }
}