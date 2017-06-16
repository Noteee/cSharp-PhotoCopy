using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace PhotoCopy
{
    public partial class Form1 : Form
    {
        List<string> checkedList = new List<string>();
        Paths paths = new Paths();

        public Form1()
        {
            InitializeComponent();
        }

        private void checkedBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox1.Image = Image.FromFile(checkedListBox1.SelectedItem.ToString());
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            FormBorderStyle = FormBorderStyle.Sizable;
            WindowState = FormWindowState.Normal;
            
            if (Directory.Exists(paths.getSourcePath()))
            {
                var allFileArray = Directory.GetFiles(paths.getSourcePath());
                foreach (var file in allFileArray)
                {
                    checkedListBox1.Items.Add(file);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkedList.Clear();
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                checkedList.Add(itemChecked.ToString());
            }

            foreach (var checkedFile in checkedList)
            {
                var token = checkedFile.Split('\\');
                File.Copy(checkedFile, paths.getdestinationPath1()+ '\\' + token.Last(), true);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkedList.Clear();
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                checkedList.Add(itemChecked.ToString());
            }

            foreach (var checkedFile in checkedList)
            {
                var token = checkedFile.Split('\\');
                File.Copy(checkedFile, paths.getdestinationPath2() + '\\' + token.Last(), true);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkedList.Clear();
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                checkedList.Add(itemChecked.ToString());
            }

            foreach (var checkedFile in checkedList)
            {
                var token = checkedFile.Split('\\');
                File.Copy(checkedFile, paths.getdestinationPath3() + '\\' + token.Last(), true);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkedList.Clear();
            foreach (object itemChecked in checkedListBox1.CheckedItems)
            {
                checkedList.Add(itemChecked.ToString());
            }

            foreach (var checkedFile in checkedList)
            {
                var token = checkedFile.Split('\\');
                File.Copy(checkedFile, paths.getdestinationPath4() + '\\' + token.Last(), true);
            }
        }
    }
}