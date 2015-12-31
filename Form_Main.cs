using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Base64Translator {
    public partial class Form_Main : Form {
        public Form_Main() {
            InitializeComponent();
            comboBox_TextEncoding.SelectedIndex = 0;
        }

        private Encoding GetSelectedEncoding() {
            switch(comboBox_TextEncoding.SelectedItem.ToString()) {
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
                textBox_CipherText.Enabled = true;
            } catch(FormatException) {
                textBox_CipherText.Text = "Invalid clear text.";
                textBox_CipherText.Enabled = false;
            }
        }

        private void textBox_ClearText_TextChanged(object sender, EventArgs e) {
            if(textBox_ClearText.Focused)
                ChangeCipherText();
        }

        private void textBox_CipherText_TextChanged(object sender, EventArgs e) {
            if(textBox_CipherText.Focused)
                try {
                    textBox_ClearText.Text = Base64Translator.DecryptBase64(textBox_CipherText.Text, GetSelectedEncoding());
                    textBox_ClearText.Enabled = true;
                } catch(FormatException) {
                    textBox_ClearText.Text = "Invalid cipher text.";
                    textBox_ClearText.Enabled = false;
                }
        }

        private void Form_Main_SizeChanged(object sender, EventArgs e) {
            Size newSize = new Size(textBox_ClearText.Width, (Height - 102) / 2);
            textBox_ClearText.Size = textBox_CipherText.Size = newSize;
        }

        private void comboBox_TextEncoding_SelectedIndexChanged(object sender, EventArgs e) {
            ChangeCipherText();
        }
    }
}
