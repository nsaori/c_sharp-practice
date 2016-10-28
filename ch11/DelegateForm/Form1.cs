//p.498

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //create a button
            Button b = new Button();
            b.Text = "버튼";

            //1.method
            b.Click += MsgShow;

            //2. delegate
            b.Click += delegate(object sender,EventArgs args) {
                MessageBox.Show("무명 델리게이터를 사용한 이벤트 연결입니다. ");
            };

            //3.Landa
            b.Click +=  (sender, args) => {  MessageBox.Show("람다를 사용한 이벤트 연결입니다."); };

            //버튼 화면에 추가
            Controls.Add(b);
        }
        //1-2.method
        private void MsgShow(object sender, EventArgs args)
        {
            MessageBox.Show("메소드를 사용한 이벤트 연결입니다. ");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "텍스트 파일(*.txt) | *.txt";
            saveFileDialog1.ShowDialog();
            // MessageBox.Show(saveFileDialog1.FileName);
            File.WriteAllText(saveFileDialog1.FileName, textBox1.Text); //textbox에 있는 글자를 파일에 저장한다
        }
    }
}
