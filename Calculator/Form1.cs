using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Guna.UI2.WinForms;
using org.mariuszgromada.math.mxparser;


namespace Calculator
{
    public partial class Form1 : Form
    {
        private string value;
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

        private void btns_Click(object sender, EventArgs e)
        {
            value = resultLbl.Text;
            Guna2TileButton b = sender as Guna2TileButton;
            if (resultLbl.Text == "NaN")
            {
                resultLbl.Text = "0";
            }

            if (resultLbl.Text == "0")
                resultLbl.Text = String.Empty;

            resultLbl.Text = resultLbl.Text + b.Text;

        }

        private void signs_Click(object sender, EventArgs e)
        {
            value = resultLbl.Text;

            Guna2TileButton btnSign = (Guna2TileButton)sender;
            if (resultLbl.Text.EndsWith("+"))
            {
                resultLbl.Text = value;
            }
            else if (resultLbl.Text.EndsWith("-"))
            {
                resultLbl.Text = value;

            }
            else if (resultLbl.Text.EndsWith("*"))
            {
                resultLbl.Text = value;
            }
            else if (resultLbl.Text.EndsWith("/"))
            {
                resultLbl.Text = value;
            }
            else if (resultLbl.Text.EndsWith("."))
            {
                resultLbl.Text = value;
            }
            else
            {
                resultLbl.Text += btnSign.Text;
            }
        }

        private void ceBtn_Click(object sender, EventArgs e)
        {
            resultLbl.Text = resultLbl.Text.Length > 1 ? resultLbl.Text.Remove(resultLbl.Text.Length - 1) : "0";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            Expression exp = new Expression(resultLbl.Text);
            resultLbl.Text = exp.calculate().ToString();
        }

        private void allClrBtn_Click(object sender, EventArgs e)
        {
            resultLbl.Text = "0";
        }
    }
}
