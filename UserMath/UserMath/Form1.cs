using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace UserMath
{
    public partial class User : Form
    {
        public User()
        {
            InitializeComponent();
        }

        private void Lessons_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void User_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Lessons.Items.Add(1);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Lessons.SelectedIndex != -1)
                Lessons.Items.RemoveAt(Lessons.SelectedIndex);
        }

        private void PasswordText_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void FLdButton_Click(object sender, EventArgs e)
        {
            DialogResult res;

            using (FolderBrowserDialog FLdChooser = new FolderBrowserDialog())
            {
                FLdChooser.SelectedPath = FLdName.Text;

                res = FLdChooser.ShowDialog();

                FLdName.Text = FLdChooser.SelectedPath;
            
                if (res == DialogResult.OK)
                {
                    Lessons.Items.Clear();

                    Lessons.Items.AddRange(Directory.GetFiles(FLdName.Text));

                }
            }
        }

        private void Lessons_DoubleClick(object sender, EventArgs e)
        {
            if (Lessons.SelectedIndex != -1)
            {
                FLdName.Text = Lessons.SelectedItem.ToString();
                Process.Start(FLdName.Text);
            }

        }
    }
}
