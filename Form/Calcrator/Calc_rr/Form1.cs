using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc
{
    public partial class FormCalc : Form
    {
        private CalcClass c;
        private bool 첫숫자냐;

        public FormCalc()
        {
            InitializeComponent();
            c = new CalcClass();
            첫숫자냐 = true;
        }

        private void FormCalc_Load(object sender, EventArgs e)
        {
            
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
            string msg = labelContent.Text + "" + b.Text;
            string r = c.calc(labelContent.Text, b.Text);
            labelContent.Text = r;
            첫숫자냐 = true;
            toolStripStatusLabel1.Text = msg + ":" + r;
        }

        private void 끝내기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
