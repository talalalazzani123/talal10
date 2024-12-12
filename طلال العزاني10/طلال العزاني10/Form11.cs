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
    public partial class Form11 : Form
    {
        public static student[] s = new student[100];
        public static int count = 0;
        public Form11()
        {
            InitializeComponent();
        }
        bool isChoseImage = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (count < 100)
            {
                if(isChoseImage)
                {
                    
                s[count] = new student();
                s[count].SetNumber(Convert.ToInt32(numericUpDown1.Value));
                s[count].SetName(Convert.ToString(textBox1.Text));
                s[count].SetBithdate(dateTimePicker1.Text);
                s[count].SetImagePath(openFileDialog1.FileName);
                count++;
                isChoseImage = false;
                pictureBox1.Image = null;
                textBox1.Text = "";
                MessageBox.Show("اتم إضافة الطالب بنجاح", "نجاح");

                }
                else
                    MessageBox.Show("الرجاء إختيار صورة الطالب", "تحذير");


            }
            else
                MessageBox.Show("الحد المسموح به مائة طالب فقط", "تحذير");
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            openFileDialog1.Filter = "img(*.jpg)|*.jpg|(img*.bmp;*.png)|*.bmp;*.png";
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                pictureBox1.Image=Image.FromFile(openFileDialog1.FileName);
                isChoseImage = true;
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {

        }
    }
}
