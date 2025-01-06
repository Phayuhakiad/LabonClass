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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            txtKeyCode.Text = e.KeyCode.ToString();
            txtKeyData.Text = e.KeyData.ToString();
            txtKeyValue.Text = e.KeyValue.ToString();
            chkAlt.Checked = e.Alt;
            chkControl.Checked = e.Control;
            chkShift.Checked = e.Shift;
        }
    }
}
