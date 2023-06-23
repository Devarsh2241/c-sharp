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
    public partial class task8 : Form
    {
        public task8()
        {
            InitializeComponent();
        }

        private void btnconvert_Click(object sender, EventArgs e)
        {
            string str = txt1.Text;
            string result = "";
            foreach (char c in str)
            {
                if (c == 'a')
                {
                    result += 'e';
                }
                else if (c == 'e')
                {
                    result += 'i';
                }
                else if (c == 'i')
                {
                    result += 'o';
                }
                else if (c == 'o')
                {
                    result += 'u';
                }
                else if (c == 'u')
                {
                    result += 'a';
                }

                else if (c == 'A')
                {
                    result += 'E';
                }
                else if (c == 'E')
                {
                    result += 'I';
                }
                else if (c == 'I')
                {
                    result += 'O';
                }
                else if (c == 'O')
                {
                    result += 'U';
                }
                else if (c == 'U')
                {
                    result += 'A';
                }
                else
                {
                    result += c;
                }


            }
            lblresult.Text = result;

        }
    }
}
