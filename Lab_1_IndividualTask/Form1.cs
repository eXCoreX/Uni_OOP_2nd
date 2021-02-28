// Var 12

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_IndividualTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCopy_Click(object sender, EventArgs e)
        {
            label.Text = textBox.Text;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            BackColor = Color.DarkViolet;
            textBox.Text = "";
            label.Text = "Початок роботи";
            label.ForeColor = Color.LightBlue;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label.Text = "";
        }
    }
}
