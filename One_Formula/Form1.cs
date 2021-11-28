using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace One_Formula
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            double testVal;
            if (!Double.TryParse(textBox1.Text, out testVal))
            {
                textBox1.Clear();
                MessageBox.Show("Не число!");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Нехватка данных!");
            }
            else
            {
                double Result;
                double A = Convert.ToDouble(textBox1.Text);
                Result = Math.Cos(A) + Math.Cos(A) * 2 + Math.Cos(A) * 6 + Math.Cos(A) * 7;
                textBox3.Text = Result.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
