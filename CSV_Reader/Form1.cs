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
using System.Security;
using System.Diagnostics;

namespace CSV_Reader
{
    public partial class Form1 : Form
    {
        public object FilePath { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("請輸入存放位址");
                return;
            }
            else
            {
                StreamReader r = new StreamReader(textBox1.Text);
                textBox3.Text = r.ReadLine(); 

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog dialog = new OpenFileDialog())  
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    string s = dialog.FileName;
                    textBox1.Text = s;
                }

        
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
        //    String FR = textBox2.Text;
        //    string[] = textBox2.Text.Split(" ");
        //    if (FR = )
               

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
