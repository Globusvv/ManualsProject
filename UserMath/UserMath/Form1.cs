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
using System.Net.Sockets;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Net;

namespace UserMath
{
    public partial class User : Form
    {
        public byte[] data;
        public User()
        {
            InitializeComponent();
            Lessons.Items.Add("SOmeString");
        }

        private void Console()
        {

            // Запускаем консоль.
           // if (AllocConsole())
            {
                FreeConsole();

                // адрес и порт сервера, к которому будем подключаться
                int port = 10000; // порт сервера
                string address = "127.0.0.1"; // адрес сервера

                try
                {
                    IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse(address), port);

                    Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    // подключаемся к удаленному хосту
                    socket.Connect(ipPoint);
                                       
                    socket.Send(data);

                    // получаем ответ
                    data = new byte[256]; // буфер для ответа
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0; // количество полученных байт

                    do
                    {
                        bytes = socket.Receive(data, data.Length, 0);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (socket.Available > 0);
                    System.Console.WriteLine("ответ сервера: " + builder.ToString());

                    // закрываем сокет
                    socket.Shutdown(SocketShutdown.Both);
                    socket.Close();
                }
                catch (Exception ex)
                {
                    System.Console.WriteLine(ex.Message);
                }
               
            }

        }
        

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool AllocConsole();

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool FreeConsole();

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
                //Process.Start(FLdName.Text);
             
                   data = Encoding.Unicode.GetBytes(FLdName.Text.ToString()); 
                Task.Factory.StartNew(Console);
            }

        }
    }
}
