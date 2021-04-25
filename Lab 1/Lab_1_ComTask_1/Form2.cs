using System;
using System.Windows.Forms;

namespace Lab_1_ComTask_1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonOpenForm3_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show(this);
        }
    }
}
