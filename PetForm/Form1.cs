using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetForm
{
    public partial class Form1 : Form
    {
        private IManagement m;
        public Form1()
        {
            InitializeComponent();
            m = new Management();
            m.Add(new Dog("멍멍", 3, "하양색"));
            ShowList(); 
        }

        private void Clear() {
            tName.Text = "";
            tAge.Text = "";
            tBreeds.Text = "";
        }
        private void ShowList() {
            listBox.Items.Clear();
            foreach (var item in m.ToList())
            {
                listBox.Items.Add(item);
            }
        }
        private void SetText(Pet p)
        {
            tName.Text = p.Name;
            tAge.Text = p.Age.ToString();
            if(p is Dog)tBreeds.Text = "" + ((Dog)p).Breeds;
            if(p is Cat) tBreeds.Text = "" + ((Cat)p).Breeds;
        }

        private void bCle_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void bSel_Click(object sender, EventArgs e)
        {
            //string name = tName.Text;
            //Person p = m.Search(name);
            Pet p = m.Search(tName.Text);
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
            string breeds = tBreeds.Text;
            m.Updata(new Dog(name,age,breeds));
            Clear();
            ShowList();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            m.Add(new Dog(tName.Text, int.Parse(tAge.Text), tBreeds.Text));
            Clear();
            ShowList();
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Pet p = (Pet)listBox.SelectedItem;
            SetText(p);
        }
    }
}
