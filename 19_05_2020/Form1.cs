using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _19_05_2020
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            radioButton1.Text = "Зачем на кнопку нажал, а?";
        }

        private void RadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RadioButton2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((char)Keys.Enter==e.KeyChar)
            {
                Close();
            }
        }
    }
}
