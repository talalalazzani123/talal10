using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace واجب_10_برمجة_مرئية
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        Form11 f1;

        private void إضافةطالبToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(f1==null||f1.IsDisposed)
            {
                f1= new Form11();
                f1.Show();
            }
            else
            {
                f1.Focus();
            }
        }
        Form22 f2;
        private void عرضالطلابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new Form22();
                f2.Show();
            }
            else
            {
                f2.Focus();
            }

        }

        private void إغلاقToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if (count > 1)
            {
                Application.OpenForms[count - 1].Close();
            }
        }

        private void إغلاقالكلToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int count = Application.OpenForms.Count;
            if (count > 1)
            {
                for(int i=count-1;i>=1; i--) 
                   Application.OpenForms[i].Close();
            }
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
