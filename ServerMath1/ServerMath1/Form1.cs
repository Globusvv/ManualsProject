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

namespace ServerMath1
{
    public partial class Server : Form
    {

        public Server()
        {
            Task.Factory.StartNew(Console);
            InitializeComponent();
            
        }

        private void Console()
        {
            
            // Запускаем консоль.
            if (AllocConsole())
            {
                FreeConsole();
                    int port = 10000; // порт для приема входящих запросов
                    // получаем адреса для запуска сокета
                    IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), port);

                    // создаем сокет
                    Socket listenSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    try
                    {
                        // связываем сокет с локальной точкой, по которой будем принимать данные
                        listenSocket.Bind(ipPoint);
                    //Recieve("hi");
                        // начинаем прослушивание
                        listenSocket.Listen(10);

                    System.Console.WriteLine("Сервер запущен. Ожидание подключений...");

                        while (true)
                        {
                            Socket handler = listenSocket.Accept();
                            // получаем сообщение
                            StringBuilder builder = new StringBuilder();
                            int bytes = 0; // количество полученных байтов
                            byte[] data = new byte[256]; // буфер для получаемых данных

                            do
                            {
                                bytes = handler.Receive(data);
                                builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                            }
                            while (handler.Available > 0);
                        Recieve(builder.ToString());
                        System.Console.WriteLine(DateTime.Now.ToShortTimeString() + ": " + builder.ToString());

                        
                            // отправляем ответ
                            string message = "ваше сообщение доставлено";
                            data = Encoding.Unicode.GetBytes(message);
                            handler.Send(data);
                            // закрываем сокет
                            handler.Shutdown(SocketShutdown.Both);
                            handler.Close();
                        }
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





        public void Recieve(string str)
        {


            MessageBox.Show(str);
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


                //  Process.Start(FLdName.Text);
            }
        }

    }
}
