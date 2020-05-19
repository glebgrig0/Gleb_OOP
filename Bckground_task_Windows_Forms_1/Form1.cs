using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bckground_task_Windows_Forms_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if ((A.Location.X + A.Width) <= (B.Location.X -20))
            {
                A.Location = new Point(A.Location.X + 10, A.Location.Y);
                B.Location = new Point(B.Location.X- 10, B.Location.Y);
            }
        }

        private void B_Click(object sender, EventArgs e)
        {
            if (A.Location.X - 10 >= 0+ SystemInformation.BorderSize.Width)
            {
                A.Location = new Point(A.Location.X - 10, A.Location.Y);
            }
            int i = SystemInformation.BorderSize.Width;
            if ((B.Location.X + B.Width+10) < Width- SystemInformation.BorderSize.Width-4) //-4 нужно, т.к граница в около 6 пикселей слева у окна не является частью окна
            {
                B.Location = new Point(B.Location.X + 10, B.Location.Y);
            }
        }
    }
}
