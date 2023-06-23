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
    public partial class task6 : Form
    {
        public task6()
        {
            InitializeComponent();
        }
        string a, b;
        private void btn1_Click(object sender, EventArgs e)
        {
            a = txt1.Text;
            frequency();
        }
        public void frequency()
        {
            Dictionary<char, int> d = new Dictionary<char, int>();
            foreach (char c in a)
            {
                if (d.ContainsKey(c))
                {
                    d[c]++;
                }
                else
                {
                    d[c] = 1;
                }
            }

            foreach (char c in a)
            {
                if (d[c] != 0)
                {
                    b = (c + d[c].ToString() + " ");
                    lb1.Items.Add(b);
                    d[c] = 0;
                }
            }
        }
    }
}
