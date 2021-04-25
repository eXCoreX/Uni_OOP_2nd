using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_2_IndividualTask_2
{
    public partial class Form1 : Form
    {
        private bool isTrasparent = false;
        private bool isBackgroundGray = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTransparency_Click(object sender, EventArgs e)
        {
            if (isTrasparent)
            {
                Opacity = 1.00;
            }
            else
            {
                Opacity = 0.8;
            }
            isTrasparent = !isTrasparent;
        }

        private void buttonBackground_Click(object sender, EventArgs e)
        {
            if (isBackgroundGray)
            {
                BackColor = Color.Yellow;
            }
            else
            {
                BackColor = Color.Gray;
            }
            isBackgroundGray = !isBackgroundGray;
        }

        private void buttonHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello Home.\n" +
                            "World заблокований з міркувань карантину");
        }

        private void buttonSuperMega_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я супермегакнопка,\n" +
                            "і цього мене не позбавиш!");
        }

        private void checkBoxTrasparency_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrasparency.Checked)
            {
                buttonSuperMega.Click += buttonTransparency_Click;
            }
            else
            {
                buttonSuperMega.Click -= buttonTransparency_Click;
            }
        }

        private void checkBoxBackground_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBackground.Checked)
            {
                buttonSuperMega.Click += buttonBackground_Click;
            }
            else
            {
                buttonSuperMega.Click -= buttonBackground_Click;
            }
        }

        private void checkBoxHello_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHello.Checked)
            {
                buttonSuperMega.Click += buttonHello_Click;
            }
            else
            {
                buttonSuperMega.Click -= buttonHello_Click;
            }
        }
    }
}
