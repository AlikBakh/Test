using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Drawing;

namespace Server
{

    public partial class ServTCP : Form
    {
        public ServTCP()
        {
            InitializeComponent();

            listBox1.HorizontalScrollbar = true;

        }

        TcpListener server;// Высокоуровневая надстройка для прослушивающего сокета
        const int MAXNUMCLIENTS = 2;// Количество принимаемых подключений к серверу

        TcpClient[] clients = new TcpClient[MAXNUMCLIENTS];

        int countClient = 0;
        
        bool stopNetwork;

        #region Управление серверным приложением

        private void buttonStart_Click(object sender, EventArgs e)
        {
            StartServer();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Сервер:" + textBoxSend.Text);
            string s = "Сервер" + ": " + textBoxSend.Text;
            SendToClients(s,-1);
        }

        private void buttonStop_Click(object sender, EventArgs e)
        {
            StopServer();
            ErrorSound();
        }

        private void ServTCP_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopServer();
            ErrorSound();
        }

        #endregion


        #region Функциональная часть сетевой работы
        // Запуск сервера и вспомогательного потока акцептирования клиентских подключений
        // т.е. назначения сокетов ответственных за обмен сообщениями с соответствующим клиентским приложением
        void StartServer()
        {
            // Предотвратим повторный запуск сервера
            if (server == null)
            {
                // Блок перехвата исключений на случай запуска одновременно
                // двух серверных приложений с одинаковым портом.
                try
                {
                    stopNetwork = false;
                    countClient = 0;
                    UpdateClientsDisplay();
                    int port = int.Parse(textBoxPort.Text);
                    server = new TcpListener(IPAddress.Any, port);
                    server.Start();


                    Thread acceptThread = new Thread(AcceptClients);
                    acceptThread.Start();

                    // Если сервер запустился успешно, то цвет = оранж
                    BackColor = Color.Orange;
                    listBox1.Items.Add("Сервер запущен.");
                    listBox1.Items.Add("==================================");

                }
                catch
                {
                    listBox1.Items.Add("Произошла ошибка при запуске сервера.");
                    listBox1.Items.Add("==================================");
                    ErrorSound();
                }
            }
        }


        // Принудительная остановка сервера и запущенных потоков.
        void StopServer()
        {
            if (server != null)
            {
                server.Stop();
                server = null;
                stopNetwork = true;

                for (int i = 0; i < 2; i++)
                {
                    if (clients[i] != null) clients[i].Close();
                }

                // Визуально оповещаем, что сервер остановлен.
                this.BackColor = Color.FromName("Control");
            }
        }
        
        //Принимаем запросы клиентов на подключение и привязываем к каждому 
        //подключившемуся клиенту сокет для обменом сообщений.
        void AcceptClients()
        {
            while (true)
            {
                try
                {
                    this.clients[countClient] = server.AcceptTcpClient();
                    Thread readThread = new Thread(ReceiveRun);
                    readThread.Start(countClient);
                    countClient++;


                    // Данный метод находит родительский поток и выполняет делегат указанный 
                    // в качестве параметра в главном потоке, безопасно обновляя интерфейс формы.
                    Invoke(new UpdateClientsDisplayDelegate(UpdateClientsDisplay));
                }
                catch
                {
                    // Перехватим возможные исключения
                    ErrorSound();
                }


                if (countClient == MAXNUMCLIENTS || stopNetwork == true)
                {
                    break;
                }

            }
        }


        void SendToClients(string text, int skipindex)
        {
            for (int i = 0; i < MAXNUMCLIENTS; i++)
            {
                if (clients[i] != null)
                {
                    if (i == skipindex) continue;

                    // Подготовка и запуск асинхронной отправки сообщения.
                    NetworkStream ns = clients[i].GetStream();
                    byte[] myReadBuffer = Encoding.Default.GetBytes(text);
                    ns.BeginWrite(myReadBuffer, 0, myReadBuffer.Length,
                            new AsyncCallback(AsyncSendCompleted), ns);
                }
            }      
        }

        // Асинхронная отправка сообщения клиенту.
        public void AsyncSendCompleted(IAsyncResult ar)
        {
            NetworkStream ns = (NetworkStream)ar.AsyncState;
            ns.EndWrite(ar);
        }


        // Извлечение сообщения от клиента и ретрансляция полученного сообщения другим клиентам
        void ReceiveRun(object num)
        {
            while (true)
            {
                try
                {
                    string s = null;
                    NetworkStream ns = clients[(int)num].GetStream();

                    while (ns.DataAvailable == true)
                    {
                        // Определить точный размер буфера приема позволяет свойство класса СlientТcp - Available
                        byte[] buffer = new byte[clients[(int)num].Available];

                        ns.Read(buffer, 0, buffer.Length);
                        s += Encoding.Default.GetString(buffer);
                    }

                    if (s != null)
                    {
                        // Данный метод находит родительский поток и выполняет делегат указанный в качестве параметра 
                        // в главном потоке, безопасно обновляя интерфейс формы.
                        Invoke(new UpdateReceiveDisplayDelegate(UpdateReceiveDisplay), new object[] { (int)num, s });

                        // Принятое сообщение от клиента перенаправляем всем клиентам.
                        s = "Клиент №" + ((int)num).ToString() + ": " + s;
                        SendToClients(s,-1);
                        s = String.Empty;
                    }

                    
                    // Вынужденная строчка для экономия ресурсов процессора.
                    Thread.Sleep(100);
                }
                catch
                {
                    // Перехватим возможные исключения
                    ErrorSound();
                }
                if (stopNetwork == true) break;

            }
        }



        #endregion


        #region Визуализация сетевой работы

        // Получение сообщений от клиентов
        public void UpdateReceiveDisplay(int clientnum, string message)
        {
            
            listBox1.Items.Add("Клиент №" + clientnum.ToString() + ": " + message);
        }

        // Делегат доступа к элементу формы listBox1 из вспомогательного потока.
        protected delegate void UpdateReceiveDisplayDelegate(int clientcount, string message);

        public void UpdateClientsDisplay()
        {
            labelCountClient.Text = countClient.ToString();
        }

        // Делегат доступа к элементу формы labelCountClient из вспомогательного потока.
        protected delegate void UpdateClientsDisplayDelegate();

        // Звуковое оповещение о перехваченной ошибке.
        void ErrorSound()
        {
            Console.Beep(3000, 80);
            Console.Beep(1000, 100);
        }


        #endregion

        #region Перенос строки в листбоксе

        
        private void listBox1_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBox1.Items[e.Index].ToString(), listBox1.Font, listBox1.Width).Height;
        }

        private void listBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBox1.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        #endregion
    }
}
