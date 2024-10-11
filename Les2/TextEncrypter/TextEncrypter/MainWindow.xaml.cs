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

namespace TextEncrypter
{

    public interface IEncryptor
    {
        string Decrypt(String toDecrypt);
        string Encrypt(String toEncrypt);
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        IEncryptor encryptor = new ReverseEncryptor();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender== reverseRadioButton)
            {
                encryptor = new ReverseEncryptor();
            }
            else if(sender== shiftOneRadioButton)
            {
                encryptor = new ShiftOneEncryptor();
            }
             else if(sender == reverseAlphabetRadioButton)
            {
                encryptor = new ReverseAlphabetEncryptor();
            }
        }

        private void Encrypted_Click(object sender, RoutedEventArgs e)
        {
            encryptTextBox.Text = encryptor.Encrypt(decryptTextBox.Text);
        }

        private void Decrypted_Click(object sender, RoutedEventArgs e)
        {
            decryptTextBox.Text = encryptor.Decrypt(encryptTextBox.Text);
        }
    }
}