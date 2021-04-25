using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_1_ComTask_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Color color = Color.Green;

            if (panel.BackColor != color)
            {
                panel.BackColor = color;
                panel.Invalidate();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorListBox.SelectedIndex = 0;
        }

        private void panel_MouseMove(object sender, MouseEventArgs e)
        {
            Color color;
            switch (colorListBox.SelectedItem)
            {
                case "Red":
                    color = Color.Red;
                    break;

                case "Yellow":
                    color = Color.Yellow;
                    break;

                case "Blue":
                    color = Color.Blue;
                    break;

                default:
                    throw new Exception("Bad selected item");
            }

            if (panel.BackColor != color)
            {
                panel.BackColor = color;
                panel.Invalidate();
            }
        }
    }
}
