using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string loc;
            OpenFileDialog op = new OpenFileDialog();
            op.InitialDirectory = "C:\\Users\\ramya\\source\\repos\\HandsOn\\WindowsForms2";
            op.Filter="JPG files (*.jpg)|*.jpg|All Files(*.*)|*.*";
            op.Title = "Choose Picture";
            op.ShowDialog();
            if((int)DialogResult.OK==1)
            {
                loc = op.FileName;
                label1.Text = loc;
                pictureBox1.ImageLocation = loc;
            }
        }
    }
}
