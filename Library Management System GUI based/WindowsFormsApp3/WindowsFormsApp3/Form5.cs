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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = @"C:\Users\Lenovo\source\repos\WindowsFormsApp3\WindowsFormsApp3\Books.txt";
            using (StreamReader file = new StreamReader(str))
            {
                string ln;
                while ((ln = file.ReadLine()) != null)
                {
                    if (ln == textBox4.Text)
                    {
                        textBox2.Text = ln;
                        ln = file.ReadLine();
                        textBox5.Text = ln;
                        ln = file.ReadLine();
                        textBox3.Text = ln;
                        ln = file.ReadLine();
                        textBox1.Text = ln;
                        break;
                    }
                }
                file.Close();
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            System.Windows.Forms.Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 obj= new Form2();
            obj.ShowDialog();
        }
    }
}
