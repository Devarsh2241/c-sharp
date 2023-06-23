using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Internal_1
{
    public partial class task2 : Form
    {
        public task2()
        {
            InitializeComponent();
        }
        string str2, str_1;
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string str = txt1.Text;
            str = Regex.Replace(str, "[a - zA - Z0 - 9]", "");
            str_1 = str;

            for (int i = str.Length - 1; i >= 0; i--)
            {
                str2 += str[i].ToString();

            }
            if (str2 == str_1)
            {
                MessageBox.Show("String is Pallindrome");
            }
            else
            {
                MessageBox.Show("String is not Pallindrome");
            }
        }

       
    }
}
