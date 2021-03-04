using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowCalculatorHandson
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Regex regex = new Regex("^[0-9]+$");
        //Regex regex = new Regex("^[0-9]+$");
        public void Add()
        {
            if (regex.IsMatch(textBox1.Text) && regex.IsMatch(textBox2.Text))
            {
                var result = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                MessageBox.Show(Convert.ToString(result));
            }
            else
            {
                MessageBox.Show("Please enter valid input for the operands");
            }

        }
        public void Subtract()
        {
            if (regex.IsMatch(textBox1.Text) && regex.IsMatch(textBox2.Text))
            {
                var result = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                MessageBox.Show(Convert.ToString(result));
            }
            else
            {
                MessageBox.Show("Please enter valid input for the operands");
            }
        }
        public void Multiply()
        {
            if (regex.IsMatch(textBox1.Text) && regex.IsMatch(textBox2.Text))
            {

                var result = int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                MessageBox.Show(Convert.ToString(result));
            }
            else
            {
                MessageBox.Show("Please enter valid input for the operands");
            }
        }
        public void Divide()
        {
            if (regex.IsMatch(textBox1.Text) && regex.IsMatch(textBox2.Text))
            {
                try
                {
                    var result = int.Parse(textBox1.Text) / int.Parse(textBox2.Text);
                    MessageBox.Show(Convert.ToString(result));
                }
                catch (Exception)
                {
                    MessageBox.Show("Invalid input");
                }
            }
            else
            {
                MessageBox.Show("Please enter valid input for the operands");
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                Add();
            }
            else if (radioButton2.Checked)
            {
                Subtract();
            }
            else if (radioButton3.Checked)
            {
                Multiply();

            }
            else if (radioButton4.Checked)
            {
                Divide();
            }
        }
    }
}
