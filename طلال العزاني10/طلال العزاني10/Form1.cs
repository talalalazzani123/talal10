using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace واجب_10_برمجة_مرئية
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text = fileListBox1.Path + "\\" + fileListBox1.FileName;
            label5.Text = Path.GetFileName(label4.Text);
            label6.Text = Path.GetExtension(label4.Text);

            if (label6.Text.Trim().ToLower() == ".txt")
            {
                richTextBox1.Text = File.ReadAllText(label4.Text);

            }
            else if (label6.Text.Trim().ToLower() == ".png" || label6.Text.ToLower() == ".jpg" || label6.Text.ToLower() == ".jpeg")
            {
                pictureBox1.Image=Image.FromFile(label4.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.Items.Add("*.png");
            comboBox1.Items.Add("*.jpg");
            comboBox1.Items.Add("*.jprg");
            comboBox1.Items.Add("*.txt");
            comboBox1.SelectedIndex = 1;
        }

        private void driveListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dirListBox1.Path = driveListBox1.Drive;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Pattern = comboBox1.Text.Trim();
        }

        private void dirListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fileListBox1.Path= dirListBox1.Path;
        }
    }
}
