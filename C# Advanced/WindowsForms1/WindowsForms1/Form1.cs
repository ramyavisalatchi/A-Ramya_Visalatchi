using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                int res = int.Parse(textBox1.Text) + int.Parse(textBox2.Text);
                MessageBox.Show("The Result is" + res);
            }
            else if (radioButton2.Checked == true)
            {
                int res = int.Parse(textBox1.Text) - int.Parse(textBox2.Text);
                MessageBox.Show("The Result is" + res);
            }
            else if (radioButton3.Checked == true)
            {
                int res= int.Parse(textBox1.Text) * int.Parse(textBox2.Text);
                MessageBox.Show("The Result is" + res);
            }
            else if (radioButton4.Checked == true)
            {
                if(int.Parse(textBox2.Text)==0)
                {
                    MessageBox.Show("INVALID INPUT");
                }
                else
                {

                    float res = float.Parse(textBox1.Text) / float.Parse(textBox2.Text);
                    MessageBox.Show("The Result is" + res);
                }
            }
        }
    }
}
