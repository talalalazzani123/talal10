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
    public partial class Form3 : Form
    {
        int index;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            LoadStudentData();
        }
        void LoadStudentData()
        {
            index = Form22.index;
            numericUpDown1.Value = Convert.ToDecimal(Form11.s[index].GetNumber());
            textBox1.Text = Form11.s[index].GetName();
            dateTimePicker1.Text = Form11.s[index].GetBrithdate();
            pictureBox1.Image = Image.FromFile(Form11.s[index].GetIMAPgth());

            
        }
        private bool inUpdateImage=false;

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form11.s[index].SetName(textBox1.Text);
            Form11.s[index].SetNumber(Convert.ToInt32(numericUpDown1.Value));
            Form11.s[index].SetBithdate(dateTimePicker1.Text);
            if(inUpdateImage)
            {
                Form11.s[index].SetImagePath(openFileDialog1.FileName);

            }
            Close();

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "img(*.jpg)|*.jpg|(img*.bmp;*.png)|*.bmp;*.png";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                inUpdateImage = true;
                pictureBox1.Image=Image.FromFile(openFileDialog1.FileName);
            }
        }
    }
}
