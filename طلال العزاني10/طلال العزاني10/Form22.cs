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
    public partial class Form22 : Form
    {
        public Form22()
        {
            InitializeComponent();
        }
        void LoadStudentData()
        {
            for(int i=0;i<Form11.count;i++)
            {
                listBox1.Items.Add(Form11.s[i].GetNumber().ToString());
                listBox2.Items.Add(Form11.s[i].GetName().ToString());
                listBox3.Items.Add(Form11.s[i].GetBrithdate().ToString());

                pictureBox1.Image = Image.FromFile(Form11.s[i].GetIMAPgth());
                listBox1.SelectedIndex=listBox2.SelectedIndex=listBox3.SelectedIndex=0;
            }
        }

        private void Form22_Load(object sender, EventArgs e)
        {
            LoadStudentData();
            ///////////////////////
            listBox1.SelectedIndexChanged += findSelectedIndexList;
            listBox2.SelectedIndexChanged += findSelectedIndexList;
            listBox3.SelectedIndexChanged += findSelectedIndexList;
        }
        public static int index = -1;
        void findSelectedIndexList(object sender, EventArgs e)
        {
            if (((ListBox)sender).SelectedIndex != -1)
            {
                index = listBox3.SelectedIndex = listBox2.SelectedIndex = listBox1.SelectedIndex=((ListBox)sender).SelectedIndex;
                pictureBox1.Image = Image.FromFile(Form11.s[index].GetIMAPgth());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem!= null)
            {
                listBox1.Items.Remove(listBox1.SelectedItem);
                listBox2.Items.Remove(listBox1.SelectedItem);
                listBox3.Items.Remove(listBox1.SelectedItem);
                /////////////////////
                for(int i=index;i<Form11.count;i++)
                {
                    Form11.s[i] = Form11.s[i + 1];
                }
                Form11.count--;
                ///////////////////////
                if (Form11.count >= 1)
                {
                    pictureBox1.Image = Image.FromFile(Form11.s[0].GetIMAPgth());
                    listBox1.SelectedIndex = listBox2.SelectedIndex = listBox3.SelectedIndex = index-1;

                }
                else
                    pictureBox1.Image = null;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(listBox1.SelectedItem!=null)
            {
                Form3 f= new Form3();
                f.ShowDialog();
                listBox1.Items[index] = Form11.s[index].GetNumber();
                listBox2.Items[index] = Form11.s[index].GetName();
                listBox3.Items[index] = Form11.s[index].GetBrithdate();
                pictureBox1.Image = Image.FromFile(Form11.s[index].GetIMAPgth());


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox3.Items.Clear();
            LoadStudentData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
