using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal_1
{
    public partial class task1 : Form
    {
        public task1()
        {
            InitializeComponent();
        }
        string total, option;
        float num1, num2,result;
        private void btnclear_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + 1;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + 2;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + 3;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + 4;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + 5;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + 6;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + 7;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + 8;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + 9;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txt1.Text = txt1.Text + 0;
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = float.Parse(txt1.Text);
            txt1.Clear();
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = float.Parse(txt1.Text);
            txt1.Clear();
        }

        private void btnmul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = float.Parse(txt1.Text);
            txt1.Clear();
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = float.Parse(txt1.Text);
            txt1.Clear();
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            num2=float.Parse(txt1.Text);
            if(option == "+")
            {
                result = num1 + num2;
            }
            else if(option == "-")
            {
                result = num1 - num2;   
            }
            else if (option == "*") 
            { 
                result = num1 * num2;
            }
            else if(option == "/")
            {
                result = num1 / num2;   
            }
            txt1.Text = result.ToString();  
        }
    }
}
