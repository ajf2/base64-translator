using System;
using System.Text;

namespace Base64Translator_WPF {
    class Base64Translator {
        /// <exception cref="FormatException"></exception>
        public static string EncryptBase64(string input, Encoding encoding) {
            byte[] inBytes = encoding.GetBytes(input);
            return Convert.ToBase64String(inBytes);
        }

        /// <exception cref="FormatException"></exception>
        public static string DecryptBase64(string input, Encoding encoding) {
            byte[] inBytes = Convert.FromBase64String(input);
            return encoding.GetString(inBytes);
        }
    }
}
