using System;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void minBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
