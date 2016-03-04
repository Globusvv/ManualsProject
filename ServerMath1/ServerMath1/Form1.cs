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

namespace ServerMath1
{
    public partial class Server : Form
    {
        public Server()
        {
            InitializeComponent();
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

        private void Remove_Click(object sender, EventArgs e)
        {
            if (Lessons.SelectedIndex != -1)
                Lessons.Items.RemoveAt(Lessons.SelectedIndex);
        }

        private void FLdButton1_Click(object sender, EventArgs e)
        {
            DialogResult res;

            using (FolderBrowserDialog FLdChooser = new FolderBrowserDialog())
            {
                FLdChooser.SelectedPath = FLdName1.Text;

                res = FLdChooser.ShowDialog();

                FLdName1.Text = FLdChooser.SelectedPath;

                if (res == DialogResult.OK)
                {
                    Tests.Items.Clear();

                    Tests.Items.AddRange(Directory.GetFiles(FLdName1.Text));

                }
            }
        }

        private void Remove1_Click(object sender, EventArgs e)
        {
            if (Tests.SelectedIndex != -1)
                Tests.Items.RemoveAt(Tests.SelectedIndex);
        }

        private void Tests_DoubleClick(object sender, EventArgs e)
        {
            if (Tests.SelectedIndex != -1)
            {
                FLdName.Text = Tests.SelectedItem.ToString();
                Process.Start(FLdName.Text);
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
