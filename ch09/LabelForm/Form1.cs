using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabelForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.naver.com");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> list = new List<string>();
                foreach (var item in Controls)
            {
                if(item is CheckBox)
                {
                    CheckBox cb = (CheckBox)item;
                    if(cb.Checked)
                    {
                        list.Add(cb.Text);
                    }
                }
            }
            MessageBox.Show(string.Join(",",list));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var item in Controls)
            {
                if (item is GroupBox)
                {
                    foreach (var it in ((GroupBox)item).Controls)
                    {
                        if (item is RadioButton)
                        {
                            RadioButton rb = (RadioButton)item;
                            if (rb.Checked)
                            {
                                MessageBox.Show(rb.Text);
                            }
                        }
                    }
                }
            }
        }
    }
}
