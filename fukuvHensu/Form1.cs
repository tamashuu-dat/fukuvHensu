using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukuvHensu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Left += int.Parse(textBox1.Text);
            label1.Top += int.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "-5";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "-5";
            textBox2.Text = "0";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "5";
            textBox2.Text = "0";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "5";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("玉井秀兵");
            timer1.Enabled = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
