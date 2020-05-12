using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PressMe_third_task_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            
            InitializeComponent();
            button1.Text = "НАЖМИ МЕНЯ";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(button1.Text== "НАЖМИ МЕНЯ")
            {
                button1.Text = "Вы нажа-а-а-а-ли меня!!!!";
            }
            else
            {
                Close();
            }
        }
    }
}
