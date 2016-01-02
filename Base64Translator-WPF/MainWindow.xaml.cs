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

namespace Base64Translator_WPF {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            comboBox_TextEncoding.SelectedIndex = 0;
        }

        private Encoding GetSelectedEncoding() {
            var selectedItem = (ListBoxItem)comboBox_TextEncoding.SelectedItem;
            switch(selectedItem.Content.ToString()) {
                case "UTF-8":
                    return Encoding.UTF8;
                case "UTF-16":
                    return Encoding.Unicode;
                case "UTF-32":
                    return Encoding.UTF32;
                default:
                    return Encoding.ASCII;
            }
        }

        private void ChangeCipherText() {
            try {
                textBox_CipherText.Text = Base64Translator.EncryptBase64(textBox_ClearText.Text, GetSelectedEncoding());
                textBox_CipherText.IsEnabled = true;
            } catch(FormatException) {
                textBox_CipherText.Text = "Invalid clear text.";
                textBox_CipherText.IsEnabled = false;
            }
        }

        private void textBox_ClearText_TextChanged(object sender, TextChangedEventArgs e) {
            if(textBox_ClearText.IsFocused)
                ChangeCipherText();
        }

        private void textBox_CipherText_TextChanged(object sender, TextChangedEventArgs e) {
            if(textBox_CipherText.IsFocused)
                try {
                    textBox_ClearText.Text = Base64Translator.DecryptBase64(textBox_CipherText.Text, GetSelectedEncoding());
                    textBox_ClearText.IsEnabled = true;
                } catch(FormatException) {
                    textBox_ClearText.Text = "Invalid cipher text.";
                    textBox_ClearText.IsEnabled = false;
                }
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e) {
            //Size newSize = new Size(textBox_ClearText.Width, (Height - 102) / 2);
            //textBox_ClearText.RenderSize = textBox_CipherText.RenderSize = newSize;
        }

        private void comboBox_TextEncoding_SelectionChanged(object sender, SelectionChangedEventArgs e) {
            ChangeCipherText();
        }
    }
}
