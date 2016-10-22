using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            button.Text = "코드에서 변경";
            button.Width = 100;

            for (int i = 1; i <= 5; i++)
            {
                Button b = new Button();        //create a button 
                Controls.Add(b);                //표시
                b.Location = new Point(12,12+(23+3)*(i));  //c#기본button 높이 23
                b.Text = "동적 생성"+i+"번지";
                b.Width = 100;
            }
        }

        //form에서 button를 클릭하면 생긴다
        private void button_Click(object sender, EventArgs e)   //event 발생
        {
            MessageBox.Show("하하하","호호호");
        }
    }
}
