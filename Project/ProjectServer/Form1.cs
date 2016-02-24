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

namespace ProjectServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Listener();
        }



        private void Listener()
        {
            {
                IPHostEntry ipHost = Dns.GetHostEntry("localhost");
                IPAddress ipAddr = ipHost.AddressList[0];
                IPEndPoint ipEndPoint = new IPEndPoint(ipAddr, 11000);
                // Создаем сокет Tcp/Ip
                Socket sListener = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                // Устанавливаем для сокета локальную конечную точку
                // Назначаем сокет локальной конечной точке и слушаем входящие сокеты
                try
                {
                    sListener.Bind(ipEndPoint);
                    sListener.Listen(10);

                    // Начинаем слушать соединения
                    while (true)
                    {
                        textBox1.Text += String.Format("Ожидаем соединение через порт {0}", ipEndPoint);
                        textBox1.Update();
                        // Программа приостанавливается, ожидая входящее соединение
                        Socket handler = sListener.Accept();
                        string data = null;

                        // Мы дождались клиента, пытающегося с нами соединиться

                        byte[] bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);

                        data += Encoding.UTF8.GetString(bytes, 0, bytesRec);

                        // Показываем данные на консоли
                        textBox1.Text += String.Format("Полученный текст: " + data + "\n\n");
                        textBox1.Update();
                        // Отправляем ответ клиенту\
                        string reply = "Спасибо за запрос в " + data.Length.ToString()
                                + " символов";
                        textBox1.Update();
                        byte[] msg = Encoding.UTF8.GetBytes(reply);
                        handler.Send(msg);

                        if (data.IndexOf("<TheEnd>") > -1)
                        {
                            textBox1.Update();
                            textBox1.Text += String.Format("Сервер завершил соединение с клиентом.");
                            break;
                        }

                        handler.Shutdown(SocketShutdown.Both);
                        handler.Close();
                    }
                }
                catch (Exception ex)
                {
                    textBox1.Text += String.Format(ex.ToString());
                }
                finally
                {

                }

            }


        }


        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
