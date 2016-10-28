using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBindForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //productBindingSource.Add(new Product() {Name = "감자",Price = 500 });
            productBindingSource.Add(new Product("감자",500));
            productBindingSource.Add(new Product() { Name = "사과", Price = 700 });
            productBindingSource.Add(new Product() { Name = "고구마", Price = 400 });
            productBindingSource.Add(new Product() { Name = "배추", Price = 600 });
            productBindingSource.Add(new Product() { Name = "피만", Price = 200 });
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) //comboBox doubleClick
        {
            ComboBox cb = (ComboBox)sender;
            MessageBox.Show(cb.SelectedItem.ToString());
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListBox lb = (ListBox)sender;
            //Object o = lb.SelectedItem;
            //Product p = (Product)o;
            Product p = (Product)lb.SelectedItem;
            MessageBox.Show(""+ p.Price,p.Name);
        }
    }
}
