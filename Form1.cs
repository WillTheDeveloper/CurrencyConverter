using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CurrencyCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox2.Text = richTextBox1.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void darkmode_CheckedChanged(object sender, EventArgs e)
        {
            var status = darkmode.Checked;
            
            switch (status)
            {
                case (true):
                    Form1.ActiveForm.BackColor = Color.Black;
                    label1.ForeColor = Color.White;
                    label2.ForeColor = Color.White;
                    label3.ForeColor = Color.White;
                    richTextBox1.ForeColor = Color.DarkGray;
                    richTextBox2.ForeColor = Color.DarkGray;
                    break;

                case (false):
                    Form1.ActiveForm.BackColor = Color.LightGray;
                    label1.ForeColor = Color.Black;
                    label2.ForeColor = Color.Black;
                    label3.ForeColor = Color.Black;
                    richTextBox1.ForeColor = Color.White;
                    richTextBox2.ForeColor= Color.White;
                    break;
            }
        }

        private void plus1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "1";
            }
            else if (richTextBox1.Text != "")
            {
                int a = Int32.Parse(richTextBox1.Text);
                int b = ++a;
                richTextBox1.Text = b.ToString();
            }
        }

        private void minus1_Click(object sender, EventArgs e)
        {
            if (richTextBox1.Text == "")
            {
                richTextBox1.Text = "1";
            }
            else if (richTextBox1.Text == "0")
            {
                //Nothing should happen
            }
            else if (richTextBox1.Text != "1")
            {
                int a = Int32.Parse(richTextBox1.Text);
                int b = --a;
                richTextBox1.Text = b.ToString();
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            comboBox1.SelectedItem = "";
            comboBox2.SelectedItem = "";
        }
    }
}
