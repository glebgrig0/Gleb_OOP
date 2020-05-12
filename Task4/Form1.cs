using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            TotalTries = 0;
            Tries = 0;
            InitializeComponent();
        }
        private int Tries;
        private int TotalTries;
        private void Button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int rand = random.Next(0, 10);
            int input;
            try
            {
                input = int.Parse(textBox1.Text);
            }
            catch
            {
                MessageBox.Show("Введите число.");
                return;
            }
            if (rand == int.Parse(textBox1.Text))
            {
                label2.Location = new Point(label2.Location.X + 10, label2.Location.Y);
                label2.Text = "Вы угадали.";

            }
            else
            {
                if (TotalTries>=10)
                {  
                    label3.Text = "Ваш коэфицент невезучести равен:"+ (float)Tries /1000;
                }
                else
                {
                    Tries += 1;
                    label2.Text = "Вы не угадали.";
                    label2.Location = new Point(label2.Location.X + 10, label2.Location.Y);

                }
            }
            TotalTries += 1;
        }

    }
}
