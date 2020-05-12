using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesKilometers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            float miles = 0;
            try {
                miles = float.Parse(textBox1.Text);
                label2.Text = "Указанное число миль равно:" + Math.Round(miles* 1.609344,2)+" км";

            }
            catch
            {
                MessageBox.Show("Введите число, пожалуйста.");

            }


        }
    }
}
