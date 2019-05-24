using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TugasAkhir_Majid_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox6.ReadOnly = true;
            textBox8.ReadOnly = true;
            textBox10.ReadOnly = true;
            textBox11.ReadOnly = true;
            textBox12.ReadOnly = true;
            textBox13.ReadOnly = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }
                
        private void button1_Click(object sender, EventArgs e)
        {
            double a = double.Parse(textBox14.Text);
            double b = double.Parse(textBox15.Text);
            if (comboBox1.SelectedIndex == 0)
            {
                double bk = a * b * 0.5;
                textBox13.Text = bk.ToString();
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                double jg = a * b;
                textBox13.Text = jg.ToString();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                double ll = a * b * 0.5;
                textBox13.Text = ll.ToString();
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                double lk = 3.14 * a;
                textBox13.Text = lk.ToString();
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                double ps = a * b;
                textBox13.Text = ps.ToString();
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                double pp = a * b;
                textBox13.Text = pp.ToString();
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                double st = a * b * 0.5;
                textBox13.Text = st.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox13.Text = String.Empty;
            textBox14.Text = String.Empty;
            textBox15.Text = String.Empty;
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!char.IsDigit(ch) && ch != 8 && ch != 44)
            {
                e.Handled = true;
            }
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
