using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1_ComTask_4
{
    public partial class Form1 : Form
    {
        private int labelCount = 0;
        private Font labelFont;
        private int lastLabelY = 0;
        public Form1()
        {
            InitializeComponent();
            labelFont = new Font("Arial Semibold", 10, FontStyle.Italic);

        }

        private void buttonAddLabel_Click(object sender, EventArgs e)
        {
            Label newLabel = new Label();
            newLabel.Text = "Label " + (++labelCount);
            newLabel.Font = labelFont;
            newLabel.Location = new Point(10, lastLabelY + 20);
            lastLabelY += 20;
            newLabel.MouseClick += label_Click;
            newLabel.AutoSize = true;
            Controls.Add(newLabel);
        }

        private void label_Click(object sender, MouseEventArgs e)
        {
            Label senderLabel = sender as Label;
            int num = int.Parse(senderLabel.Text.Split()[1]);
            labelSelectedLabel.Text = "Selected Label: " + num;
        }
    }
}
