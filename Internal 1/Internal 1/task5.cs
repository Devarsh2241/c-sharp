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
    public partial class task5 : Form
    {
        public task5()
        {
            InitializeComponent();
        }
        string str1, str2, st;
        private void btn1_Click(object sender, EventArgs e)
        {
            str1 = txt1.Text;

            for(int i = str1.Length - 1; i >= 0; i--)
            {
                str2 += str1[i];
                
            }
            foreach(char c in str2)
            {
                if(c == 'a')
                {
                    st += 'e';
                }
                else if(c == 'e')
                {
                    st+= "i";
                }
                else if (c == 'i')
                {
                    st += "o";
                }
                else if (c == 'o')
                {
                    st += "u";
                }
                else if (c == 'u')
                {
                    st += "a";
                }
                else if (c == 'A')
                {
                    st += "E";
                }
                else if (c == 'E')
                {
                    st += "I";

                }
                else if (c == 'I')
                {
                    st += "O";
                }
                else if (c == 'O')
                {
                    st += "U";
                }
                else if (c == 'U')
                {
                    st += "A";
                }
                else 
                {
                    st += c;
                }
            }
            lbl1.Text = st;





        }

    }
}
