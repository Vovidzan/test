﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Width = Convert.ToInt32(textBox1.Text);
            Height = Convert.ToInt32(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Owner.Width = Convert.ToInt32(textBox1.Text);
            Owner.Height = Convert.ToInt32(textBox2.Text);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner.Text= textBox3.Text;
        }
    }
}
