﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hello
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name = textBox2.Text;
            MessageBox.Show("Здравствуй, "+name);
            
            
            textBox1.Text = "Здравствуй, " + name;
            Text = "Здравствуй, " + name;
        }
    }
}