using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsHandsOn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int CountChars()
        {
            int count = 0;
            using (StreamReader sr = new StreamReader("C: \\Users\\ramya\\source\\repos\\WindowsFormsHandsOn\\WindowsFormsHandsOn\\TextFile1.txt"))
            {
                string content = sr.ReadToEnd();
                count=content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountChars);
            task.Start();

            label1.Text = "Processing File. Please wait....";
            int count = await task;
            label1.Text = count.ToString() + " characters in file";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
