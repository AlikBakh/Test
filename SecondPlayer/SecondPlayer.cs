using System;
using System.Drawing;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace SecondPlayer
{
    public partial class SecondPlayer : Form, IGameInteractive
    {
        public SecondPlayer()
        {
            InitializeComponent();
            KeyPreview = true;


            SecondAsk.Visible = false;
            FirstAsk.Visible = false;

            listBoxChat.HorizontalScrollbar = true;

            Location = new Point(800, 350);
        }
        #region Game
        void HotKeys_KeyDown(object sender, KeyEventArgs e)//горячме клавиши
        {
            if (e.KeyCode == Keys.Z)
            {
                Rock.PerformClick();
            }
            if (e.KeyCode == Keys.X)
            {
                Scissors.PerformClick();
            }
            if (e.KeyCode == Keys.C)
            {
                Paper.PerformClick();
            }
        }

        public const int rock = (int)Item.Rock;
        public const int scissors = (int)Item.Scissors;
        public const int paper = (int)Item.Paper;

        public bool flagItemRock2 = true;
        public bool flagItemScissors2 = true;
        public bool flagItemPaper2 = true;


        public int User2Choose;//дальнейшее значение предмета у 2-го игрока будет записан в майчуз
        public void Rock_Click(object sender, EventArgs e)//камень
        {
            User2Choose = rock;
        }
        public void Scissors_Click(object sender, EventArgs e)//ножницы
        {
            User2Choose = 2;
        }
        public void Paper_Click(object sender, EventArgs e)//бумага
        {
            User2Choose = 3;
        }



        #endregion

        //TcpClient tcpClient = new TcpClient();
        //IPAddress locaddr = IPAddress.Parse("127.0.0.1");
        //int port = 1434;
        // Объект содержащий рабочий сокет клиентского приложения
        TcpClient tcpСlient = new TcpClient();

        // Объект сетевого потока для приема и отправки сообщений
        NetworkStream ns;

        // Флаг для остановки потоков и завершения сетевой работы приложения
        bool stopNetwork;

        #region Управление клиентским приложением

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectGame();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendMessage();
            textBoxSend.Clear();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            DisconnectGame();
        }

        #endregion


        #region Функциональная часть Сетевая работа

        public void ConnectGame()// Попытка подключения к серверу
        {
            try
            {
                tcpСlient.Connect(textBoxIP.Text, int.Parse(textBoxPort.Text));
                ns = tcpСlient.GetStream();
                listBoxChat.Items.Add("Добро пожаловать!");
                listBoxChat.Items.Add("==================================");

                Thread th = new Thread(ReceiveRun);
                th.Start();
                // Рандомное цветовое оповещение о подключении.
                Random random = new Random();
                BackColor = Color.FromArgb(random.Next(255), random.Next(255), random.Next(255));
                ServerStatus.Text = "Successful connection";
            }
            catch
            {
                BackColor = Color.Gray;
                ServerStatus.ForeColor = Color.Red;
                ServerStatus.Text = "You are disconnected";
                listBoxChat.Items.Add("Произошла ошибка при запуске сервера.");
                listBoxChat.Items.Add("==================================");
                ErrorSound();
            }
        }

        public void DisconnectGame()//отключение
        {
            if (ns != null) ns.Close();
            if (tcpСlient != null) tcpСlient.Close();
            stopNetwork = true;
            // Цветовое оповещение об отключении.
            BackColor = Color.FromName("White");
            ServerStatus.ForeColor = Color.Red;
            ServerStatus.Text = "You are disconnected";
        }



        void SendMessage()
        {
            if (ns != null)
            {
                byte[] buffer = Encoding.Default.GetBytes(textBoxSend.Text);
                ns.Write(buffer, 0, buffer.Length);
            }
        }


        // Цикл извлечения сообщений, запускается в отдельном потоке.
        void ReceiveRun()
        {
            while (true)
            {
                try
                {
                    string s = null;
                    while (ns.DataAvailable == true)
                    {
                        // Определение необходимого размера буфера приема.
                        byte[] buffer = new byte[tcpСlient.Available];

                        ns.Read(buffer, 0, buffer.Length);
                        s += Encoding.Default.GetString(buffer);
                    }

                    if (s != null)
                    {
                        ShowReceiveMessage(s);
                        s = String.Empty;
                    }

                    Thread.Sleep(100);
                }
                catch
                {
                    ErrorSound();
                }

                if (stopNetwork == true) break;

            }
        }
        #endregion


        #region Информации о сетевой работе

        // Код доступа к свойствам объектов главной формы  из других потоков
        delegate void UpdateReceiveDisplayDelegate(string message);
        void ShowReceiveMessage(string message)
        {
            if (listBoxChat.InvokeRequired == true)
            {
                UpdateReceiveDisplayDelegate rdd = new UpdateReceiveDisplayDelegate(ShowReceiveMessage);

                // Данный метод вызывается в дочернем потоке,  ищет основной поток и
                //выполняет делегат указанный в качестве параметра в главном потоке, безопасно обновляя интерфейс формы.
                Invoke(rdd, new object[] { message });
            }
            else
            {
                // Если не требуется вызывать метод Invoke, обратимся напрямую к элементу формы.
                listBoxChat.Items.Add(message);

            }
        }

        // Звуковое оповещение о перехваченной ошибке.
        void ErrorSound()
        {
            Console.Beep(2000, 80);
            Console.Beep(3000, 120);
        }


        #endregion


        #region Перенос строки в листбоксе


        private void listBoxChat_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(listBoxChat.Items[e.Index].ToString(), listBoxChat.Font, listBoxChat.Width).Height;
        }

        private void listBoxChat_DrawItem(object sender, DrawItemEventArgs e)
        {
            listBoxChat.TopIndex = listBoxChat.Items.Count - 1;

            if (listBoxChat.Items.Count > 0)
            {
                e.DrawBackground();
                e.DrawFocusRectangle();
                e.Graphics.DrawString(listBoxChat.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
            }
        }
        #endregion

        private void ClearChat_Click(object sender, EventArgs e)
        {
            listBoxChat.Items.Clear();
        }
    }
}