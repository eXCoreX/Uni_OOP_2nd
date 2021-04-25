using System;
using System.Windows.Forms;

namespace Lab_1_ComTask_1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void buttonClose2And3_Click(object sender, EventArgs e)
        {
            Owner.Close();
        }
    }
}
