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

namespace WindowsFormsApp3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = @"C:\Users\Lenovo\source\repos\WindowsFormsApp3\WindowsFormsApp3\Books.txt";
            using (StreamWriter sw = File.AppendText(str))
            {
                sw.WriteLine(textBox2.Text);
                sw.WriteLine(textBox3.Text);
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox4.Text);
                sw.WriteLine("\n");
                sw.Close();
            }
            this.Close();
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = @"C:\Users\Lenovo\source\repos\WindowsFormsApp3\WindowsFormsApp3\Books.txt";
            using (StreamWriter sw = File.AppendText(str))
            {
                sw.WriteLine(textBox2.Text);
                sw.WriteLine(textBox3.Text);
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox4.Text);
                sw.WriteLine("\n");
                sw.Close();
            }
            this.Close();
            this.Hide();
            Form2 obj = new Form2();
            obj.ShowDialog();
        }
    }
}
