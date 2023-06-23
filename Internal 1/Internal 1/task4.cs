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
    public partial class task4 : Form
    {
        char ch = 'O';
        public task4()
        {
            InitializeComponent();
        }

        private void button_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "")
            {
                btn.Text = (ch = (ch == 'O') ? 'X' : 'O').ToString();
               
                    docheck();
             
            }
            void docheck()
            {
                //horizontal
                if ((A1.Text == A2.Text) && (A2.Text == A3.Text))
                {
                        MessageBox.Show(A1.Text + " is winner ");
                        reset();
                    
                }
                else if ((A4.Text == A5.Text) && (A5.Text == A6.Text))
                {
                    if (!(A4.Text == ""))
                    {
                        MessageBox.Show(A4.Text + " is winner ");
                        reset();
                    }
                }
                else if ((A7.Text == A8.Text) && (A8.Text == A9.Text))
                {
                    if (!(A7.Text == ""))
                    {
                        MessageBox.Show(A7.Text + " is winner");
                        reset();
                    }
                }
               //vertical
                else if ((A1.Text == A4.Text) && (A4.Text == A7.Text))
                {
                    if (!(A1.Text == ""))
                    {
                        MessageBox.Show(A1.Text + " is winner ");
                        reset();
                    }
                }
                else if ((A2.Text == A5.Text) && (A5.Text == A8.Text))
                {
                    if (!(A2.Text == ""))
                    {
                        MessageBox.Show(A2.Text + " is winner");
                        reset();
                    }
                }
                else if ((A3.Text == A6.Text) && (A6.Text == A9.Text))
                {
                    if (!(A3.Text == ""))
                    {
                        MessageBox.Show(A3.Text + " is winner ");
                        reset();
                    }
                }
                //x 
                else if ((A1.Text == A5.Text) && (A5.Text == A9.Text))
                {
                    if (!(A1.Text == ""))
                    {
                        MessageBox.Show(A1.Text + " is winner");
                        reset();
                    }
                }
                else if ((A3.Text == A5.Text) && (A5.Text == A7.Text))
                {
                    if (!(A3.Text == ""))
                    {
                        MessageBox.Show(A3.Text + " is winner");
                        reset();
                    }
                }
               
            }
        }

        void reset()
        {
            A1.Text = "";
            A2.Text = "";
            A3.Text = "";
            A4.Text = "";
            A5.Text = "";
            A6.Text = "";
            A7.Text = "";
            A8.Text = "";
            A9.Text = "";
        }
        private void btnreset_Click(object sender, EventArgs e)
        {

             reset();

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
