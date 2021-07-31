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
        private bool signIsPressed = false;
        private string value;
        public Form1()
        {
            InitializeComponent();
            /*string math = "5.5+67-5";
            Expression e = new Expression(math);
            Console.WriteLine(e.calculate());*/
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
            if (resultLbl.Text == "NaN")
            {
                resultLbl.Text = "0";
            }
            Guna2TileButton b = sender as Guna2TileButton;

            if ((resultLbl.Text == "0"))
                resultLbl.Text = String.Empty;


            resultLbl.Text = resultLbl.Text + b.Text;



        }

        private void signs_Click(object sender, EventArgs e)
        {
            value = resultLbl.Text;

            Guna2TileButton btnSign = (Guna2TileButton)sender;
            if (resultLbl.Text.Substring(resultLbl.Text.Length - 1) == "+")
            {
                resultLbl.Text = value;
            }
            else if (resultLbl.Text.Substring(resultLbl.Text.Length - 1) == "-")
            {
                resultLbl.Text = value;

            }
            else if (resultLbl.Text.Substring(resultLbl.Text.Length - 1) == "*")
            {
                resultLbl.Text = value;
            }
            else if (resultLbl.Text.Substring(resultLbl.Text.Length - 1) == "/")
            {
                resultLbl.Text = value;
            }
            else if (resultLbl.Text == "0")
            {
                resultLbl.Text = value;
            }
            else
            {
                resultLbl.Text = resultLbl.Text + btnSign.Text;
            }
        }

        private void ceBtn_Click(object sender, EventArgs e)
        {
            resultLbl.Text = resultLbl.Text.Length > 1 ? resultLbl.Text.Remove(resultLbl.Text.Length - 1) : "0";
        }

        private void equalBtn_Click(object sender, EventArgs e)
        {
            /* DataTable dt = new DataTable();
             var v = dt.Compute(resultLbl.Text, "");
 
             string answer = v.ToString();
             answer = answer.Replace(',', '.');
 
             if (answer.Contains(".0"))
             {
                 answer = answer.TrimEnd('0');
 
                 if (answer.EndsWith("."))
                     answer = answer.TrimEnd('.');
             }
 
             resultLbl.Text = answer;*/

            Expression exp = new Expression(resultLbl.Text);
            resultLbl.Text = exp.calculate().ToString();
        }

        private void allClrBtn_Click(object sender, EventArgs e)
        {
            resultLbl.Text = "0";
        }
    }
}
