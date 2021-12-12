using System;
using System.Collections.Generic;
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
            string value1 = richTextBox1.Text;
            string value2 = richTextBox2.Text;

            value2 = value1;
            
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

            var control = new Form().ActiveControl;

            switch (status)
            {
                case (true):
                    control.BackColor = Color.Black;
                    label1.ForeColor = Color.White;
                    break;

                case (false):
                    control.BackColor = Color.LightGray;
                    label1.ForeColor = Color.Black;
                    break;
            }
        }
    }
}
