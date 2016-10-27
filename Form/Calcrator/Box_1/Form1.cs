using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Box_1
{
    public partial class Form1 : Form
    {
        private CalcClass c; 
        
        private bool 첫숫자냐;
        public Form1()

        {
            InitializeComponent();
            c = new CalcClass();
            첫숫자냐 = true;

        }
        private void su_Click(object sender, EventArgs e)
        {
            
            Button b = (Button)sender;
            if (첫숫자냐)
            {
                labelContent.Text = b.Text;
                첫숫자냐 = false;
            }
            else
            {
                labelContent.Text += b.Text;
            }
            

        }

        private void op_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            string r = c.Box_1(labelContent.Text, b.Text);
            labelContent.Text = r;
            첫숫자냐 = true;
            toolStripStatusLabel1.Text =" : "+ r;
        }
    }
}
