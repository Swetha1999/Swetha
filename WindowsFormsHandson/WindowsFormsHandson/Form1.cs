using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsHandson
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
            using (StreamReader sr = new StreamReader("C:\\Users\\swetha\\source\\repos\\WindowsFormsHandson\\WindowsFormsHandson\\Text.txt"))
            {
                string content = sr.ReadToEnd();
                count = content.Length;
                Thread.Sleep(5000);
            }
            return count;
        }
        

        private async void button2_Click(object sender, EventArgs e)
        {
            Task<int> task = new Task<int>(CountChars);
            task.Start();

            label2.Text = "Processing File. Please wait....";
            int count = await task;
            label2.Text = count.ToString() + " characters in file";

        }
    }
}
