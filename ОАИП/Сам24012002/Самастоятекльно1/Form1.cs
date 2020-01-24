using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Самастоятекльно1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            textBox13.Text = Convert.ToString(str.Length);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
            textBox11.Text = "";
            textBox12.Text = "";
            textBox13.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int s = Convert.ToInt32(textBox2.Text);
            int d = Convert.ToInt32(textBox3.Text);
            textBox9.Text = Convert.ToString(str.Remove(s -1, d - 1));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int s = Convert.ToInt32(textBox4.Text);
            string d = textBox8.Text;
            textBox10.Text = Convert.ToString(str.Insert(s - 1, d));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            int s = Convert.ToInt32(textBox5.Text);
            int d = Convert.ToInt32(textBox7.Text);
            textBox11.Text = Convert.ToString(str.Substring(s - 1, d));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string str = textBox1.Text;
            string s = textBox6.Text;
            textBox12.Text = Convert.ToString(str.IndexOf(s) + 1);
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
