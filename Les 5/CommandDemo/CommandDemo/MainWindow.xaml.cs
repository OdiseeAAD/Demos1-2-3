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

namespace CommandDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool isChecked = true;

        public ICommand ShutDownCommand { get; set; }
        public bool IsChecked { get => isChecked; set => isChecked = value; }
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
           
            ShutDownCommand = new RelayCommand(
                ()=> Application.Current.Shutdown(),
                ()=> IsChecked
                );
        }
    }
}