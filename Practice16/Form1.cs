using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practice16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void SplitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void SplitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            int value1, value2, value3;
            try
            {
                value1 = int.Parse(textBox1.Text);
                value2 = int.Parse(textBox2.Text);
                value3 = int.Parse(textBox3.Text);
            }
            catch
            {
                label1.Text = "Введите числа во все поля.";
                return;
            }
            string result = "Результат:";
            if (checkBox1.Checked)
            {
                result += " СУММ:" + (value1 + value2 + value3);
            }
            if (checkBox2.Checked)
            {
                int nod = Math.Min(value1, Math.Min(value2, value3));
                for (; nod > 1; nod--)
                {
                    if (value1 % nod == 0 && value2 % nod == 0 && value3 % nod == 0)
                    {
                        break;
                    }
                }
                result += " НОД:" + nod;
            }
            if (checkBox3.Checked)
            {
                result += " Произведение:" + (value3 * value2 * value1);
            }
            label1.Text = result;
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Вы закроете приложение, уверены?", "Выйти", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                Close();

            }

        }
    }
}
