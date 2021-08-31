using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;

namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        private Encryptorr encryptor = new Encryptorr();
        private string filePath = "none";
        public Form1()
        {
            InitializeComponent();
          
        }

        private void Open_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    filePath= openFileDialog1.FileName;
                    Path_textBox.Text = filePath;
                    byte[] data = encryptor.ReadFile(filePath);
                    textBox1.Text= BitConverter.ToString(data);
          
                }
                catch
                {

                }
            
            }
        }
        private void Encrypt_btn_Click(object sender, EventArgs e)
        {
            if(filePath != "none")
            {
                encryptor.WriteEncryptedFile(filePath);
                MessageBox.Show("File Encrypted !");

            }
            else
            {
                MessageBox.Show("You must open a file first to encrypt it !😜");
            }
        }
    }
}
