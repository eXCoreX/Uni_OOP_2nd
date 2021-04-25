using System;
using System.Windows.Forms;

namespace Lab_1_ComTask_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDeleteLabels_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Controls.Count;)
            {
                var comp = Controls[i];
                if (comp is Label)
                {
                    Controls.Remove(comp);
                }
                else
                {
                    ++i;
                }
            }
        }
    }
}
