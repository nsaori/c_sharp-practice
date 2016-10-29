using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentForm
{
    public partial class Form1 : Form
    {
        private IManagement m;
        public Form1()
        {
            InitializeComponent();
            m = new Management();
            m.Add(new Student("홍길동", 20, 201601));
            ShowList(); 
        }

        private void Clear() {
            tName.Text = "";
            tAge.Text = "";
            tStid.Text = "";
        }
        private void ShowList() {
            listBox.Items.Clear();
            foreach (var item in m.ToList())
            {
                listBox.Items.Add(item);
            }
        }
        private void SetText(Person p)
        {
            tName.Text = p.Name;
            tAge.Text = p.Age.ToString();
            tStid.Text = "" + ((Student)p).Stuid;
        }

        private void bCle_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bSel_Click(object sender, EventArgs e)
        {
            //string name = tName.Text;
            //Person p = m.Search(name);
            Person p = m.Search(tName.Text);
            SetText(p);
        }

        private void bDel_Click(object sender, EventArgs e)
        {
            m.Remove(tName.Text);
            Clear();
            ShowList();
        }

        private void bUd_Click(object sender, EventArgs e)
        {
            string name =tName.Text;
            int age = int.Parse(tAge.Text);
            int stuid = int.Parse(tStid.Text);
            m.Updata(new Student(name,age,stuid));
            Clear();
            ShowList();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            m.Add(new Student(tName.Text, int.Parse(tAge.Text), int.Parse(tStid.Text)));
            Clear();
            ShowList();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Person p = (Person)listBox.SelectedItem;
            SetText(p);
        }
    }
}
