//20161025 p.360 상속

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MessageBox
{
    public partial class Form1 : Form
    {
        class CustomForm : Form
        {
            //CustomForm(){ }
        }
        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;  //form 안쪽에 form
            Controls.Add(new Button());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CustomForm form = new CustomForm();
            //form.MdiParent = this;  //애가 없으면 모달, 생긴게 form 닫거나 밖에 가야지 새론거 생성가능한다
            form.Show();
        }
    }
}
