﻿using System.Text;
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

        Func<string, string> encrypt = ReverseEncryptor.Encrypt;
        Func<string, string> decrypt = ReverseEncryptor.Decrypt;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            if(sender== reverseRadioButton)
            {
                encrypt = ReverseEncryptor.Encrypt;
                decrypt = ReverseEncryptor.Decrypt;
            }
            else if(sender== shiftOneRadioButton)
            {
                encrypt = ShiftOneEncryptor.Encrypt;
                decrypt = ShiftOneEncryptor.Decrypt;
            }
             else if(sender == reverseAlphabetRadioButton)
            {
                encrypt = ReverseAlphabetEncryptor.Encrypt;
                decrypt = ReverseAlphabetEncryptor.Decrypt;
            }
        }

        private void Encrypted_Click(object sender, RoutedEventArgs e)
        {
            encryptTextBox.Text = encrypt(decryptTextBox.Text);
        }

        private void Decrypted_Click(object sender, RoutedEventArgs e)
        {
            decryptTextBox.Text = decrypt(encryptTextBox.Text);
        }
    }
}