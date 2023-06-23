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
    public partial class task7 : Form
    {
        public task7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            lblbinary.Text = Convert.ToString(a, 2);
            lbldesimal.Text = Convert.ToString(a);
            lbloctal.Text = Convert.ToString(a, 8);
            lblhexadesimal.Text = Convert.ToString(a, 16);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lblbinary.Text = "";
            lbldesimal.Text = "";
            lblhexadesimal.Text = "";
            lbloctal.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Dispose();
        }
    }
}
