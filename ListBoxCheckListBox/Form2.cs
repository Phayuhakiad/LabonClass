using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxCheckListBox
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            string[] products = { "สมุด", "ดินสอ", "ปากกา", "ยางลบ", "ไม้บรรทัด", "วงเวียน" };
            listBox1.Items.AddRange(products);
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            int idx = listBox1.SelectedIndex;
            listBox1.DoDragDrop(listBox1.Items[idx], DragDropEffects.Copy);
        }

        private void listBox2_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void listBox2_DragDrop(object sender, DragEventArgs e)
        {
            string data = e.Data.GetData(DataFormats.Text).ToString();
            if (listBox2.FindStringExact(data)== -1)
            {
                listBox2.Items.Add(data);
            }
        }
    }
}
