using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2_Login_system
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // read from text file
            var lines = File.ReadAllLines(@"C:\Users\Registration\Downloads\list.txt");
            for (var i = 0; i < lines.Length; i += 1)
            {
                var data = lines[i].Split(',');
                dataGridView1.Rows.Add(data);             
            }
        }
    }
}
