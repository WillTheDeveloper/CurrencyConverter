﻿using System;
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
        double USD = 0.5;
        double GBP = 0.6;


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

            switch (status)
            {
                case (true):
                    
                    break;

                case (false):
                    
                    break;
            }
        }
    }
}
