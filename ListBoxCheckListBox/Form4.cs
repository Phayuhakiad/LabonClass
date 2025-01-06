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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode <= Keys.D0)||(e.KeyCode >= Keys.D9))
            {
                e.SuppressKeyPress = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar))
            { 
                e.Handled = true;
                MessageBox.Show("โปรดกรอกเฉพาะตัวเลข");
            }
        }

        private void Form4_MouseMove(object sender, MouseEventArgs e)
        {
            int PosX = e.X;
            int PosY = e.Y;
            this.Text = "ตำแหน่งของ Mouse Pointer" + " X = " + PosX.ToString() + " Y = " + PosY.ToString(); 
        }
    }
}
