using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var sb = new StringBuilder();
            sb.AppendLine($"Form size: {Size.Width};{Size.Height};");
            sb.AppendLine($"Checkbox1: {checkBox1.Checked}");
            sb.AppendLine($"Checkbox2: {checkBox2.Checked}");
            sb.AppendLine($"textBox1: {textBox1.Text}");

            if (string.IsNullOrWhiteSpace(sb.ToString()))
            {
                return;
            }
            else
            {
                File.WriteAllText(Path.Combine(Environment.CurrentDirectory, "elements.txt"), sb.ToString());
            }
        }
    }
}
