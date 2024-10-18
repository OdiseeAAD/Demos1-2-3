using System.ComponentModel;
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

namespace DemoBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public class Person: DependencyObject, INotifyPropertyChanged
    {
        private string name;

        public string Name
        {
            get => name;
            set
            {
                name = value;
                HelloText = $"Hello {name}";
                HelloText2 = $"Hallo {name}";
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Name"));
            }
        }



        public string HelloText2
        {
            get { return (string)GetValue(HelloText2Property); }
            set { SetValue(HelloText2Property, value); }
        }

        // Using a DependencyProperty as the backing store for HelloText2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty HelloText2Property =
            DependencyProperty.Register("HelloText2", typeof(string), typeof(Person), new PropertyMetadata(""));




        private string helloText;

        public event PropertyChangedEventHandler? PropertyChanged;

        public string HelloText
        {
            get { return helloText; }
            set { 
                helloText = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("HelloText"));
            }
        }

    }
    public partial class MainWindow : Window
    {
        public Person Person { get; set; } = new Person();


        public MainWindow()
        {
            InitializeComponent();
            Person.Name = "Johm";
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Person.Name = "World";
        }
    }
}