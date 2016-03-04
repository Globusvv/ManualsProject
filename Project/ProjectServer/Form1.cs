using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace ProjectServer
{
    public partial class Form1 : Form
    {

        public IPHostEntry ipHost= new IPHostEntry();
        public IPAddress ipAddr;
        public IPEndPoint ipEndPoint;
        public Socket sListener;

        public Form1()
        {
            InitializeComponent();
             ipHost = Dns.GetHostEntry("localhost");
             ipAddr = ipHost.AddressList[0];
             ipEndPoint = new IPEndPoint(ipAddr, 10000);
            // Создаем сокет Tcp/Ip
             sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            sListener.Blocking = true;
            ListenTimer.Enabled = true;
            ListenTimer.Start();
                sListener.Bind(ipEndPoint);
                sListener.Listen(10);

        }



        private void Listener()
        {
            try
            {


                Logger.Text += String.Format("Ожидаем соединение через порт {0}", ipEndPoint);
                Logger.Update();
                // Программа приостанавливается, ожидая входящее соединение
                ListenTimer.Stop();
                Socket handler = sListener.Accept();
                string data = null;
                ListenTimer.Start();
                // Мы дождались клиента, пытающегося с нами соединиться
     
                byte[] bytes = new byte[1024];
                int bytesRec = handler.Receive(bytes);

                data += Encoding.UTF8.GetString(bytes, 0, bytesRec);

                // Показываем данные на консоли
                Logger.Text += String.Format("Полученный текст: " + data + "\n\n");
                Logger.Update();
                // Отправляем ответ клиенту\
                string reply = "Спасибо за запрос в " + data.Length.ToString()
                        + " символов";
                byte[] msg = Encoding.UTF8.GetBytes(reply);
                handler.Send(msg);

                if (data.IndexOf("<TheEnd>") > -1)
                {
                    Logger.Update();
                    Logger.Text += String.Format("Сервер завершил соединение с клиентом.");
                }

                handler.Shutdown(SocketShutdown.Both);
                handler.Close();

            }
            catch (Exception ex)
            {
                Logger.Text += String.Format(ex.ToString());
            }
         }



        private void Form1_Load(object sender, EventArgs e)
        {
       

        }

        private void ListenTimer_Tick(object sender, EventArgs e)
        {
      Listener();
        }

       
    }
}
