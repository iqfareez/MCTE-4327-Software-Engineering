using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1_Encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void encryptButton_Click(object sender, EventArgs e)
        {
            var key = "mysmallkey1234551298765134567890";
            var output = Encrypt(inputTextBox.Text, key);
            outputTextBox.Text = output;

        }

        public string Encrypt(string plantext, string key)
        {
            byte[] message = Encoding.ASCII.GetBytes(plantext);
            byte[] key_bytes = Encoding.ASCII.GetBytes(key);
            var provider = new AesCryptoServiceProvider();
            var stream = new MemoryStream();
            // TODO: Fix this error
            var encryptor = provider.CreateEncryptor(key_bytes, key_bytes);
            var cryptoStream = new CryptoStream(stream, encryptor, CryptoStreamMode.Write);
            cryptoStream.Write(message, 0, message.Length);
            cryptoStream.FlushFinalBlock();
            byte[] encrypted = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(encrypted, 0, encrypted.Length);
            return Convert.ToBase64String(encrypted); //Convert to base64 representation (otherwise textbox cannot display)
        }
    }
}
