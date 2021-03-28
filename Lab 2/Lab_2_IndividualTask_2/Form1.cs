using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_2_IndividualTask_2
{
    public partial class Form1 : Form
    {
        private EventHandler superMegaAction;
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
            superMegaAction?.Invoke(sender, e);
        }

        private void checkBoxTrasparency_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrasparency.Checked)
            {
                superMegaAction += buttonTransparency_Click;
            }
            else
            {
                superMegaAction -= buttonTransparency_Click;
            }
        }

        private void checkBoxBackground_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBackground.Checked)
            {
                superMegaAction += buttonBackground_Click;
            }
            else
            {
                superMegaAction -= buttonBackground_Click;
            }
        }

        private void checkBoxHello_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHello.Checked)
            {
                superMegaAction += buttonHello_Click;
            }
            else
            {
                superMegaAction -= buttonHello_Click;
            }
        }
    }
}
